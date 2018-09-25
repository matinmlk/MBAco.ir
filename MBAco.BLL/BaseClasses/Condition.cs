
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using Microsoft.VisualBasic;

namespace MBAco.BLL
{
    public abstract class Condition
    {

        #region "Fields"

        //Used to ensure we get the same instance of a particular ParameterExpression
        //across multiple queries

        private static Dictionary<string, ParameterExpression> ParamTable = new Dictionary<string, ParameterExpression>();
        //The expression tree which will be passed to the LINQ to SQL runtime

        protected internal LambdaExpression LambdaExpr;
        //Enumerates all the different comparisons which can be performed
        public enum Compare
        {
            Or = ExpressionType.Or,
            And = ExpressionType.And,
            Xor = ExpressionType.ExclusiveOr,
            Not = ExpressionType.Not,
            Equal = ExpressionType.Equal,
            Like = ExpressionType.TypeIs + 1,
            NotEqual = ExpressionType.NotEqual,
            OrElse = ExpressionType.OrElse,
            AndAlso = ExpressionType.AndAlso,
            LessThan = ExpressionType.LessThan,
            GreaterThan = ExpressionType.GreaterThan,
            LessThanOrEqual = ExpressionType.LessThanOrEqual,
            GreaterThanOrEqual = ExpressionType.GreaterThanOrEqual
        }

        #endregion

        #region "Public Methods"

        //Constructs a Condition with T as the element type and S as the value's type
        public static Condition<T, S> Create<T, S>(IEnumerable<T> dataSource, string propertyName, Compare condType, S value)
        {

            return new Condition<T, S>(propertyName, condType, value);
        }

        //Constructs a Condition with T as the element type and valueType as the value's type
        //This is useful for situations where you won't know the value's type until runtime.
        public static Condition<T> Create<T>(IEnumerable<T> dataSource, string propertyName, Compare condType, object value, Type valueType)
        {

            return new Condition<T>(propertyName, condType, value, valueType);
        }


        /// <summary>
        /// Creates a Condition which combines two other Conditions
        /// </summary>
        /// <typeparam name="T">The type the condition will execute against</typeparam>
        /// <param name="cond1">The first Condition</param>
        /// <param name="condType">The operator to use on the conditions</param>
        /// <param name="cond2">The second Condition</param>
        /// <returns>A new Condition which combines two Conditions into one according to the specified operator</returns>
        /// <remarks></remarks>
        public static Condition<T> Combine<T>(Condition<T> cond1, Compare condType, Condition<T> cond2)
        {
            return Condition<T>.Combine(cond1, condType, cond2);
        }

        //Combines multiple conditions according to the specified operator
        public static Condition<T> Combine<T>(Condition<T> cond1, Compare condType, params Condition<T>[] conditions)
        {
            return Condition<T>.Combine(cond1, condType, conditions);
        }

        public override string ToString()
        {
            return LambdaExpr.ToString();
        }

        public LambdaExpression ToLambdaExpression()
        {
            return LambdaExpr;
        }
        #endregion

        #region "Protected Methods"

        //Combines two Expressions according to the specified operator (condType)
        protected static Expression CombineExpression(Expression left, Compare condType, Expression right)
        {

            //Join the Expressions based on the operator
            switch (condType)
            {
                case Compare.Or:
                    return Expression.Or(left, right);
                case Compare.And:
                    return Expression.And(left, right);
                case Compare.Xor:
                    return Expression.ExclusiveOr(left, right);
                case Compare.Equal:
                    return Expression.Equal(left, right);
                case Compare.OrElse:
                    return Expression.OrElse(left, right);
                case Compare.AndAlso:
                    return Expression.AndAlso(left, right);
                case Compare.NotEqual:
                    return Expression.NotEqual(left, right);
                case Compare.LessThan:
                    return Expression.LessThan(left, right);
                case Compare.GreaterThan:
                    return Expression.GreaterThan(left, right);
                case Compare.LessThanOrEqual:
                    return Expression.LessThanOrEqual(left, right);
                case Compare.GreaterThanOrEqual:
                    return Expression.GreaterThanOrEqual(left, right);
                case Compare.Like:
                    dynamic m = typeof(Microsoft.VisualBasic.CompilerServices.Operators).GetMethod("LikeString");
                    return Expression.Call(m, left, right, Expression.Constant(CompareMethod.Binary));
                //For example
                //Condition<Shahmat.Admin.BusinessModel.UserItem> c2 = new Condition<BusinessModel.UserItem>("UserName", Condition.Compare.Like, "*t*", typeof(String));
                default:
                    throw new ArgumentException("Not a valid Condition Type", "condType", null);
            }
        }

        //Since both type parameters must be the same, we can turn what would normally
        //be a Func(Of T, T, Boolean) into a Func(Of T, Boolean)
        protected static Func<T, bool> CombineFunc<T>(Func<T, bool> d1, Compare condType, Func<T, bool> d2)
        {

            //Return a delegate which combines delegates d1 and d2
            switch (condType)
            {
                case Compare.Or:
                    return x => d1(x) | d2(x);
                case Compare.And:
                    return x => d1(x) & d2(x);
                case Compare.Xor:
                    return x => d1(x) ^ d2(x);
                case Compare.Equal:
                    return x => d1(x) == d2(x);
                case Compare.OrElse:
                    return x => d1(x) || d2(x);
                case Compare.AndAlso:
                    return x => d1(x) && d2(x);
                case Compare.NotEqual:
                    return x => d1(x) != d2(x);
                //case Compare.LessThan:
                //    return x => d1(x) < d2(x);
                //case Compare.GreaterThan:
                //    return x => d1(x) > d2(x);
                //case Compare.LessThanOrEqual:
                //    return x => d1(x) <= d2(x);
                //case Compare.GreaterThanOrEqual:
                //    return x => d1(x) >= d2(x);
                default:
                    throw new ArgumentException("Not a valid Condition Type", "condType");
            }
        }

        //Guarantees that we get the same instance of a ParameterExpression for a given type t.
        protected static ParameterExpression GetParamInstance(Type dataType)
        {

            //Parameters are matched by reference, not by name, so we cache the instances in a Dictionary.
            if (!ParamTable.ContainsKey(dataType.Name))
            {
                ParamTable.Add(dataType.Name, Expression.Parameter(dataType, dataType.Name));
            }

            return ParamTable[dataType.Name];
        }

        #endregion

    }

    public class Condition<T> : Condition
    {

        //Delegate that contains a compiled expression tree which can be run locally
        internal Func<T, bool> del;

        #region "Constructors"

        internal Condition()
        {
        }

        public Condition(string propName, Compare condType, object value)
        {
            //Split the string to handle nested property access
            string[] s = propName.Split('.');

            //Get the PropertyInfo instance for propName
            PropertyInfo pInfo = typeof(T).GetProperty(s[0]);
            Type valueType = pInfo.PropertyType;
            ParameterExpression paramExpr = GetParamInstance(typeof(T));
            MemberExpression callExpr = Expression.MakeMemberAccess(paramExpr, pInfo);

            //For each member specified, construct the additional MemberAccessExpression
            //For example, if the user says "myCustomer.Order.OrderID = 4" we need an
            //additional MemberAccessExpression for "Order.OrderID = 4"
            for (int i = 1; i <= s.Length - 1; i++)
            {
                pInfo = pInfo.PropertyType.GetProperty(s[i]);
                callExpr = Expression.MakeMemberAccess(callExpr, pInfo);
            }

            //ConstantExpression representing the value on the left side of the operator
            ConstantExpression valueExpr = Expression.Constant(value, valueType);

            Expression b = CombineExpression(callExpr, condType, valueExpr);
            LambdaExpr = Expression.Lambda<Func<T, bool>>(b, new ParameterExpression[] { paramExpr });

            //Compile the lambda expression into a delegate
            del = (Func<T, bool>)LambdaExpr.Compile();
        }

        public Condition(string propName, Compare condType, object value, Type valueType)
        {
            //Split the string to handle nested property access
            string[] s = propName.Split('.');

            //Get the PropertyInfo instance for propName
            PropertyInfo pInfo = typeof(T).GetProperty(s[0]);
            ParameterExpression paramExpr = GetParamInstance(typeof(T));
            MemberExpression callExpr = Expression.MakeMemberAccess(paramExpr, pInfo);

            //For each member specified, construct the additional MemberAccessExpression
            //For example, if the user says "myCustomer.Order.OrderID = 4" we need an
            //additional MemberAccessExpression for "Order.OrderID = 4"
            for (int i = 1; i <= s.Length - 1; i++)
            {
                pInfo = pInfo.PropertyType.GetProperty(s[i]);
                callExpr = Expression.MakeMemberAccess(callExpr, pInfo);
            }

            //ConstantExpression representing the value on the left side of the operator
            ConstantExpression valueExpr = Expression.Constant(value, valueType);

            Expression b = CombineExpression(callExpr, condType, valueExpr);
            LambdaExpr = Expression.Lambda<Func<T, bool>>(b, new ParameterExpression[] { paramExpr });

            //Compile the lambda expression into a delegate
            del = (Func<T, bool>)LambdaExpr.Compile();
        }

        #endregion

        #region "Methods"

        //Combines two conditions according to the specified operator
        static internal Condition<T> Combine(Condition<T> cond1, Compare condType, Condition<T> cond2)
        {
            Condition<T> c = new Condition<T>();

            Expression b = CombineExpression(cond1.LambdaExpr.Body, condType, cond2.LambdaExpr.Body);

            ParameterExpression[] paramExpr = new ParameterExpression[] { GetParamInstance(typeof(T)) };

            //Create the LambdaExpression and compile the delegate
            c.LambdaExpr = Expression.Lambda<Func<T, bool>>(b, paramExpr);
            c.del = Condition.CombineFunc(cond1.del, condType, cond2.del);

            return c;
        }

        //Combines multiple conditions according to the specified operator
        static internal Condition<T> Combine(Condition<T> cond1, Compare condType, params Condition<T>[] conditions)
        {
            dynamic finalCond = cond1;
            foreach (object c_loopVariable in conditions)
            {
                var c = c_loopVariable;
                finalCond = Condition.Combine(finalCond, condType, c);
            }

            return finalCond;
        }

        //Run query locally instead of remotely
        public bool Matches(T row)
        {
            return del(row);
            //passes the row into the delegate to see if it's a match
        }

        #endregion

        #region "Overloaded Operators"

        //Overloaded operators - allows syntax like "(condition1 Or condition2) And condition3"
        public static Condition<T> operator &(Condition<T> c1, Condition<T> c2)
        {
            return Condition.Combine(c1, Compare.And, c2);
        }

        public static Condition<T> operator |(Condition<T> c1, Condition<T> c2)
        {
            return Condition.Combine(c1, Compare.Or, c2);
        }

        public static Condition<T> operator ^(Condition<T> c1, Condition<T> c2)
        {
            return Condition.Combine(c1, Compare.Xor, c2);
        }

        #endregion
    }

    //Represents a condition like "object.Property = value"
    //In this case object is of type T, and value is of type S
    //
    //Even though most of the logic for this is already in the base class, 
    //defining a second generic parameter means the user doesn't have to
    //pass in a System.Type - it can just be inferred.
    public class Condition<T, S> : Condition<T>
    {
        internal Condition(string propName, Compare condType, S value)
            : base(propName, condType, value, typeof(S))
        {
        }

    }
}

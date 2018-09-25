
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace MBAco.BLL
{
   public class SearchItem<TList, TChild>
        where TList : class, ISearchable, new()
        where TChild : class
    {
        #region Fields and Properties
        private TList m_entity = new TList();

        protected Dictionary<Condition<TChild>, Condition.Compare> conditions = new Dictionary<Condition<TChild>, Condition.Compare>();
        #endregion //Fields and Properties

        #region Methods
        public ICollection<TChild> Search()
        {
            return Search(-1);
        }

        public ICollection<TChild> Search(long userId)
        {
            return Search("en-US", userId); ;
        }

        public ICollection<TChild> Search(string cultureID, long userId)
        {

            ICollection<TChild> e = new Collection<TChild>();
            LambdaExpression lam = getConditions();
            IQueryable<object> lst;
            if (userId == -1)
                lst = m_entity.Search(lam, cultureID, -1);
            else
                lst = m_entity.Search(lam, cultureID, userId);
            foreach (var item in lst)
            {
                e.Add((TChild)item);
            }
            return e;
        }

        public void AddCondition(string propertyName, object propertyValue, Condition.Compare combineType)
        {
            //Split the string to handle nested property access
            string[] s = propertyName.Split('.');

            //Get the PropertyInfo instance for propName
            PropertyInfo pInfo = typeof(TChild).GetProperty(s[0]);
            Type valueType = pInfo.PropertyType;
            Condition.Compare conditionType = Condition.Compare.Equal;
            if (valueType.Name == "String")
            {
                conditionType = Condition.Compare.Like;
                string m_propertyValue = (string)propertyValue;
                AddCondition(propertyName, conditionType, m_propertyValue, valueType, combineType);

            }
            else
            {
                conditionType = Condition.Compare.Equal;
                if (valueType.Name == "Int64")
                {
                    long m_propertyValue = Convert.ToInt64(propertyValue);
                    AddCondition(propertyName, conditionType, m_propertyValue, valueType, combineType);

                }
                else if (valueType.Name == "Int16")
                {
                    Int16 m_propertyValue = Convert.ToInt16(propertyValue);
                    AddCondition(propertyName, conditionType, m_propertyValue, valueType, combineType);

                }
                else
                {
                    AddCondition(propertyName, conditionType, propertyValue, valueType, combineType);
                }

            }
        }

        public void AddCondition(string propertyName, Condition.Compare conditionType, object propertyValue, System.Type valueType, Condition.Compare combineType)
        {
            Condition<TChild> c = new Condition<TChild>(propertyName, conditionType, propertyValue, valueType);
            conditions.Add(c, combineType);
        }


        public void AddCondition(Condition<TChild> c, Condition.Compare combineType)
        {
            conditions.Add(c, combineType);
        }

        public LambdaExpression getConditions()
        {
            Condition<TChild> c = new Condition<TChild>("ObjectId", Condition.Compare.NotEqual, "-1", typeof(string));

            Condition<TChild> c1 = new Condition<TChild>();
            Condition<TChild> c2 = new Condition<TChild>();
            bool flag = true;
            foreach (var item in conditions)
            {
                if (flag)
                {
                    c1 = item.Key;
                    flag = false;
                    continue;
                }
                c1 = Condition<TChild>.Combine<TChild>(c1, item.Value, item.Key);
            }
            c = Condition<TChild>.Combine<TChild>(c, Condition.Compare.And, c1);
            return c.ToLambdaExpression();
        }
        #endregion //End Methods
    }
}

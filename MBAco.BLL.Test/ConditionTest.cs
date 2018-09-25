using MBAco.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace MBAco.BLL.Test
{
    
    
    /// <summary>
    ///This is a test class for ConditionTest and is intended
    ///to contain all ConditionTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ConditionTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Condition`2 Constructor
        ///</summary>
        public void ConditionConstructorTest3Helper<T, S>()
        {
            string propName = string.Empty; // TODO: Initialize to an appropriate value
            Condition.Compare condType = new Condition.Compare(); // TODO: Initialize to an appropriate value
            S value = default(S); // TODO: Initialize to an appropriate value
            Condition<T, S> target = new Condition<T, S>(propName, condType, value);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void ConditionConstructorTest3()
        {
            ConditionConstructorTest3Helper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Condition`1 Constructor
        ///</summary>
        public void ConditionConstructorTestHelper<T>()
        {
            string propName = string.Empty; // TODO: Initialize to an appropriate value
            Condition.Compare condType = new Condition.Compare(); // TODO: Initialize to an appropriate value
            object value = null; // TODO: Initialize to an appropriate value
            Type valueType = null; // TODO: Initialize to an appropriate value
            Condition<T> target = new Condition<T>(propName, condType, value, valueType);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void ConditionConstructorTest()
        {
            ConditionConstructorTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Condition`1 Constructor
        ///</summary>
        public void ConditionConstructorTest1Helper<T>()
        {
            string propName = string.Empty; // TODO: Initialize to an appropriate value
            Condition.Compare condType = new Condition.Compare(); // TODO: Initialize to an appropriate value
            object value = null; // TODO: Initialize to an appropriate value
            Condition<T> target = new Condition<T>(propName, condType, value);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void ConditionConstructorTest1()
        {
            ConditionConstructorTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Condition`1 Constructor
        ///</summary>
        public void ConditionConstructorTest2Helper<T>()
        {
            Condition<T> target = new Condition<T>();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void ConditionConstructorTest2()
        {
            ConditionConstructorTest2Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Combine
        ///</summary>
        public void CombineTest2Helper<T>()
        {
            Condition<T> cond1 = null; // TODO: Initialize to an appropriate value
            Condition.Compare condType = new Condition.Compare(); // TODO: Initialize to an appropriate value
            Condition<T>[] conditions = null; // TODO: Initialize to an appropriate value
            Condition<T> expected = null; // TODO: Initialize to an appropriate value
            Condition<T> actual;
            actual = Condition<T>.Combine(cond1, condType, conditions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void CombineTest2()
        {
            CombineTest2Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Combine
        ///</summary>
        public void CombineTest3Helper<T>()
        {
            Condition<T> cond1 = null; // TODO: Initialize to an appropriate value
            Condition.Compare condType = new Condition.Compare(); // TODO: Initialize to an appropriate value
            Condition<T> cond2 = null; // TODO: Initialize to an appropriate value
            Condition<T> expected = null; // TODO: Initialize to an appropriate value
            Condition<T> actual;
            actual = Condition<T>.Combine(cond1, condType, cond2);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void CombineTest3()
        {
            CombineTest3Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Matches
        ///</summary>
        public void MatchesTestHelper<T>()
        {
            Condition<T> target = new Condition<T>(); // TODO: Initialize to an appropriate value
            T row = default(T); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Matches(row);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void MatchesTest()
        {
            MatchesTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for op_BitwiseAnd
        ///</summary>
        public void op_BitwiseAndTestHelper<T>()
        {
            Condition<T> c1 = null; // TODO: Initialize to an appropriate value
            Condition<T> c2 = null; // TODO: Initialize to an appropriate value
            Condition<T> expected = null; // TODO: Initialize to an appropriate value
            Condition<T> actual;
            actual = (c1 & c2);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void op_BitwiseAndTest()
        {
            op_BitwiseAndTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for op_BitwiseOr
        ///</summary>
        public void op_BitwiseOrTestHelper<T>()
        {
            Condition<T> c1 = null; // TODO: Initialize to an appropriate value
            Condition<T> c2 = null; // TODO: Initialize to an appropriate value
            Condition<T> expected = null; // TODO: Initialize to an appropriate value
            Condition<T> actual;
            actual = (c1 | c2);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void op_BitwiseOrTest()
        {
            op_BitwiseOrTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for op_ExclusiveOr
        ///</summary>
        public void op_ExclusiveOrTestHelper<T>()
        {
            Condition<T> c1 = null; // TODO: Initialize to an appropriate value
            Condition<T> c2 = null; // TODO: Initialize to an appropriate value
            Condition<T> expected = null; // TODO: Initialize to an appropriate value
            Condition<T> actual;
            actual = (c1 ^ c2);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void op_ExclusiveOrTest()
        {
            op_ExclusiveOrTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Combine
        ///</summary>
        public void CombineTestHelper<T>()
        {
            Condition<T> cond1 = null; // TODO: Initialize to an appropriate value
            Condition.Compare condType = new Condition.Compare(); // TODO: Initialize to an appropriate value
            Condition<T> cond2 = null; // TODO: Initialize to an appropriate value
            Condition<T> expected = null; // TODO: Initialize to an appropriate value
            Condition<T> actual;
            actual = Condition.Combine<T>(cond1, condType, cond2);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void CombineTest()
        {
            CombineTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Combine
        ///</summary>
        public void CombineTest1Helper<T>()
        {
            Condition<T> cond1 = null; // TODO: Initialize to an appropriate value
            Condition.Compare condType = new Condition.Compare(); // TODO: Initialize to an appropriate value
            Condition<T>[] conditions = null; // TODO: Initialize to an appropriate value
            Condition<T> expected = null; // TODO: Initialize to an appropriate value
            Condition<T> actual;
            actual = Condition.Combine<T>(cond1, condType, conditions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void CombineTest1()
        {
            CombineTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for CombineExpression
        ///</summary>
        [TestMethod()]
        [DeploymentItem("MBAco.BLL.dll")]
        public void CombineExpressionTest()
        {
            Expression left = null; // TODO: Initialize to an appropriate value
            Condition.Compare condType = new Condition.Compare(); // TODO: Initialize to an appropriate value
            Expression right = null; // TODO: Initialize to an appropriate value
            Expression expected = null; // TODO: Initialize to an appropriate value
            Expression actual;
            actual = Condition_Accessor.CombineExpression(left, condType, right);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Create
        ///</summary>
        public void CreateTestHelper<T, S>()
        {
            IEnumerable<T> dataSource = null; // TODO: Initialize to an appropriate value
            string propertyName = string.Empty; // TODO: Initialize to an appropriate value
            Condition.Compare condType = new Condition.Compare(); // TODO: Initialize to an appropriate value
            S value = default(S); // TODO: Initialize to an appropriate value
            Condition<T, S> expected = null; // TODO: Initialize to an appropriate value
            Condition<T, S> actual;
            actual = Condition.Create<T, S>(dataSource, propertyName, condType, value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void CreateTest()
        {
            CreateTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Create
        ///</summary>
        public void CreateTest1Helper<T>()
        {
            IEnumerable<T> dataSource = null; // TODO: Initialize to an appropriate value
            string propertyName = string.Empty; // TODO: Initialize to an appropriate value
            Condition.Compare condType = new Condition.Compare(); // TODO: Initialize to an appropriate value
            object value = null; // TODO: Initialize to an appropriate value
            Type valueType = null; // TODO: Initialize to an appropriate value
            Condition<T> expected = null; // TODO: Initialize to an appropriate value
            Condition<T> actual;
            actual = Condition.Create<T>(dataSource, propertyName, condType, value, valueType);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void CreateTest1()
        {
            CreateTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetParamInstance
        ///</summary>
        [TestMethod()]
        [DeploymentItem("MBAco.BLL.dll")]
        public void GetParamInstanceTest()
        {
            Type dataType = null; // TODO: Initialize to an appropriate value
            ParameterExpression expected = null; // TODO: Initialize to an appropriate value
            ParameterExpression actual;
            actual = Condition_Accessor.GetParamInstance(dataType);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        internal virtual Condition CreateCondition()
        {
            // TODO: Instantiate an appropriate concrete class.
            Condition target = null;
            return target;
        }

        /// <summary>
        ///A test for ToLambdaExpression
        ///</summary>
        [TestMethod()]
        public void ToLambdaExpressionTest()
        {
            Condition target = CreateCondition(); // TODO: Initialize to an appropriate value
            LambdaExpression expected = null; // TODO: Initialize to an appropriate value
            LambdaExpression actual;
            actual = target.ToLambdaExpression();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToString
        ///</summary>
        [TestMethod()]
        public void ToStringTest()
        {
            Condition target = CreateCondition(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

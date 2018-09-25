using MBAco.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MBAco.BLL.Test
{
    
    
    /// <summary>
    ///This is a test class for SearchItemTest and is intended
    ///to contain all SearchItemTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SearchItemTest
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
        ///A test for SearchItem`2 Constructor
        ///</summary>
        public void SearchItemConstructorTestHelper<TList, TChild>()
            where TList : class , ISearchable, new()
            where TChild : class
        {
            SearchItem<TList, TChild> target = new SearchItem<TList, TChild>();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void SearchItemConstructorTest()
        {
            Assert.Inconclusive("No appropriate type parameter is found to satisfies the type constraint(s) of TLi" +
                    "st. Please call SearchItemConstructorTestHelper<TList, TChild>() with appropriat" +
                    "e type parameters.");
        }

        /// <summary>
        ///A test for AddCondition
        ///</summary>
        public void AddConditionTestHelper<TList, TChild>()
            where TList : class , ISearchable, new()
            where TChild : class
        {
            SearchItem<TList, TChild> target = new SearchItem<TList, TChild>(); // TODO: Initialize to an appropriate value
            string propertyName = string.Empty; // TODO: Initialize to an appropriate value
            Condition.Compare conditionType = new Condition.Compare(); // TODO: Initialize to an appropriate value
            object propertyValue = null; // TODO: Initialize to an appropriate value
            Type valueType = null; // TODO: Initialize to an appropriate value
            Condition.Compare combineType = new Condition.Compare(); // TODO: Initialize to an appropriate value
            target.AddCondition(propertyName, conditionType, propertyValue, valueType, combineType);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void AddConditionTest()
        {
            Assert.Inconclusive("No appropriate type parameter is found to satisfies the type constraint(s) of TLi" +
                    "st. Please call AddConditionTestHelper<TList, TChild>() with appropriate type pa" +
                    "rameters.");
        }

        /// <summary>
        ///A test for AddCondition
        ///</summary>
        public void AddConditionTest1Helper<TList, TChild>()
            where TList : class , ISearchable, new()
            where TChild : class
        {
            SearchItem<TList, TChild> target = new SearchItem<TList, TChild>(); // TODO: Initialize to an appropriate value
            Condition<TChild> c = null; // TODO: Initialize to an appropriate value
            Condition.Compare combineType = new Condition.Compare(); // TODO: Initialize to an appropriate value
            target.AddCondition(c, combineType);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void AddConditionTest1()
        {
            Assert.Inconclusive("No appropriate type parameter is found to satisfies the type constraint(s) of TLi" +
                    "st. Please call AddConditionTest1Helper<TList, TChild>() with appropriate type p" +
                    "arameters.");
        }

        /// <summary>
        ///A test for AddCondition
        ///</summary>
        public void AddConditionTest2Helper<TList, TChild>()
            where TList : class , ISearchable, new()
            where TChild : class
        {
            SearchItem<TList, TChild> target = new SearchItem<TList, TChild>(); // TODO: Initialize to an appropriate value
            string propertyName = string.Empty; // TODO: Initialize to an appropriate value
            object propertyValue = null; // TODO: Initialize to an appropriate value
            Condition.Compare combineType = new Condition.Compare(); // TODO: Initialize to an appropriate value
            target.AddCondition(propertyName, propertyValue, combineType);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void AddConditionTest2()
        {
            Assert.Inconclusive("No appropriate type parameter is found to satisfies the type constraint(s) of TLi" +
                    "st. Please call AddConditionTest2Helper<TList, TChild>() with appropriate type p" +
                    "arameters.");
        }

        /// <summary>
        ///A test for Search
        ///</summary>
        public void SearchTestHelper<TList, TChild>()
            where TList : class , ISearchable, new()
            where TChild : class
        {
            SearchItem<TList, TChild> target = new SearchItem<TList, TChild>(); // TODO: Initialize to an appropriate value
            ICollection<TChild> expected = null; // TODO: Initialize to an appropriate value
            ICollection<TChild> actual;
            actual = target.Search();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void SearchTest()
        {
            Assert.Inconclusive("No appropriate type parameter is found to satisfies the type constraint(s) of TLi" +
                    "st. Please call SearchTestHelper<TList, TChild>() with appropriate type paramete" +
                    "rs.");
        }

        /// <summary>
        ///A test for Search
        ///</summary>
        public void SearchTest1Helper<TList, TChild>()
            where TList : class , ISearchable, new()
            where TChild : class
        {
            SearchItem<TList, TChild> target = new SearchItem<TList, TChild>(); // TODO: Initialize to an appropriate value
            long userId = 0; // TODO: Initialize to an appropriate value
            ICollection<TChild> expected = null; // TODO: Initialize to an appropriate value
            ICollection<TChild> actual;
            actual = target.Search(userId);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void SearchTest1()
        {
            Assert.Inconclusive("No appropriate type parameter is found to satisfies the type constraint(s) of TLi" +
                    "st. Please call SearchTest1Helper<TList, TChild>() with appropriate type paramet" +
                    "ers.");
        }

        /// <summary>
        ///A test for Search
        ///</summary>
        public void SearchTest2Helper<TList, TChild>()
            where TList : class , ISearchable, new()
            where TChild : class
        {
            SearchItem<TList, TChild> target = new SearchItem<TList, TChild>(); // TODO: Initialize to an appropriate value
            string cultureID = string.Empty; // TODO: Initialize to an appropriate value
            long userId = 0; // TODO: Initialize to an appropriate value
            ICollection<TChild> expected = null; // TODO: Initialize to an appropriate value
            ICollection<TChild> actual;
            actual = target.Search(cultureID, userId);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void SearchTest2()
        {
            Assert.Inconclusive("No appropriate type parameter is found to satisfies the type constraint(s) of TLi" +
                    "st. Please call SearchTest2Helper<TList, TChild>() with appropriate type paramet" +
                    "ers.");
        }

        /// <summary>
        ///A test for getConditions
        ///</summary>
        public void getConditionsTestHelper<TList, TChild>()
            where TList : class , ISearchable, new()
            where TChild : class
        {
            SearchItem<TList, TChild> target = new SearchItem<TList, TChild>(); // TODO: Initialize to an appropriate value
            LambdaExpression expected = null; // TODO: Initialize to an appropriate value
            LambdaExpression actual;
            actual = target.getConditions();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void getConditionsTest()
        {
            Assert.Inconclusive("No appropriate type parameter is found to satisfies the type constraint(s) of TLi" +
                    "st. Please call getConditionsTestHelper<TList, TChild>() with appropriate type p" +
                    "arameters.");
        }
    }
}

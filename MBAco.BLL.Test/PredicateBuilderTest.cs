using MBAco.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq.Expressions;

namespace MBAco.BLL.Test
{
    
    
    /// <summary>
    ///This is a test class for PredicateBuilderTest and is intended
    ///to contain all PredicateBuilderTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PredicateBuilderTest
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
        ///A test for And
        ///</summary>
        public void AndTestHelper<T>()
        {
            Expression<Func<T, bool>> expr1 = null; // TODO: Initialize to an appropriate value
            Expression<Func<T, bool>> expr2 = null; // TODO: Initialize to an appropriate value
            Expression<Func<T, bool>> expected = null; // TODO: Initialize to an appropriate value
            Expression<Func<T, bool>> actual;
            actual = PredicateBuilder.And<T>(expr1, expr2);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void AndTest()
        {
            AndTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for False
        ///</summary>
        public void FalseTestHelper<T>()
        {
            Expression<Func<T, bool>> expected = null; // TODO: Initialize to an appropriate value
            Expression<Func<T, bool>> actual;
            actual = PredicateBuilder.False<T>();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void FalseTest()
        {
            FalseTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Or
        ///</summary>
        public void OrTestHelper<T>()
        {
            Expression<Func<T, bool>> expr1 = null; // TODO: Initialize to an appropriate value
            Expression<Func<T, bool>> expr2 = null; // TODO: Initialize to an appropriate value
            Expression<Func<T, bool>> expected = null; // TODO: Initialize to an appropriate value
            Expression<Func<T, bool>> actual;
            actual = PredicateBuilder.Or<T>(expr1, expr2);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void OrTest()
        {
            OrTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for True
        ///</summary>
        public void TrueTestHelper<T>()
        {
            Expression<Func<T, bool>> expected = null; // TODO: Initialize to an appropriate value
            Expression<Func<T, bool>> actual;
            actual = PredicateBuilder.True<T>();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void TrueTest()
        {
            TrueTestHelper<GenericParameterHelper>();
        }
    }
}

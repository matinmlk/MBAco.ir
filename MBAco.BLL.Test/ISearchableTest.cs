using MBAco.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq.Expressions;
using System.Linq;

namespace MBAco.BLL.Test
{
    
    
    /// <summary>
    ///This is a test class for ISearchableTest and is intended
    ///to contain all ISearchableTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ISearchableTest
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


        internal virtual ISearchable CreateISearchable()
        {
            // TODO: Instantiate an appropriate concrete class.
            ISearchable target = null;
            return target;
        }

        /// <summary>
        ///A test for Search
        ///</summary>
        [TestMethod()]
        public void SearchTest()
        {
            ISearchable target = CreateISearchable(); // TODO: Initialize to an appropriate value
            LambdaExpression predicate = null; // TODO: Initialize to an appropriate value
            long userId = 0; // TODO: Initialize to an appropriate value
            IQueryable<object> expected = null; // TODO: Initialize to an appropriate value
            IQueryable<object> actual;
            actual = target.Search(predicate, userId);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Search
        ///</summary>
        [TestMethod()]
        public void SearchTest1()
        {
            ISearchable target = CreateISearchable(); // TODO: Initialize to an appropriate value
            LambdaExpression predicate = null; // TODO: Initialize to an appropriate value
            string cultureID = string.Empty; // TODO: Initialize to an appropriate value
            long userId = 0; // TODO: Initialize to an appropriate value
            IQueryable<object> expected = null; // TODO: Initialize to an appropriate value
            IQueryable<object> actual;
            actual = target.Search(predicate, cultureID, userId);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Search
        ///</summary>
        [TestMethod()]
        public void SearchTest2()
        {
            ISearchable target = CreateISearchable(); // TODO: Initialize to an appropriate value
            string predicate = string.Empty; // TODO: Initialize to an appropriate value
            IQueryable<object> expected = null; // TODO: Initialize to an appropriate value
            IQueryable<object> actual;
            actual = target.Search(predicate);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Search
        ///</summary>
        [TestMethod()]
        public void SearchTest3()
        {
            ISearchable target = CreateISearchable(); // TODO: Initialize to an appropriate value
            LambdaExpression predicate = null; // TODO: Initialize to an appropriate value
            IQueryable<object> expected = null; // TODO: Initialize to an appropriate value
            IQueryable<object> actual;
            actual = target.Search(predicate);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

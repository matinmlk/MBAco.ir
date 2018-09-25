using MBAco.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;

namespace MBAco.BLL.Test
{
    
    
    /// <summary>
    ///This is a test class for BusinessListBaseTest and is intended
    ///to contain all BusinessListBaseTest Unit Tests
    ///</summary>
    [TestClass()]
    public class BusinessListBaseTest
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
        ///A test for Contains
        ///</summary>
        public void ContainsTestHelper<T>()
            where T : class
        {
            BusinessListBase<T> target = CreateBusinessListBase<T>(); // TODO: Initialize to an appropriate value
            T businessObject = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Contains(businessObject);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        internal virtual BusinessListBase<T> CreateBusinessListBase<T>()
            where T : class
        {
            // TODO: Instantiate an appropriate concrete class.
            BusinessListBase<T> target = null;
            return target;
        }

        [TestMethod()]
        public void ContainsTest()
        {
            ContainsTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for CountLocalizes
        ///</summary>
        public void CountLocalizesTestHelper<T>()
            where T : class
        {
            BusinessListBase<T> target = CreateBusinessListBase<T>(); // TODO: Initialize to an appropriate value
            string cultureID = string.Empty; // TODO: Initialize to an appropriate value
            long expected = 0; // TODO: Initialize to an appropriate value
            long actual;
            actual = target.CountLocalizes(cultureID);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void CountLocalizesTest()
        {
            CountLocalizesTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        public void DeleteTestHelper<T>()
            where T : class
        {
            BusinessListBase<T> target = CreateBusinessListBase<T>(); // TODO: Initialize to an appropriate value
            T businessObject = null; // TODO: Initialize to an appropriate value
            target.Delete(businessObject);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void DeleteTest()
        {
            DeleteTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetAll
        ///</summary>
        public void GetAllTestHelper<T>()
            where T : class
        {
            BusinessListBase<T> target = CreateBusinessListBase<T>(); // TODO: Initialize to an appropriate value
            string sortExpression = string.Empty; // TODO: Initialize to an appropriate value
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<T> expected = null; // TODO: Initialize to an appropriate value
            List<T> actual;
            actual = target.GetAll(sortExpression, maximumRows, startRowIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void GetAllTest()
        {
            GetAllTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetAll
        ///</summary>
        public void GetAllTest1Helper<T>()
            where T : class
        {
            BusinessListBase<T> target = CreateBusinessListBase<T>(); // TODO: Initialize to an appropriate value
            long userId = 0; // TODO: Initialize to an appropriate value
            List<T> expected = null; // TODO: Initialize to an appropriate value
            List<T> actual;
            actual = target.GetAll(userId);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void GetAllTest1()
        {
            GetAllTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetAll
        ///</summary>
        public void GetAllTest2Helper<T>()
            where T : class
        {
            BusinessListBase<T> target = CreateBusinessListBase<T>(); // TODO: Initialize to an appropriate value
            string searchString = string.Empty; // TODO: Initialize to an appropriate value
            bool searchPartial = false; // TODO: Initialize to an appropriate value
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<T> expected = null; // TODO: Initialize to an appropriate value
            List<T> actual;
            actual = target.GetAll(searchString, searchPartial, maximumRows, startRowIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void GetAllTest2()
        {
            GetAllTest2Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetAll
        ///</summary>
        public void GetAllTest3Helper<T>()
            where T : class
        {
            BusinessListBase<T> target = CreateBusinessListBase<T>(); // TODO: Initialize to an appropriate value
            List<T> expected = null; // TODO: Initialize to an appropriate value
            List<T> actual;
            actual = target.GetAll();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void GetAllTest3()
        {
            GetAllTest3Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetAll
        ///</summary>
        public void GetAllTest4Helper<T>()
            where T : class
        {
            BusinessListBase<T> target = CreateBusinessListBase<T>(); // TODO: Initialize to an appropriate value
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<T> expected = null; // TODO: Initialize to an appropriate value
            List<T> actual;
            actual = target.GetAll(maximumRows, startRowIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void GetAllTest4()
        {
            GetAllTest4Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetAll
        ///</summary>
        public void GetAllTest5Helper<T>()
            where T : class
        {
            BusinessListBase<T> target = CreateBusinessListBase<T>(); // TODO: Initialize to an appropriate value
            string sortExpression = string.Empty; // TODO: Initialize to an appropriate value
            List<T> expected = null; // TODO: Initialize to an appropriate value
            List<T> actual;
            actual = target.GetAll(sortExpression);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void GetAllTest5()
        {
            GetAllTest5Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetByForeignKey
        ///</summary>
        public void GetByForeignKeyTestHelper<T>()
            where T : class
        {
            BusinessListBase<T> target = CreateBusinessListBase<T>(); // TODO: Initialize to an appropriate value
            long Id = 0; // TODO: Initialize to an appropriate value
            List<T> expected = null; // TODO: Initialize to an appropriate value
            List<T> actual;
            actual = target.GetByForeignKey(Id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void GetByForeignKeyTest()
        {
            GetByForeignKeyTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Initialize
        ///</summary>
        public void InitializeTestHelper<T>()
            where T : class
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            BusinessListBase_Accessor<T> target = new BusinessListBase_Accessor<T>(param0); // TODO: Initialize to an appropriate value
            bool readOnly = false; // TODO: Initialize to an appropriate value
            target.Initialize(readOnly);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        internal virtual BusinessListBase_Accessor<T> CreateBusinessListBase_Accessor<T>()
            where T : class
        {
            // TODO: Instantiate an appropriate concrete class.
            BusinessListBase_Accessor<T> target = null;
            return target;
        }

        [TestMethod()]
        [DeploymentItem("MBAco.BLL.dll")]
        public void InitializeTest()
        {
            InitializeTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Insert
        ///</summary>
        public void InsertTestHelper<T>()
            where T : class
        {
            BusinessListBase<T> target = CreateBusinessListBase<T>(); // TODO: Initialize to an appropriate value
            T businessObject = null; // TODO: Initialize to an appropriate value
            target.Insert(businessObject);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void InsertTest()
        {
            InsertTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Search
        ///</summary>
        public void SearchTestHelper<T>()
            where T : class
        {
            BusinessListBase<T> target = CreateBusinessListBase<T>(); // TODO: Initialize to an appropriate value
            LambdaExpression predicate = null; // TODO: Initialize to an appropriate value
            string cultureID = string.Empty; // TODO: Initialize to an appropriate value
            long userId = 0; // TODO: Initialize to an appropriate value
            IQueryable<object> expected = null; // TODO: Initialize to an appropriate value
            IQueryable<object> actual;
            actual = target.Search(predicate, cultureID, userId);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void SearchTest()
        {
            SearchTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Search
        ///</summary>
        public void SearchTest1Helper<T>()
            where T : class
        {
            BusinessListBase<T> target = CreateBusinessListBase<T>(); // TODO: Initialize to an appropriate value
            string predicate = string.Empty; // TODO: Initialize to an appropriate value
            IQueryable<object> expected = null; // TODO: Initialize to an appropriate value
            IQueryable<object> actual;
            actual = target.Search(predicate);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void SearchTest1()
        {
            SearchTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Search
        ///</summary>
        public void SearchTest2Helper<T>()
            where T : class
        {
            BusinessListBase<T> target = CreateBusinessListBase<T>(); // TODO: Initialize to an appropriate value
            LambdaExpression predicate = null; // TODO: Initialize to an appropriate value
            long userId = 0; // TODO: Initialize to an appropriate value
            IQueryable<object> expected = null; // TODO: Initialize to an appropriate value
            IQueryable<object> actual;
            actual = target.Search(predicate, userId);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void SearchTest2()
        {
            SearchTest2Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Search
        ///</summary>
        public void SearchTest3Helper<T>()
            where T : class
        {
            BusinessListBase<T> target = CreateBusinessListBase<T>(); // TODO: Initialize to an appropriate value
            LambdaExpression predicate = null; // TODO: Initialize to an appropriate value
            IQueryable<object> expected = null; // TODO: Initialize to an appropriate value
            IQueryable<object> actual;
            actual = target.Search(predicate);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void SearchTest3()
        {
            SearchTest3Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Update
        ///</summary>
        public void UpdateTestHelper<T>()
            where T : class
        {
            BusinessListBase<T> target = CreateBusinessListBase<T>(); // TODO: Initialize to an appropriate value
            T businessObject = null; // TODO: Initialize to an appropriate value
            target.Update(businessObject);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void UpdateTest()
        {
            UpdateTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Count
        ///</summary>
        public void CountTestHelper<T>()
            where T : class
        {
            BusinessListBase<T> target = CreateBusinessListBase<T>(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Count;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void CountTest()
        {
            CountTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for IsReadOnly
        ///</summary>
        public void IsReadOnlyTestHelper<T>()
            where T : class
        {
            BusinessListBase<T> target = CreateBusinessListBase<T>(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsReadOnly;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void IsReadOnlyTest()
        {
            IsReadOnlyTestHelper<GenericParameterHelper>();
        }
    }
}

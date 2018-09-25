using MBAco.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MBAco.BusinessModel;
using System.Collections.Generic;

namespace MBAco.BLL.Test
{
    
    
    /// <summary>
    ///This is a test class for NotificationMessageTypeListBizTest and is intended
    ///to contain all NotificationMessageTypeListBizTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NotificationMessageTypeListBizTest
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
        ///A test for NotificationMessageTypeListBiz Constructor
        ///</summary>
        [TestMethod()]
        public void NotificationMessageTypeListBizConstructorTest()
        {
            NotificationMessageTypeListBiz target = new NotificationMessageTypeListBiz();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        [TestMethod()]
        public void DeleteTest()
        {
            long id = 0; // TODO: Initialize to an appropriate value
            NotificationMessageTypeListBiz.Delete(id);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteNotificationMessageTypeModel
        ///</summary>
        [TestMethod()]
        public void DeleteNotificationMessageTypeModelTest()
        {
            int notificationMessageTypeID = 0; // TODO: Initialize to an appropriate value
            NotificationMessageTypeListBiz.DeleteNotificationMessageTypeModel(notificationMessageTypeID);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        public void DisposeTest()
        {
            NotificationMessageTypeListBiz target = new NotificationMessageTypeListBiz(); // TODO: Initialize to an appropriate value
            target.Dispose();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for FindByNotificationMessageTypeId
        ///</summary>
        [TestMethod()]
        public void FindByNotificationMessageTypeIdTest()
        {
            long Id = 0; // TODO: Initialize to an appropriate value
            NotificationMessageTypeModel expected = null; // TODO: Initialize to an appropriate value
            NotificationMessageTypeModel actual;
            actual = NotificationMessageTypeListBiz.FindByNotificationMessageTypeId(Id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Get
        ///</summary>
        [TestMethod()]
        public void GetTest()
        {
            long id = 0; // TODO: Initialize to an appropriate value
            NotificationMessageTypeModel expected = null; // TODO: Initialize to an appropriate value
            NotificationMessageTypeModel actual;
            actual = NotificationMessageTypeListBiz.Get(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAll
        ///</summary>
        [TestMethod()]
        public void GetAllTest()
        {
            NotificationMessageTypeListBiz target = new NotificationMessageTypeListBiz(); // TODO: Initialize to an appropriate value
            string sortExpression = string.Empty; // TODO: Initialize to an appropriate value
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<NotificationMessageTypeModel> expected = null; // TODO: Initialize to an appropriate value
            List<NotificationMessageTypeModel> actual;
            actual = target.GetAll(sortExpression, maximumRows, startRowIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAll
        ///</summary>
        [TestMethod()]
        public void GetAllTest1()
        {
            NotificationMessageTypeListBiz target = new NotificationMessageTypeListBiz(); // TODO: Initialize to an appropriate value
            string sortExpression = string.Empty; // TODO: Initialize to an appropriate value
            List<NotificationMessageTypeModel> expected = null; // TODO: Initialize to an appropriate value
            List<NotificationMessageTypeModel> actual;
            actual = target.GetAll(sortExpression);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAll
        ///</summary>
        [TestMethod()]
        public void GetAllTest2()
        {
            NotificationMessageTypeListBiz target = new NotificationMessageTypeListBiz(); // TODO: Initialize to an appropriate value
            List<NotificationMessageTypeModel> expected = null; // TODO: Initialize to an appropriate value
            List<NotificationMessageTypeModel> actual;
            actual = target.GetAll();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAll
        ///</summary>
        [TestMethod()]
        public void GetAllTest3()
        {
            NotificationMessageTypeListBiz target = new NotificationMessageTypeListBiz(); // TODO: Initialize to an appropriate value
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<NotificationMessageTypeModel> expected = null; // TODO: Initialize to an appropriate value
            List<NotificationMessageTypeModel> actual;
            actual = target.GetAll(maximumRows, startRowIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAllWithSearch
        ///</summary>
        [TestMethod()]
        public void GetAllWithSearchTest()
        {
            NotificationMessageTypeListBiz target = new NotificationMessageTypeListBiz(); // TODO: Initialize to an appropriate value
            string searchString = string.Empty; // TODO: Initialize to an appropriate value
            bool searchPartial = false; // TODO: Initialize to an appropriate value
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<NotificationMessageTypeModel> expected = null; // TODO: Initialize to an appropriate value
            List<NotificationMessageTypeModel> actual;
            actual = target.GetAllWithSearch(searchString, searchPartial, maximumRows, startRowIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetNotificationMessageTypeModel
        ///</summary>
        [TestMethod()]
        public void GetNotificationMessageTypeModelTest()
        {
            int notificationMessageTypeID = 0; // TODO: Initialize to an appropriate value
            NotificationMessageTypeModel expected = null; // TODO: Initialize to an appropriate value
            NotificationMessageTypeModel actual;
            actual = NotificationMessageTypeListBiz.GetNotificationMessageTypeModel(notificationMessageTypeID);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for New
        ///</summary>
        [TestMethod()]
        public void NewTest()
        {
            NotificationMessageTypeModel expected = null; // TODO: Initialize to an appropriate value
            NotificationMessageTypeModel actual;
            actual = NotificationMessageTypeListBiz.New();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Save
        ///</summary>
        [TestMethod()]
        public void SaveTest()
        {
            NotificationMessageTypeModel param = null; // TODO: Initialize to an appropriate value
            NotificationMessageTypeModel expected = null; // TODO: Initialize to an appropriate value
            NotificationMessageTypeModel actual;
            actual = NotificationMessageTypeListBiz.Save(param);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Count
        ///</summary>
        [TestMethod()]
        public void CountTest()
        {
            NotificationMessageTypeListBiz target = new NotificationMessageTypeListBiz(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Count;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

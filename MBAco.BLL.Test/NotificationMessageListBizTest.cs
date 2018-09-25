using MBAco.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MBAco.BusinessModel;
using System.Collections.Generic;

namespace MBAco.BLL.Test
{
    
    
    /// <summary>
    ///This is a test class for NotificationMessageListBizTest and is intended
    ///to contain all NotificationMessageListBizTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NotificationMessageListBizTest
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
        ///A test for NotificationMessageListBiz Constructor
        ///</summary>
        [TestMethod()]
        public void NotificationMessageListBizConstructorTest()
        {
            NotificationMessageListBiz target = new NotificationMessageListBiz();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        [TestMethod()]
        public void DeleteTest()
        {
            long id = 0; // TODO: Initialize to an appropriate value
            NotificationMessageListBiz.Delete(id);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteNotificationMessageModel
        ///</summary>
        [TestMethod()]
        public void DeleteNotificationMessageModelTest()
        {
            int notificationMessageID = 0; // TODO: Initialize to an appropriate value
            NotificationMessageListBiz.DeleteNotificationMessageModel(notificationMessageID);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteNotificationMessagesByCulture
        ///</summary>
        [TestMethod()]
        public void DeleteNotificationMessagesByCultureTest()
        {
            int cultureID = 0; // TODO: Initialize to an appropriate value
            NotificationMessageListBiz.DeleteNotificationMessagesByCulture(cultureID);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteNotificationMessagesByType
        ///</summary>
        [TestMethod()]
        public void DeleteNotificationMessagesByTypeTest()
        {
            int notificationMessageTypeID = 0; // TODO: Initialize to an appropriate value
            NotificationMessageListBiz.DeleteNotificationMessagesByType(notificationMessageTypeID);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        public void DisposeTest()
        {
            NotificationMessageListBiz target = new NotificationMessageListBiz(); // TODO: Initialize to an appropriate value
            target.Dispose();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for FindByNotificationMessageId
        ///</summary>
        [TestMethod()]
        public void FindByNotificationMessageIdTest()
        {
            long Id = 0; // TODO: Initialize to an appropriate value
            NotificationMessageModel expected = null; // TODO: Initialize to an appropriate value
            NotificationMessageModel actual;
            actual = NotificationMessageListBiz.FindByNotificationMessageId(Id);
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
            NotificationMessageModel expected = null; // TODO: Initialize to an appropriate value
            NotificationMessageModel actual;
            actual = NotificationMessageListBiz.Get(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAll
        ///</summary>
        [TestMethod()]
        public void GetAllTest()
        {
            NotificationMessageListBiz target = new NotificationMessageListBiz(); // TODO: Initialize to an appropriate value
            string sortExpression = string.Empty; // TODO: Initialize to an appropriate value
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<NotificationMessageModel> expected = null; // TODO: Initialize to an appropriate value
            List<NotificationMessageModel> actual;
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
            NotificationMessageListBiz target = new NotificationMessageListBiz(); // TODO: Initialize to an appropriate value
            string sortExpression = string.Empty; // TODO: Initialize to an appropriate value
            List<NotificationMessageModel> expected = null; // TODO: Initialize to an appropriate value
            List<NotificationMessageModel> actual;
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
            NotificationMessageListBiz target = new NotificationMessageListBiz(); // TODO: Initialize to an appropriate value
            List<NotificationMessageModel> expected = null; // TODO: Initialize to an appropriate value
            List<NotificationMessageModel> actual;
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
            NotificationMessageListBiz target = new NotificationMessageListBiz(); // TODO: Initialize to an appropriate value
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<NotificationMessageModel> expected = null; // TODO: Initialize to an appropriate value
            List<NotificationMessageModel> actual;
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
            NotificationMessageListBiz target = new NotificationMessageListBiz(); // TODO: Initialize to an appropriate value
            string searchString = string.Empty; // TODO: Initialize to an appropriate value
            bool searchPartial = false; // TODO: Initialize to an appropriate value
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<NotificationMessageModel> expected = null; // TODO: Initialize to an appropriate value
            List<NotificationMessageModel> actual;
            actual = target.GetAllWithSearch(searchString, searchPartial, maximumRows, startRowIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetNotificationMessageModel
        ///</summary>
        [TestMethod()]
        public void GetNotificationMessageModelTest()
        {
            int notificationMessageID = 0; // TODO: Initialize to an appropriate value
            NotificationMessageModel expected = null; // TODO: Initialize to an appropriate value
            NotificationMessageModel actual;
            actual = NotificationMessageListBiz.GetNotificationMessageModel(notificationMessageID);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetNotificationMessagesByCulture
        ///</summary>
        [TestMethod()]
        public void GetNotificationMessagesByCultureTest()
        {
            NotificationMessageListBiz target = new NotificationMessageListBiz(); // TODO: Initialize to an appropriate value
            CultureModel culture = null; // TODO: Initialize to an appropriate value
            List<NotificationMessageModel> expected = null; // TODO: Initialize to an appropriate value
            List<NotificationMessageModel> actual;
            actual = target.GetNotificationMessagesByCulture(culture);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetNotificationMessagesByType
        ///</summary>
        [TestMethod()]
        public void GetNotificationMessagesByTypeTest()
        {
            NotificationMessageListBiz target = new NotificationMessageListBiz(); // TODO: Initialize to an appropriate value
            NotificationMessageTypeModel type = null; // TODO: Initialize to an appropriate value
            List<NotificationMessageModel> expected = null; // TODO: Initialize to an appropriate value
            List<NotificationMessageModel> actual;
            actual = target.GetNotificationMessagesByType(type);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for New
        ///</summary>
        [TestMethod()]
        public void NewTest()
        {
            NotificationMessageModel expected = null; // TODO: Initialize to an appropriate value
            NotificationMessageModel actual;
            actual = NotificationMessageListBiz.New();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Save
        ///</summary>
        [TestMethod()]
        public void SaveTest()
        {
            NotificationMessageModel param = null; // TODO: Initialize to an appropriate value
            NotificationMessageModel expected = null; // TODO: Initialize to an appropriate value
            NotificationMessageModel actual;
            actual = NotificationMessageListBiz.Save(param);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Count
        ///</summary>
        [TestMethod()]
        public void CountTest()
        {
            NotificationMessageListBiz target = new NotificationMessageListBiz(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Count;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

using MBAco.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MBAco.BusinessModel;
using MBAco.DAL;

namespace MBAco.BLL.Test
{
    
    
    /// <summary>
    ///This is a test class for NotificationMessageBizTest and is intended
    ///to contain all NotificationMessageBizTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NotificationMessageBizTest
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
        ///A test for NotificationMessageBiz Constructor
        ///</summary>
        [TestMethod()]
        public void NotificationMessageBizConstructorTest()
        {
            NotificationMessageBiz target = new NotificationMessageBiz();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        [TestMethod()]
        public void DeleteTest()
        {
            long id = 0; // TODO: Initialize to an appropriate value
            NotificationMessageBiz.Delete(id);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteItem
        ///</summary>
        [TestMethod()]
        public void DeleteItemTest()
        {
            NotificationMessageBiz target = new NotificationMessageBiz(); // TODO: Initialize to an appropriate value
            NotificationMessageModel dataItem = null; // TODO: Initialize to an appropriate value
            target.DeleteItem(dataItem);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteItem
        ///</summary>
        [TestMethod()]
        public void DeleteItemTest1()
        {
            NotificationMessageBiz target = new NotificationMessageBiz(); // TODO: Initialize to an appropriate value
            long id = 0; // TODO: Initialize to an appropriate value
            target.DeleteItem(id);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        public void DisposeTest()
        {
            NotificationMessageBiz target = new NotificationMessageBiz(); // TODO: Initialize to an appropriate value
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
            actual = NotificationMessageBiz.FindByNotificationMessageId(Id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Fromtbl_NotificationMessage
        ///</summary>
        [TestMethod()]
        public void Fromtbl_NotificationMessageTest()
        {
            tbl_NotificationMessage m_tbl_NotificationMessage = null; // TODO: Initialize to an appropriate value
            NotificationMessageModel expected = null; // TODO: Initialize to an appropriate value
            NotificationMessageModel actual;
            actual = NotificationMessageBiz.Fromtbl_NotificationMessage(m_tbl_NotificationMessage);
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
            actual = NotificationMessageBiz.Get(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetItem
        ///</summary>
        [TestMethod()]
        public void GetItemTest()
        {
            NotificationMessageBiz target = new NotificationMessageBiz(); // TODO: Initialize to an appropriate value
            long id = 0; // TODO: Initialize to an appropriate value
            NotificationMessageModel expected = null; // TODO: Initialize to an appropriate value
            NotificationMessageModel actual;
            actual = target.GetItem(id);
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
            actual = NotificationMessageBiz.New();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ObjectSave
        ///</summary>
        [TestMethod()]
        [DeploymentItem("MBAco.BLL.dll")]
        public void ObjectSaveTest()
        {
            NotificationMessageModel param = null; // TODO: Initialize to an appropriate value
            NotificationMessageModel expected = null; // TODO: Initialize to an appropriate value
            NotificationMessageModel actual;
            actual = NotificationMessageBiz_Accessor.ObjectSave(param);
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
            actual = NotificationMessageBiz.Save(param);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SaveItem
        ///</summary>
        [TestMethod()]
        public void SaveItemTest()
        {
            NotificationMessageBiz target = new NotificationMessageBiz(); // TODO: Initialize to an appropriate value
            NotificationMessageModel dataItem = null; // TODO: Initialize to an appropriate value
            NotificationMessageModel expected = null; // TODO: Initialize to an appropriate value
            NotificationMessageModel actual;
            actual = target.SaveItem(dataItem);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Totbl_NotificationMessage
        ///</summary>
        [TestMethod()]
        public void Totbl_NotificationMessageTest()
        {
            NotificationMessageModel param = null; // TODO: Initialize to an appropriate value
            tbl_NotificationMessage expected = null; // TODO: Initialize to an appropriate value
            tbl_NotificationMessage actual;
            actual = NotificationMessageBiz.Totbl_NotificationMessage(param);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

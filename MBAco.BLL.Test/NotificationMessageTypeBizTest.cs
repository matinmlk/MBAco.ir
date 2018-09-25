using MBAco.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MBAco.BusinessModel;
using MBAco.DAL;

namespace MBAco.BLL.Test
{
    
    
    /// <summary>
    ///This is a test class for NotificationMessageTypeBizTest and is intended
    ///to contain all NotificationMessageTypeBizTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NotificationMessageTypeBizTest
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
        ///A test for NotificationMessageTypeBiz Constructor
        ///</summary>
        [TestMethod()]
        public void NotificationMessageTypeBizConstructorTest()
        {
            NotificationMessageTypeBiz target = new NotificationMessageTypeBiz();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        [TestMethod()]
        public void DeleteTest()
        {
            long id = 0; // TODO: Initialize to an appropriate value
            NotificationMessageTypeBiz.Delete(id);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteItem
        ///</summary>
        [TestMethod()]
        public void DeleteItemTest()
        {
            NotificationMessageTypeBiz target = new NotificationMessageTypeBiz(); // TODO: Initialize to an appropriate value
            NotificationMessageTypeModel dataItem = null; // TODO: Initialize to an appropriate value
            target.DeleteItem(dataItem);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteItem
        ///</summary>
        [TestMethod()]
        public void DeleteItemTest1()
        {
            NotificationMessageTypeBiz target = new NotificationMessageTypeBiz(); // TODO: Initialize to an appropriate value
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
            NotificationMessageTypeBiz target = new NotificationMessageTypeBiz(); // TODO: Initialize to an appropriate value
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
            actual = NotificationMessageTypeBiz.FindByNotificationMessageTypeId(Id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Fromtbl_NotificationMessageType
        ///</summary>
        [TestMethod()]
        public void Fromtbl_NotificationMessageTypeTest()
        {
            tbl_NotificationMessageType m_tbl_NotificationMessageType = null; // TODO: Initialize to an appropriate value
            NotificationMessageTypeModel expected = null; // TODO: Initialize to an appropriate value
            NotificationMessageTypeModel actual;
            actual = NotificationMessageTypeBiz.Fromtbl_NotificationMessageType(m_tbl_NotificationMessageType);
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
            actual = NotificationMessageTypeBiz.Get(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetItem
        ///</summary>
        [TestMethod()]
        public void GetItemTest()
        {
            NotificationMessageTypeBiz target = new NotificationMessageTypeBiz(); // TODO: Initialize to an appropriate value
            long id = 0; // TODO: Initialize to an appropriate value
            NotificationMessageTypeModel expected = null; // TODO: Initialize to an appropriate value
            NotificationMessageTypeModel actual;
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
            NotificationMessageTypeModel expected = null; // TODO: Initialize to an appropriate value
            NotificationMessageTypeModel actual;
            actual = NotificationMessageTypeBiz.New();
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
            NotificationMessageTypeModel param = null; // TODO: Initialize to an appropriate value
            NotificationMessageTypeModel expected = null; // TODO: Initialize to an appropriate value
            NotificationMessageTypeModel actual;
            actual = NotificationMessageTypeBiz_Accessor.ObjectSave(param);
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
            actual = NotificationMessageTypeBiz.Save(param);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SaveItem
        ///</summary>
        [TestMethod()]
        public void SaveItemTest()
        {
            NotificationMessageTypeBiz target = new NotificationMessageTypeBiz(); // TODO: Initialize to an appropriate value
            NotificationMessageTypeModel dataItem = null; // TODO: Initialize to an appropriate value
            NotificationMessageTypeModel expected = null; // TODO: Initialize to an appropriate value
            NotificationMessageTypeModel actual;
            actual = target.SaveItem(dataItem);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Totbl_NotificationMessageType
        ///</summary>
        [TestMethod()]
        public void Totbl_NotificationMessageTypeTest()
        {
            NotificationMessageTypeModel param = null; // TODO: Initialize to an appropriate value
            tbl_NotificationMessageType expected = null; // TODO: Initialize to an appropriate value
            tbl_NotificationMessageType actual;
            actual = NotificationMessageTypeBiz.Totbl_NotificationMessageType(param);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

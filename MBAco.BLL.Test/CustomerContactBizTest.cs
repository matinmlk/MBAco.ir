using MBAco.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MBAco.BusinessModel;
using MBAco.DAL;

namespace MBAco.BLL.Test
{
    
    
    /// <summary>
    ///This is a test class for CustomerContactBizTest and is intended
    ///to contain all CustomerContactBizTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CustomerContactBizTest
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
        ///A test for CustomerContactBiz Constructor
        ///</summary>
        [TestMethod()]
        public void CustomerContactBizConstructorTest()
        {
            CustomerContactBiz target = new CustomerContactBiz();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        [TestMethod()]
        public void DeleteTest()
        {
            long id = 0; // TODO: Initialize to an appropriate value
            CustomerContactBiz.Delete(id);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteItem
        ///</summary>
        [TestMethod()]
        public void DeleteItemTest()
        {
            CustomerContactBiz target = new CustomerContactBiz(); // TODO: Initialize to an appropriate value
            CustomerContactModel dataItem = null; // TODO: Initialize to an appropriate value
            target.DeleteItem(dataItem);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteItem
        ///</summary>
        [TestMethod()]
        public void DeleteItemTest1()
        {
            CustomerContactBiz target = new CustomerContactBiz(); // TODO: Initialize to an appropriate value
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
            CustomerContactBiz target = new CustomerContactBiz(); // TODO: Initialize to an appropriate value
            target.Dispose();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for FindByCustomerContactId
        ///</summary>
        [TestMethod()]
        public void FindByCustomerContactIdTest()
        {
            long Id = 0; // TODO: Initialize to an appropriate value
            CustomerContactModel expected = null; // TODO: Initialize to an appropriate value
            CustomerContactModel actual;
            actual = CustomerContactBiz.FindByCustomerContactId(Id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Fromtbl_CustomerContact
        ///</summary>
        [TestMethod()]
        public void Fromtbl_CustomerContactTest()
        {
            tbl_CustomerContact m_tbl_CustomerContact = null; // TODO: Initialize to an appropriate value
            CustomerContactModel expected = null; // TODO: Initialize to an appropriate value
            CustomerContactModel actual;
            actual = CustomerContactBiz.Fromtbl_CustomerContact(m_tbl_CustomerContact);
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
            CustomerContactModel expected = null; // TODO: Initialize to an appropriate value
            CustomerContactModel actual;
            actual = CustomerContactBiz.Get(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetItem
        ///</summary>
        [TestMethod()]
        public void GetItemTest()
        {
            CustomerContactBiz target = new CustomerContactBiz(); // TODO: Initialize to an appropriate value
            long id = 0; // TODO: Initialize to an appropriate value
            CustomerContactModel expected = null; // TODO: Initialize to an appropriate value
            CustomerContactModel actual;
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
            CustomerContactModel expected = null; // TODO: Initialize to an appropriate value
            CustomerContactModel actual;
            actual = CustomerContactBiz.New();
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
            CustomerContactModel param = null; // TODO: Initialize to an appropriate value
            CustomerContactModel expected = null; // TODO: Initialize to an appropriate value
            CustomerContactModel actual;
            actual = CustomerContactBiz_Accessor.ObjectSave(param);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Save
        ///</summary>
        [TestMethod()]
        public void SaveTest()
        {
            CustomerContactModel param = null; // TODO: Initialize to an appropriate value
            CustomerContactModel expected = null; // TODO: Initialize to an appropriate value
            CustomerContactModel actual;
            actual = CustomerContactBiz.Save(param);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SaveItem
        ///</summary>
        [TestMethod()]
        public void SaveItemTest()
        {
            CustomerContactBiz target = new CustomerContactBiz(); // TODO: Initialize to an appropriate value
            CustomerContactModel dataItem = null; // TODO: Initialize to an appropriate value
            CustomerContactModel expected = null; // TODO: Initialize to an appropriate value
            CustomerContactModel actual;
            actual = target.SaveItem(dataItem);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Totbl_CustomerContact
        ///</summary>
        [TestMethod()]
        public void Totbl_CustomerContactTest()
        {
            CustomerContactModel param = null; // TODO: Initialize to an appropriate value
            tbl_CustomerContact expected = null; // TODO: Initialize to an appropriate value
            tbl_CustomerContact actual;
            actual = CustomerContactBiz.Totbl_CustomerContact(param);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

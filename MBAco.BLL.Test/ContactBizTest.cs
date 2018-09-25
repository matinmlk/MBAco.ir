using MBAco.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MBAco.BusinessModel;
using MBAco.DAL;

namespace MBAco.BLL.Test
{
    
    
    /// <summary>
    ///This is a test class for ContactBizTest and is intended
    ///to contain all ContactBizTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ContactBizTest
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
        ///A test for ContactBiz Constructor
        ///</summary>
        [TestMethod()]
        public void ContactBizConstructorTest()
        {
            ContactBiz target = new ContactBiz();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        [TestMethod()]
        public void DeleteTest()
        {
            long id = 0; // TODO: Initialize to an appropriate value
            ContactBiz.Delete(id);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteItem
        ///</summary>
        [TestMethod()]
        public void DeleteItemTest()
        {
            ContactBiz target = new ContactBiz(); // TODO: Initialize to an appropriate value
            ContactModel dataItem = null; // TODO: Initialize to an appropriate value
            target.DeleteItem(dataItem);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteItem
        ///</summary>
        [TestMethod()]
        public void DeleteItemTest1()
        {
            ContactBiz target = new ContactBiz(); // TODO: Initialize to an appropriate value
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
            ContactBiz target = new ContactBiz(); // TODO: Initialize to an appropriate value
            target.Dispose();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for FindByContactId
        ///</summary>
        [TestMethod()]
        public void FindByContactIdTest()
        {
            long Id = 0; // TODO: Initialize to an appropriate value
            ContactModel expected = null; // TODO: Initialize to an appropriate value
            ContactModel actual;
            actual = ContactBiz.FindByContactId(Id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Fromtbl_Contact
        ///</summary>
        [TestMethod()]
        public void Fromtbl_ContactTest()
        {
            tbl_Contact m_tbl_Contact = null; // TODO: Initialize to an appropriate value
            ContactModel expected = null; // TODO: Initialize to an appropriate value
            ContactModel actual;
            actual = ContactBiz.Fromtbl_Contact(m_tbl_Contact);
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
            ContactModel expected = null; // TODO: Initialize to an appropriate value
            ContactModel actual;
            actual = ContactBiz.Get(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetItem
        ///</summary>
        [TestMethod()]
        public void GetItemTest()
        {
            ContactBiz target = new ContactBiz(); // TODO: Initialize to an appropriate value
            long id = 0; // TODO: Initialize to an appropriate value
            ContactModel expected = null; // TODO: Initialize to an appropriate value
            ContactModel actual;
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
            ContactModel expected = null; // TODO: Initialize to an appropriate value
            ContactModel actual;
            actual = ContactBiz.New();
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
            ContactModel param = null; // TODO: Initialize to an appropriate value
            ContactModel expected = null; // TODO: Initialize to an appropriate value
            ContactModel actual;
            actual = ContactBiz_Accessor.ObjectSave(param);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Save
        ///</summary>
        [TestMethod()]
        public void SaveTest()
        {
            ContactModel param = null; // TODO: Initialize to an appropriate value
            ContactModel expected = null; // TODO: Initialize to an appropriate value
            ContactModel actual;
            actual = ContactBiz.Save(param);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SaveItem
        ///</summary>
        [TestMethod()]
        public void SaveItemTest()
        {
            ContactBiz target = new ContactBiz(); // TODO: Initialize to an appropriate value
            ContactModel dataItem = null; // TODO: Initialize to an appropriate value
            ContactModel expected = null; // TODO: Initialize to an appropriate value
            ContactModel actual;
            actual = target.SaveItem(dataItem);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Totbl_Contact
        ///</summary>
        [TestMethod()]
        public void Totbl_ContactTest()
        {
            ContactModel param = null; // TODO: Initialize to an appropriate value
            tbl_Contact expected = null; // TODO: Initialize to an appropriate value
            tbl_Contact actual;
            actual = ContactBiz.Totbl_Contact(param);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

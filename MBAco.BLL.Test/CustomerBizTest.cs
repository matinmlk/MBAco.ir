using MBAco.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MBAco.BusinessModel;
using MBAco.DAL;

namespace MBAco.BLL.Test
{
    
    
    /// <summary>
    ///This is a test class for CustomerBizTest and is intended
    ///to contain all CustomerBizTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CustomerBizTest
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
        ///A test for CustomerBiz Constructor
        ///</summary>
        [TestMethod()]
        public void CustomerBizConstructorTest()
        {
            CustomerBiz target = new CustomerBiz();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        [TestMethod()]
        public void DeleteTest()
        {
            long id = 0; // TODO: Initialize to an appropriate value
            CustomerBiz.Delete(id);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteItem
        ///</summary>
        [TestMethod()]
        public void DeleteItemTest()
        {
            CustomerBiz target = new CustomerBiz(); // TODO: Initialize to an appropriate value
            CustomerModel dataItem = null; // TODO: Initialize to an appropriate value
            target.DeleteItem(dataItem);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteItem
        ///</summary>
        [TestMethod()]
        public void DeleteItemTest1()
        {
            CustomerBiz target = new CustomerBiz(); // TODO: Initialize to an appropriate value
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
            CustomerBiz target = new CustomerBiz(); // TODO: Initialize to an appropriate value
            target.Dispose();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for FindByCustomerId
        ///</summary>
        [TestMethod()]
        public void FindByCustomerIdTest()
        {
            long Id = 0; // TODO: Initialize to an appropriate value
            CustomerModel expected = null; // TODO: Initialize to an appropriate value
            CustomerModel actual;
            actual = CustomerBiz.FindByCustomerId(Id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Fromtbl_Customer
        ///</summary>
        [TestMethod()]
        public void Fromtbl_CustomerTest()
        {
            tbl_Customer m_tbl_Customer = null; // TODO: Initialize to an appropriate value
            CustomerModel expected = null; // TODO: Initialize to an appropriate value
            CustomerModel actual;
            actual = CustomerBiz.Fromtbl_Customer(m_tbl_Customer);
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
            CustomerModel expected = null; // TODO: Initialize to an appropriate value
            CustomerModel actual;
            actual = CustomerBiz.Get(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetItem
        ///</summary>
        [TestMethod()]
        public void GetItemTest()
        {
            CustomerBiz target = new CustomerBiz(); // TODO: Initialize to an appropriate value
            long id = 0; // TODO: Initialize to an appropriate value
            CustomerModel expected = null; // TODO: Initialize to an appropriate value
            CustomerModel actual;
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
            CustomerModel expected = null; // TODO: Initialize to an appropriate value
            CustomerModel actual;
            actual = CustomerBiz.New();
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
            CustomerModel param = null; // TODO: Initialize to an appropriate value
            CustomerModel expected = null; // TODO: Initialize to an appropriate value
            CustomerModel actual;
            actual = CustomerBiz_Accessor.ObjectSave(param);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Save
        ///</summary>
        [TestMethod()]
        public void SaveTest()
        {
            CustomerModel param = null; // TODO: Initialize to an appropriate value
            CustomerModel expected = null; // TODO: Initialize to an appropriate value
            CustomerModel actual;
            actual = CustomerBiz.Save(param);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SaveItem
        ///</summary>
        [TestMethod()]
        public void SaveItemTest()
        {
            CustomerBiz target = new CustomerBiz(); // TODO: Initialize to an appropriate value
            CustomerModel dataItem = null; // TODO: Initialize to an appropriate value
            CustomerModel expected = null; // TODO: Initialize to an appropriate value
            CustomerModel actual;
            actual = target.SaveItem(dataItem);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Totbl_Customer
        ///</summary>
        [TestMethod()]
        public void Totbl_CustomerTest()
        {
            CustomerModel param = null; // TODO: Initialize to an appropriate value
            tbl_Customer expected = null; // TODO: Initialize to an appropriate value
            tbl_Customer actual;
            actual = CustomerBiz.Totbl_Customer(param);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

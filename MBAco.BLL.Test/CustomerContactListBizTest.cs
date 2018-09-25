using MBAco.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MBAco.BusinessModel;
using System.Collections.Generic;

namespace MBAco.BLL.Test
{
    
    
    /// <summary>
    ///This is a test class for CustomerContactListBizTest and is intended
    ///to contain all CustomerContactListBizTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CustomerContactListBizTest
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
        ///A test for CustomerContactListBiz Constructor
        ///</summary>
        [TestMethod()]
        public void CustomerContactListBizConstructorTest()
        {
            CustomerContactListBiz target = new CustomerContactListBiz();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        [TestMethod()]
        public void DeleteTest()
        {
            long id = 0; // TODO: Initialize to an appropriate value
            CustomerContactListBiz.Delete(id);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteCustomerContactModel
        ///</summary>
        [TestMethod()]
        public void DeleteCustomerContactModelTest()
        {
            int customerContactID = 0; // TODO: Initialize to an appropriate value
            CustomerContactListBiz.DeleteCustomerContactModel(customerContactID);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteCustomerContactsByCustomer
        ///</summary>
        [TestMethod()]
        public void DeleteCustomerContactsByCustomerTest()
        {
            int customerID = 0; // TODO: Initialize to an appropriate value
            CustomerContactListBiz.DeleteCustomerContactsByCustomer(customerID);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        public void DisposeTest()
        {
            CustomerContactListBiz target = new CustomerContactListBiz(); // TODO: Initialize to an appropriate value
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
            actual = CustomerContactListBiz.FindByCustomerContactId(Id);
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
            actual = CustomerContactListBiz.Get(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAll
        ///</summary>
        [TestMethod()]
        public void GetAllTest()
        {
            CustomerContactListBiz target = new CustomerContactListBiz(); // TODO: Initialize to an appropriate value
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<CustomerContactModel> expected = null; // TODO: Initialize to an appropriate value
            List<CustomerContactModel> actual;
            actual = target.GetAll(maximumRows, startRowIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAll
        ///</summary>
        [TestMethod()]
        public void GetAllTest1()
        {
            CustomerContactListBiz target = new CustomerContactListBiz(); // TODO: Initialize to an appropriate value
            string sortExpression = string.Empty; // TODO: Initialize to an appropriate value
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<CustomerContactModel> expected = null; // TODO: Initialize to an appropriate value
            List<CustomerContactModel> actual;
            actual = target.GetAll(sortExpression, maximumRows, startRowIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAll
        ///</summary>
        [TestMethod()]
        public void GetAllTest2()
        {
            CustomerContactListBiz target = new CustomerContactListBiz(); // TODO: Initialize to an appropriate value
            string sortExpression = string.Empty; // TODO: Initialize to an appropriate value
            List<CustomerContactModel> expected = null; // TODO: Initialize to an appropriate value
            List<CustomerContactModel> actual;
            actual = target.GetAll(sortExpression);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAll
        ///</summary>
        [TestMethod()]
        public void GetAllTest3()
        {
            CustomerContactListBiz target = new CustomerContactListBiz(); // TODO: Initialize to an appropriate value
            List<CustomerContactModel> expected = null; // TODO: Initialize to an appropriate value
            List<CustomerContactModel> actual;
            actual = target.GetAll();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAllWithSearch
        ///</summary>
        [TestMethod()]
        public void GetAllWithSearchTest()
        {
            CustomerContactListBiz target = new CustomerContactListBiz(); // TODO: Initialize to an appropriate value
            string searchString = string.Empty; // TODO: Initialize to an appropriate value
            bool searchPartial = false; // TODO: Initialize to an appropriate value
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<CustomerContactModel> expected = null; // TODO: Initialize to an appropriate value
            List<CustomerContactModel> actual;
            actual = target.GetAllWithSearch(searchString, searchPartial, maximumRows, startRowIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetCustomerContactModel
        ///</summary>
        [TestMethod()]
        public void GetCustomerContactModelTest()
        {
            int customerContactID = 0; // TODO: Initialize to an appropriate value
            CustomerContactModel expected = null; // TODO: Initialize to an appropriate value
            CustomerContactModel actual;
            actual = CustomerContactListBiz.GetCustomerContactModel(customerContactID);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetCustomerContactsByCustomer
        ///</summary>
        [TestMethod()]
        public void GetCustomerContactsByCustomerTest()
        {
            CustomerContactListBiz target = new CustomerContactListBiz(); // TODO: Initialize to an appropriate value
            CustomerModel customer = null; // TODO: Initialize to an appropriate value
            List<CustomerContactModel> expected = null; // TODO: Initialize to an appropriate value
            List<CustomerContactModel> actual;
            //actual = target.GetCustomerContactsByCustomer(customer);
            //Assert.AreEqual(expected, actual);
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
            actual = CustomerContactListBiz.New();
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
            actual = CustomerContactListBiz.Save(param);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Count
        ///</summary>
        [TestMethod()]
        public void CountTest()
        {
            CustomerContactListBiz target = new CustomerContactListBiz(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Count;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

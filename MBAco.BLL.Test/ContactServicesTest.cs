﻿using MBAco.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MBAco.BusinessModel;
using System.Collections.Generic;

namespace MBAco.BLL.Test
{
    
    
    /// <summary>
    ///This is a test class for ContactServicesTest and is intended
    ///to contain all ContactServicesTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ContactServicesTest
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
        ///A test for DeleteObject
        ///</summary>
        [TestMethod()]
        public void DeleteObjectTest()
        {
            long objectID = 0; // TODO: Initialize to an appropriate value
            ContactServices.DeleteObject(objectID);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Get
        ///</summary>
        [TestMethod()]
        public void GetTest()
        {
            long objectID = 0; // TODO: Initialize to an appropriate value
            ContactModel expected = null; // TODO: Initialize to an appropriate value
            ContactModel actual;
            actual = ContactServices.Get(objectID);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetList
        ///</summary>
        [TestMethod()]
        public void GetListTest()
        {
            List<ContactModel> expected = null; // TODO: Initialize to an appropriate value
            List<ContactModel> actual;
            actual = ContactServices.GetList();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetList
        ///</summary>
        [TestMethod()]
        public void GetListTest1()
        {
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            string sortExpression = string.Empty; // TODO: Initialize to an appropriate value
            List<ContactModel> expected = null; // TODO: Initialize to an appropriate value
            List<ContactModel> actual;
            actual = ContactServices.GetList(maximumRows, startRowIndex, sortExpression);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetList
        ///</summary>
        [TestMethod()]
        public void GetListTest2()
        {
            string SortExpression = string.Empty; // TODO: Initialize to an appropriate value
            List<ContactModel> expected = null; // TODO: Initialize to an appropriate value
            List<ContactModel> actual;
            actual = ContactServices.GetList(SortExpression);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetList
        ///</summary>
        [TestMethod()]
        public void GetListTest3()
        {
            string searchString = string.Empty; // TODO: Initialize to an appropriate value
            bool searchPartial = false; // TODO: Initialize to an appropriate value
            List<ContactModel> expected = null; // TODO: Initialize to an appropriate value
            List<ContactModel> actual;
            actual = ContactServices.GetList(searchString, searchPartial);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetList
        ///</summary>
        [TestMethod()]
        public void GetListTest4()
        {
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<ContactModel> expected = null; // TODO: Initialize to an appropriate value
            List<ContactModel> actual;
            actual = ContactServices.GetList(maximumRows, startRowIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetList
        ///</summary>
        [TestMethod()]
        public void GetListTest5()
        {
            string searchString = string.Empty; // TODO: Initialize to an appropriate value
            bool searchPartial = false; // TODO: Initialize to an appropriate value
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<ContactModel> expected = null; // TODO: Initialize to an appropriate value
            List<ContactModel> actual;
            actual = ContactServices.GetList(searchString, searchPartial, maximumRows, startRowIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetTotalCount
        ///</summary>
        [TestMethod()]
        public void GetTotalCountTest()
        {
            long expected = 0; // TODO: Initialize to an appropriate value
            long actual;
            actual = ContactServices.GetTotalCount();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for InsertObject
        ///</summary>
        [TestMethod()]
        public void InsertObjectTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string family = string.Empty; // TODO: Initialize to an appropriate value
            string email = string.Empty; // TODO: Initialize to an appropriate value
            string phoneNumber = string.Empty; // TODO: Initialize to an appropriate value
            int customerID = 0; // TODO: Initialize to an appropriate value
            string post = string.Empty; // TODO: Initialize to an appropriate value
            string comment = string.Empty; // TODO: Initialize to an appropriate value
            ContactModel expected = null; // TODO: Initialize to an appropriate value
            ContactModel actual;
            actual = ContactServices.InsertObject(name, family, email, phoneNumber, customerID, post, comment);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UpdateObject
        ///</summary>
        [TestMethod()]
        public void UpdateObjectTest()
        {
            int contactID = 0; // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string family = string.Empty; // TODO: Initialize to an appropriate value
            string email = string.Empty; // TODO: Initialize to an appropriate value
            string phoneNumber = string.Empty; // TODO: Initialize to an appropriate value
            int customerID = 0; // TODO: Initialize to an appropriate value
            string post = string.Empty; // TODO: Initialize to an appropriate value
            string comment = string.Empty; // TODO: Initialize to an appropriate value
            ContactModel expected = null; // TODO: Initialize to an appropriate value
            ContactModel actual;
            actual = ContactServices.UpdateObject(contactID, name, family, email, phoneNumber, customerID, post, comment);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

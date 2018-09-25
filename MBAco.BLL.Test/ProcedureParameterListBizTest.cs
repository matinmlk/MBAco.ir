using MBAco.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MBAco.BusinessModel;
using System.Collections.Generic;

namespace MBAco.BLL.Test
{
    
    
    /// <summary>
    ///This is a test class for ProcedureParameterListBizTest and is intended
    ///to contain all ProcedureParameterListBizTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProcedureParameterListBizTest
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
        ///A test for ProcedureParameterListBiz Constructor
        ///</summary>
        [TestMethod()]
        public void ProcedureParameterListBizConstructorTest()
        {
            ProcedureParameterListBiz target = new ProcedureParameterListBiz();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        [TestMethod()]
        public void DeleteTest()
        {
            long id = 0; // TODO: Initialize to an appropriate value
            ProcedureParameterListBiz.Delete(id);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteProcedureParameterModel
        ///</summary>
        [TestMethod()]
        public void DeleteProcedureParameterModelTest()
        {
            int procedureParameterID = 0; // TODO: Initialize to an appropriate value
            ProcedureParameterListBiz.DeleteProcedureParameterModel(procedureParameterID);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteProcedureParametersByAnalayseParameter
        ///</summary>
        [TestMethod()]
        public void DeleteProcedureParametersByAnalayseParameterTest()
        {
            int analayseParameterID = 0; // TODO: Initialize to an appropriate value
            ProcedureParameterListBiz.DeleteProcedureParametersByAnalayseParameter(analayseParameterID);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteProcedureParametersByCustomer
        ///</summary>
        [TestMethod()]
        public void DeleteProcedureParametersByCustomerTest()
        {
            int customerID = 0; // TODO: Initialize to an appropriate value
            ProcedureParameterListBiz.DeleteProcedureParametersByCustomer(customerID);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteProcedureParametersByDangerMaxMessage
        ///</summary>
        [TestMethod()]
        public void DeleteProcedureParametersByDangerMaxMessageTest()
        {
            int notificationMessageID = 0; // TODO: Initialize to an appropriate value
            ProcedureParameterListBiz.DeleteProcedureParametersByDangerMaxMessage(notificationMessageID);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteProcedureParametersByDangerMinMessage
        ///</summary>
        [TestMethod()]
        public void DeleteProcedureParametersByDangerMinMessageTest()
        {
            int notificationMessageID = 0; // TODO: Initialize to an appropriate value
            ProcedureParameterListBiz.DeleteProcedureParametersByDangerMinMessage(notificationMessageID);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteProcedureParametersByPossibleMaxMessage
        ///</summary>
        [TestMethod()]
        public void DeleteProcedureParametersByPossibleMaxMessageTest()
        {
            int notificationMessageID = 0; // TODO: Initialize to an appropriate value
            ProcedureParameterListBiz.DeleteProcedureParametersByPossibleMaxMessage(notificationMessageID);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteProcedureParametersByPossibleMinMessage
        ///</summary>
        [TestMethod()]
        public void DeleteProcedureParametersByPossibleMinMessageTest()
        {
            int notificationMessageID = 0; // TODO: Initialize to an appropriate value
            ProcedureParameterListBiz.DeleteProcedureParametersByPossibleMinMessage(notificationMessageID);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteProcedureParametersByWarningMaxMessage
        ///</summary>
        [TestMethod()]
        public void DeleteProcedureParametersByWarningMaxMessageTest()
        {
            int notificationMessageID = 0; // TODO: Initialize to an appropriate value
            ProcedureParameterListBiz.DeleteProcedureParametersByWarningMaxMessage(notificationMessageID);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteProcedureParametersByWarningMinMessage
        ///</summary>
        [TestMethod()]
        public void DeleteProcedureParametersByWarningMinMessageTest()
        {
            int notificationMessageID = 0; // TODO: Initialize to an appropriate value
            ProcedureParameterListBiz.DeleteProcedureParametersByWarningMinMessage(notificationMessageID);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        public void DisposeTest()
        {
            ProcedureParameterListBiz target = new ProcedureParameterListBiz(); // TODO: Initialize to an appropriate value
            target.Dispose();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for FindByProcedureParameterId
        ///</summary>
        [TestMethod()]
        public void FindByProcedureParameterIdTest()
        {
            long Id = 0; // TODO: Initialize to an appropriate value
            ProcedureParameterModel expected = null; // TODO: Initialize to an appropriate value
            ProcedureParameterModel actual;
            actual = ProcedureParameterListBiz.FindByProcedureParameterId(Id);
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
            ProcedureParameterModel expected = null; // TODO: Initialize to an appropriate value
            ProcedureParameterModel actual;
            actual = ProcedureParameterListBiz.Get(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAll
        ///</summary>
        [TestMethod()]
        public void GetAllTest()
        {
            ProcedureParameterListBiz target = new ProcedureParameterListBiz(); // TODO: Initialize to an appropriate value
            string sortExpression = string.Empty; // TODO: Initialize to an appropriate value
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<ProcedureParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<ProcedureParameterModel> actual;
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
            ProcedureParameterListBiz target = new ProcedureParameterListBiz(); // TODO: Initialize to an appropriate value
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<ProcedureParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<ProcedureParameterModel> actual;
            actual = target.GetAll(maximumRows, startRowIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAll
        ///</summary>
        [TestMethod()]
        public void GetAllTest2()
        {
            ProcedureParameterListBiz target = new ProcedureParameterListBiz(); // TODO: Initialize to an appropriate value
            List<ProcedureParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<ProcedureParameterModel> actual;
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
            ProcedureParameterListBiz target = new ProcedureParameterListBiz(); // TODO: Initialize to an appropriate value
            string sortExpression = string.Empty; // TODO: Initialize to an appropriate value
            List<ProcedureParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<ProcedureParameterModel> actual;
            actual = target.GetAll(sortExpression);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAllWithSearch
        ///</summary>
        [TestMethod()]
        public void GetAllWithSearchTest()
        {
            ProcedureParameterListBiz target = new ProcedureParameterListBiz(); // TODO: Initialize to an appropriate value
            string searchString = string.Empty; // TODO: Initialize to an appropriate value
            bool searchPartial = false; // TODO: Initialize to an appropriate value
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<ProcedureParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<ProcedureParameterModel> actual;
            actual = target.GetAllWithSearch(searchString, searchPartial, maximumRows, startRowIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetProcedureParameterModel
        ///</summary>
        [TestMethod()]
        public void GetProcedureParameterModelTest()
        {
            int procedureParameterID = 0; // TODO: Initialize to an appropriate value
            ProcedureParameterModel expected = null; // TODO: Initialize to an appropriate value
            ProcedureParameterModel actual;
            actual = ProcedureParameterListBiz.GetProcedureParameterModel(procedureParameterID);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetProcedureParametersByAnalayseParameter
        ///</summary>
        [TestMethod()]
        public void GetProcedureParametersByAnalayseParameterTest()
        {
            ProcedureParameterListBiz target = new ProcedureParameterListBiz(); // TODO: Initialize to an appropriate value
            AnalayseParameterModel analayseParameter = null; // TODO: Initialize to an appropriate value
            List<ProcedureParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<ProcedureParameterModel> actual;
            actual = target.GetProcedureParametersByAnalayseParameter(analayseParameter);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetProcedureParametersByCustomer
        ///</summary>
        [TestMethod()]
        public void GetProcedureParametersByCustomerTest()
        {
            ProcedureParameterListBiz target = new ProcedureParameterListBiz(); // TODO: Initialize to an appropriate value
            CustomerModel customer = null; // TODO: Initialize to an appropriate value
            List<ProcedureParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<ProcedureParameterModel> actual;
            //actual = target.GetProcedureParametersByCustomer(customer);
            //Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetProcedureParametersByDangerMaxMessage
        ///</summary>
        [TestMethod()]
        public void GetProcedureParametersByDangerMaxMessageTest()
        {
            ProcedureParameterListBiz target = new ProcedureParameterListBiz(); // TODO: Initialize to an appropriate value
            NotificationMessageModel dangerMaxMessage = null; // TODO: Initialize to an appropriate value
            List<ProcedureParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<ProcedureParameterModel> actual;
            actual = target.GetProcedureParametersByDangerMaxMessage(dangerMaxMessage);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetProcedureParametersByDangerMinMessage
        ///</summary>
        [TestMethod()]
        public void GetProcedureParametersByDangerMinMessageTest()
        {
            ProcedureParameterListBiz target = new ProcedureParameterListBiz(); // TODO: Initialize to an appropriate value
            NotificationMessageModel dangerMinMessage = null; // TODO: Initialize to an appropriate value
            List<ProcedureParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<ProcedureParameterModel> actual;
            actual = target.GetProcedureParametersByDangerMinMessage(dangerMinMessage);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetProcedureParametersByPossibleMaxMessage
        ///</summary>
        [TestMethod()]
        public void GetProcedureParametersByPossibleMaxMessageTest()
        {
            ProcedureParameterListBiz target = new ProcedureParameterListBiz(); // TODO: Initialize to an appropriate value
            NotificationMessageModel possibleMaxMessage = null; // TODO: Initialize to an appropriate value
            List<ProcedureParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<ProcedureParameterModel> actual;
            actual = target.GetProcedureParametersByPossibleMaxMessage(possibleMaxMessage);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetProcedureParametersByPossibleMinMessage
        ///</summary>
        [TestMethod()]
        public void GetProcedureParametersByPossibleMinMessageTest()
        {
            ProcedureParameterListBiz target = new ProcedureParameterListBiz(); // TODO: Initialize to an appropriate value
            NotificationMessageModel possibleMinMessage = null; // TODO: Initialize to an appropriate value
            List<ProcedureParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<ProcedureParameterModel> actual;
            actual = target.GetProcedureParametersByPossibleMinMessage(possibleMinMessage);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetProcedureParametersByWarningMaxMessage
        ///</summary>
        [TestMethod()]
        public void GetProcedureParametersByWarningMaxMessageTest()
        {
            ProcedureParameterListBiz target = new ProcedureParameterListBiz(); // TODO: Initialize to an appropriate value
            NotificationMessageModel warningMaxMessage = null; // TODO: Initialize to an appropriate value
            List<ProcedureParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<ProcedureParameterModel> actual;
            actual = target.GetProcedureParametersByWarningMaxMessage(warningMaxMessage);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetProcedureParametersByWarningMinMessage
        ///</summary>
        [TestMethod()]
        public void GetProcedureParametersByWarningMinMessageTest()
        {
            ProcedureParameterListBiz target = new ProcedureParameterListBiz(); // TODO: Initialize to an appropriate value
            NotificationMessageModel warningMinMessage = null; // TODO: Initialize to an appropriate value
            List<ProcedureParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<ProcedureParameterModel> actual;
            actual = target.GetProcedureParametersByWarningMinMessage(warningMinMessage);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for New
        ///</summary>
        [TestMethod()]
        public void NewTest()
        {
            ProcedureParameterModel expected = null; // TODO: Initialize to an appropriate value
            ProcedureParameterModel actual;
            actual = ProcedureParameterListBiz.New();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Save
        ///</summary>
        [TestMethod()]
        public void SaveTest()
        {
            ProcedureParameterModel param = null; // TODO: Initialize to an appropriate value
            ProcedureParameterModel expected = null; // TODO: Initialize to an appropriate value
            ProcedureParameterModel actual;
            actual = ProcedureParameterListBiz.Save(param);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Count
        ///</summary>
        [TestMethod()]
        public void CountTest()
        {
            ProcedureParameterListBiz target = new ProcedureParameterListBiz(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Count;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

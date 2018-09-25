using MBAco.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MBAco.BusinessModel;
using System.Collections.Generic;

namespace MBAco.BLL.Test
{
    
    
    /// <summary>
    ///This is a test class for ProcedureParameterServicesTest and is intended
    ///to contain all ProcedureParameterServicesTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProcedureParameterServicesTest
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
            ProcedureParameterServices.DeleteObject(objectID);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Get
        ///</summary>
        [TestMethod()]
        public void GetTest()
        {
            long objectID = 0; // TODO: Initialize to an appropriate value
            ProcedureParameterModel expected = null; // TODO: Initialize to an appropriate value
            ProcedureParameterModel actual;
            actual = ProcedureParameterServices.Get(objectID);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetList
        ///</summary>
        [TestMethod()]
        public void GetListTest()
        {
            List<ProcedureParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<ProcedureParameterModel> actual;
            actual = ProcedureParameterServices.GetList();
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
            List<ProcedureParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<ProcedureParameterModel> actual;
            actual = ProcedureParameterServices.GetList(maximumRows, startRowIndex, sortExpression);
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
            List<ProcedureParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<ProcedureParameterModel> actual;
            actual = ProcedureParameterServices.GetList(SortExpression);
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
            List<ProcedureParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<ProcedureParameterModel> actual;
            actual = ProcedureParameterServices.GetList(searchString, searchPartial);
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
            List<ProcedureParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<ProcedureParameterModel> actual;
            actual = ProcedureParameterServices.GetList(maximumRows, startRowIndex);
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
            List<ProcedureParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<ProcedureParameterModel> actual;
            actual = ProcedureParameterServices.GetList(searchString, searchPartial, maximumRows, startRowIndex);
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
            actual = ProcedureParameterServices.GetTotalCount();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for InsertObject
        ///</summary>
        [TestMethod()]
        public void InsertObjectTest()
        {
            int customerID = 0; // TODO: Initialize to an appropriate value
            int analayseParameterID = 0; // TODO: Initialize to an appropriate value
            Nullable<double> dangerMaxLimit = new Nullable<double>(); // TODO: Initialize to an appropriate value
            Nullable<double> dangerMinLimit = new Nullable<double>(); // TODO: Initialize to an appropriate value
            Nullable<double> warningMaxLimit = new Nullable<double>(); // TODO: Initialize to an appropriate value
            Nullable<double> warningMinLimit = new Nullable<double>(); // TODO: Initialize to an appropriate value
            Nullable<double> possibleMaxLimit = new Nullable<double>(); // TODO: Initialize to an appropriate value
            Nullable<double> possibleMinLimit = new Nullable<double>(); // TODO: Initialize to an appropriate value
            Nullable<int> dangerMaxMessageId = new Nullable<int>(); // TODO: Initialize to an appropriate value
            Nullable<int> dangerMinMessageId = new Nullable<int>(); // TODO: Initialize to an appropriate value
            Nullable<int> warningMaxMessageId = new Nullable<int>(); // TODO: Initialize to an appropriate value
            Nullable<int> warningMinMessageId = new Nullable<int>(); // TODO: Initialize to an appropriate value
            Nullable<int> possibleMaxMessageId = new Nullable<int>(); // TODO: Initialize to an appropriate value
            Nullable<int> possibleMinMessageId = new Nullable<int>(); // TODO: Initialize to an appropriate value
            string comment = string.Empty; // TODO: Initialize to an appropriate value
            ProcedureParameterModel expected = null; // TODO: Initialize to an appropriate value
            ProcedureParameterModel actual;
            actual = ProcedureParameterServices.InsertObject(customerID, analayseParameterID, dangerMaxLimit, dangerMinLimit, warningMaxLimit, warningMinLimit, possibleMaxLimit, possibleMinLimit, dangerMaxMessageId, dangerMinMessageId, warningMaxMessageId, warningMinMessageId, possibleMaxMessageId, possibleMinMessageId, comment);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UpdateObject
        ///</summary>
        [TestMethod()]
        public void UpdateObjectTest()
        {
            int procedureParameterID = 0; // TODO: Initialize to an appropriate value
            int customerID = 0; // TODO: Initialize to an appropriate value
            int analayseParameterID = 0; // TODO: Initialize to an appropriate value
            Nullable<double> dangerMaxLimit = new Nullable<double>(); // TODO: Initialize to an appropriate value
            Nullable<double> dangerMinLimit = new Nullable<double>(); // TODO: Initialize to an appropriate value
            Nullable<double> warningMaxLimit = new Nullable<double>(); // TODO: Initialize to an appropriate value
            Nullable<double> warningMinLimit = new Nullable<double>(); // TODO: Initialize to an appropriate value
            Nullable<double> possibleMaxLimit = new Nullable<double>(); // TODO: Initialize to an appropriate value
            Nullable<double> possibleMinLimit = new Nullable<double>(); // TODO: Initialize to an appropriate value
            Nullable<int> dangerMaxMessageId = new Nullable<int>(); // TODO: Initialize to an appropriate value
            Nullable<int> dangerMinMessageId = new Nullable<int>(); // TODO: Initialize to an appropriate value
            Nullable<int> warningMaxMessageId = new Nullable<int>(); // TODO: Initialize to an appropriate value
            Nullable<int> warningMinMessageId = new Nullable<int>(); // TODO: Initialize to an appropriate value
            Nullable<int> possibleMaxMessageId = new Nullable<int>(); // TODO: Initialize to an appropriate value
            Nullable<int> possibleMinMessageId = new Nullable<int>(); // TODO: Initialize to an appropriate value
            string comment = string.Empty; // TODO: Initialize to an appropriate value
            ProcedureParameterModel expected = null; // TODO: Initialize to an appropriate value
            ProcedureParameterModel actual;
            actual = ProcedureParameterServices.UpdateObject(procedureParameterID, customerID, analayseParameterID, dangerMaxLimit, dangerMinLimit, warningMaxLimit, warningMinLimit, possibleMaxLimit, possibleMinLimit, dangerMaxMessageId, dangerMinMessageId, warningMaxMessageId, warningMinMessageId, possibleMaxMessageId, possibleMinMessageId, comment);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

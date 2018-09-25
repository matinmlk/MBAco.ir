using MBAco.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MBAco.BusinessModel;
using System.Collections.Generic;

namespace MBAco.BLL.Test
{
    
    
    /// <summary>
    ///This is a test class for DailyAnalyseReportListBizTest and is intended
    ///to contain all DailyAnalyseReportListBizTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DailyAnalyseReportListBizTest
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
        ///A test for DailyAnalyseReportListBiz Constructor
        ///</summary>
        [TestMethod()]
        public void DailyAnalyseReportListBizConstructorTest()
        {
            DailyAnalyseReportListBiz target = new DailyAnalyseReportListBiz();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        [TestMethod()]
        public void DeleteTest()
        {
            long id = 0; // TODO: Initialize to an appropriate value
            DailyAnalyseReportListBiz.Delete(id);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteDailyAnalyseReportModel
        ///</summary>
        [TestMethod()]
        public void DeleteDailyAnalyseReportModelTest()
        {
            int dailyAnalyseReportID = 0; // TODO: Initialize to an appropriate value
            DailyAnalyseReportListBiz.DeleteDailyAnalyseReportModel(dailyAnalyseReportID);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteDailyAnalyseReportsByCustomer
        ///</summary>
        [TestMethod()]
        public void DeleteDailyAnalyseReportsByCustomerTest()
        {
            int customerID = 0; // TODO: Initialize to an appropriate value
            DailyAnalyseReportListBiz.DeleteDailyAnalyseReportsByCustomer(customerID);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteDailyAnalyseReportsByProcedureParameter
        ///</summary>
        [TestMethod()]
        public void DeleteDailyAnalyseReportsByProcedureParameterTest()
        {
            int procedureParameterID = 0; // TODO: Initialize to an appropriate value
            DailyAnalyseReportListBiz.DeleteDailyAnalyseReportsByProcedureParameter(procedureParameterID);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        public void DisposeTest()
        {
            DailyAnalyseReportListBiz target = new DailyAnalyseReportListBiz(); // TODO: Initialize to an appropriate value
            target.Dispose();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for FindByDailyAnalyseReportId
        ///</summary>
        [TestMethod()]
        public void FindByDailyAnalyseReportIdTest()
        {
            long Id = 0; // TODO: Initialize to an appropriate value
            DailyAnalyseReportModel expected = null; // TODO: Initialize to an appropriate value
            DailyAnalyseReportModel actual;
            actual = DailyAnalyseReportListBiz.FindByDailyAnalyseReportId(Id);
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
            DailyAnalyseReportModel expected = null; // TODO: Initialize to an appropriate value
            DailyAnalyseReportModel actual;
            actual = DailyAnalyseReportListBiz.Get(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAll
        ///</summary>
        [TestMethod()]
        public void GetAllTest()
        {
            DailyAnalyseReportListBiz target = new DailyAnalyseReportListBiz(); // TODO: Initialize to an appropriate value
            string sortExpression = string.Empty; // TODO: Initialize to an appropriate value
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<DailyAnalyseReportModel> expected = null; // TODO: Initialize to an appropriate value
            List<DailyAnalyseReportModel> actual;
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
            DailyAnalyseReportListBiz target = new DailyAnalyseReportListBiz(); // TODO: Initialize to an appropriate value
            string sortExpression = string.Empty; // TODO: Initialize to an appropriate value
            List<DailyAnalyseReportModel> expected = null; // TODO: Initialize to an appropriate value
            List<DailyAnalyseReportModel> actual;
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
            DailyAnalyseReportListBiz target = new DailyAnalyseReportListBiz(); // TODO: Initialize to an appropriate value
            List<DailyAnalyseReportModel> expected = null; // TODO: Initialize to an appropriate value
            List<DailyAnalyseReportModel> actual;
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
            DailyAnalyseReportListBiz target = new DailyAnalyseReportListBiz(); // TODO: Initialize to an appropriate value
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<DailyAnalyseReportModel> expected = null; // TODO: Initialize to an appropriate value
            List<DailyAnalyseReportModel> actual;
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
            DailyAnalyseReportListBiz target = new DailyAnalyseReportListBiz(); // TODO: Initialize to an appropriate value
            string searchString = string.Empty; // TODO: Initialize to an appropriate value
            bool searchPartial = false; // TODO: Initialize to an appropriate value
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<DailyAnalyseReportModel> expected = null; // TODO: Initialize to an appropriate value
            List<DailyAnalyseReportModel> actual;
            actual = target.GetAllWithSearch(searchString, searchPartial, maximumRows, startRowIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetDailyAnalyseReportModel
        ///</summary>
        [TestMethod()]
        public void GetDailyAnalyseReportModelTest()
        {
            int dailyAnalyseReportID = 0; // TODO: Initialize to an appropriate value
            DailyAnalyseReportModel expected = null; // TODO: Initialize to an appropriate value
            DailyAnalyseReportModel actual;
            actual = DailyAnalyseReportListBiz.GetDailyAnalyseReportModel(dailyAnalyseReportID);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetDailyAnalyseReportsByCustomer
        ///</summary>
        [TestMethod()]
        public void GetDailyAnalyseReportsByCustomerTest()
        {
            DailyAnalyseReportListBiz target = new DailyAnalyseReportListBiz(); // TODO: Initialize to an appropriate value
            CustomerModel customer = null; // TODO: Initialize to an appropriate value
            List<DailyAnalyseReportModel> expected = null; // TODO: Initialize to an appropriate value
            List<DailyAnalyseReportModel> actual;
            actual = target.GetDailyAnalyseReportsByCustomer(customer);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetDailyAnalyseReportsByProcedureParameter
        ///</summary>
        [TestMethod()]
        public void GetDailyAnalyseReportsByProcedureParameterTest()
        {
            DailyAnalyseReportListBiz target = new DailyAnalyseReportListBiz(); // TODO: Initialize to an appropriate value
            ProcedureParameterModel procedureParameter = null; // TODO: Initialize to an appropriate value
            List<DailyAnalyseReportModel> expected = null; // TODO: Initialize to an appropriate value
            List<DailyAnalyseReportModel> actual;
            //actual = target.GetDailyAnalyseReportsByProcedureParameterID(procedureParameter);
            //Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for New
        ///</summary>
        [TestMethod()]
        public void NewTest()
        {
            DailyAnalyseReportModel expected = null; // TODO: Initialize to an appropriate value
            DailyAnalyseReportModel actual;
            actual = DailyAnalyseReportListBiz.New();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Save
        ///</summary>
        [TestMethod()]
        public void SaveTest()
        {
            DailyAnalyseReportModel param = null; // TODO: Initialize to an appropriate value
            DailyAnalyseReportModel expected = null; // TODO: Initialize to an appropriate value
            DailyAnalyseReportModel actual;
            actual = DailyAnalyseReportListBiz.Save(param);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Count
        ///</summary>
        [TestMethod()]
        public void CountTest()
        {
            DailyAnalyseReportListBiz target = new DailyAnalyseReportListBiz(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Count;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

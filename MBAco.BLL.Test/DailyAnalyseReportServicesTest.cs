using MBAco.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MBAco.BusinessModel;
using System.Collections.Generic;

namespace MBAco.BLL.Test
{
    
    
    /// <summary>
    ///This is a test class for DailyAnalyseReportServicesTest and is intended
    ///to contain all DailyAnalyseReportServicesTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DailyAnalyseReportServicesTest
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
            DailyAnalyseReportServices.DeleteObject(objectID);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Get
        ///</summary>
        [TestMethod()]
        public void GetTest()
        {
            long objectID = 0; // TODO: Initialize to an appropriate value
            DailyAnalyseReportModel expected = null; // TODO: Initialize to an appropriate value
            DailyAnalyseReportModel actual;
            actual = DailyAnalyseReportServices.Get(objectID);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetList
        ///</summary>
        [TestMethod()]
        public void GetListTest()
        {
            List<DailyAnalyseReportModel> expected = null; // TODO: Initialize to an appropriate value
            List<DailyAnalyseReportModel> actual;
            actual = DailyAnalyseReportServices.GetList();
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
            List<DailyAnalyseReportModel> expected = null; // TODO: Initialize to an appropriate value
            List<DailyAnalyseReportModel> actual;
            actual = DailyAnalyseReportServices.GetList(maximumRows, startRowIndex, sortExpression);
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
            List<DailyAnalyseReportModel> expected = null; // TODO: Initialize to an appropriate value
            List<DailyAnalyseReportModel> actual;
            actual = DailyAnalyseReportServices.GetList(SortExpression);
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
            List<DailyAnalyseReportModel> expected = null; // TODO: Initialize to an appropriate value
            List<DailyAnalyseReportModel> actual;
            actual = DailyAnalyseReportServices.GetList(searchString, searchPartial);
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
            List<DailyAnalyseReportModel> expected = null; // TODO: Initialize to an appropriate value
            List<DailyAnalyseReportModel> actual;
            actual = DailyAnalyseReportServices.GetList(maximumRows, startRowIndex);
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
            List<DailyAnalyseReportModel> expected = null; // TODO: Initialize to an appropriate value
            List<DailyAnalyseReportModel> actual;
            actual = DailyAnalyseReportServices.GetList(searchString, searchPartial, maximumRows, startRowIndex);
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
            actual = DailyAnalyseReportServices.GetTotalCount();
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
            int procedureParameterID = 0; // TODO: Initialize to an appropriate value
            DateTime date = new DateTime(); // TODO: Initialize to an appropriate value
            double value = 0F; // TODO: Initialize to an appropriate value
            bool isApproved = false; // TODO: Initialize to an appropriate value
            string comment = string.Empty; // TODO: Initialize to an appropriate value
            DailyAnalyseReportModel expected = null; // TODO: Initialize to an appropriate value
            DailyAnalyseReportModel actual;
            actual = DailyAnalyseReportServices.InsertObject(customerID, procedureParameterID, date, value, isApproved, comment);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UpdateObject
        ///</summary>
        [TestMethod()]
        public void UpdateObjectTest()
        {
            int dailyAnalyseReportID = 0; // TODO: Initialize to an appropriate value
            int customerID = 0; // TODO: Initialize to an appropriate value
            int procedureParameterID = 0; // TODO: Initialize to an appropriate value
            DateTime date = new DateTime(); // TODO: Initialize to an appropriate value
            double value = 0F; // TODO: Initialize to an appropriate value
            bool isApproved = false; // TODO: Initialize to an appropriate value
            string comment = string.Empty; // TODO: Initialize to an appropriate value
            DailyAnalyseReportModel expected = null; // TODO: Initialize to an appropriate value
            DailyAnalyseReportModel actual;
            actual = DailyAnalyseReportServices.UpdateObject(dailyAnalyseReportID, customerID, procedureParameterID, date, value, isApproved, comment);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

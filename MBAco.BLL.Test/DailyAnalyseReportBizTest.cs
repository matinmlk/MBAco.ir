using MBAco.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MBAco.BusinessModel;
using MBAco.DAL;

namespace MBAco.BLL.Test
{
    
    
    /// <summary>
    ///This is a test class for DailyAnalyseReportBizTest and is intended
    ///to contain all DailyAnalyseReportBizTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DailyAnalyseReportBizTest
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
        ///A test for DailyAnalyseReportBiz Constructor
        ///</summary>
        [TestMethod()]
        public void DailyAnalyseReportBizConstructorTest()
        {
            DailyAnalyseReportBiz target = new DailyAnalyseReportBiz();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        [TestMethod()]
        public void DeleteTest()
        {
            long id = 0; // TODO: Initialize to an appropriate value
            DailyAnalyseReportBiz.Delete(id);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteItem
        ///</summary>
        [TestMethod()]
        public void DeleteItemTest()
        {
            DailyAnalyseReportBiz target = new DailyAnalyseReportBiz(); // TODO: Initialize to an appropriate value
            DailyAnalyseReportModel dataItem = null; // TODO: Initialize to an appropriate value
            target.DeleteItem(dataItem);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteItem
        ///</summary>
        [TestMethod()]
        public void DeleteItemTest1()
        {
            DailyAnalyseReportBiz target = new DailyAnalyseReportBiz(); // TODO: Initialize to an appropriate value
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
            DailyAnalyseReportBiz target = new DailyAnalyseReportBiz(); // TODO: Initialize to an appropriate value
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
            actual = DailyAnalyseReportBiz.FindByDailyAnalyseReportId(Id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Fromtbl_DailyAnalyseReport
        ///</summary>
        [TestMethod()]
        public void Fromtbl_DailyAnalyseReportTest()
        {
            tbl_DailyAnalyseReport m_tbl_DailyAnalyseReport = null; // TODO: Initialize to an appropriate value
            DailyAnalyseReportModel expected = null; // TODO: Initialize to an appropriate value
            DailyAnalyseReportModel actual;
            actual = DailyAnalyseReportBiz.Fromtbl_DailyAnalyseReport(m_tbl_DailyAnalyseReport);
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
            actual = DailyAnalyseReportBiz.Get(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetItem
        ///</summary>
        [TestMethod()]
        public void GetItemTest()
        {
            DailyAnalyseReportBiz target = new DailyAnalyseReportBiz(); // TODO: Initialize to an appropriate value
            long id = 0; // TODO: Initialize to an appropriate value
            DailyAnalyseReportModel expected = null; // TODO: Initialize to an appropriate value
            DailyAnalyseReportModel actual;
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
            DailyAnalyseReportModel expected = null; // TODO: Initialize to an appropriate value
            DailyAnalyseReportModel actual;
            actual = DailyAnalyseReportBiz.New();
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
            DailyAnalyseReportModel param = null; // TODO: Initialize to an appropriate value
            DailyAnalyseReportModel expected = null; // TODO: Initialize to an appropriate value
            DailyAnalyseReportModel actual;
            actual = DailyAnalyseReportBiz_Accessor.ObjectSave(param);
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
            actual = DailyAnalyseReportBiz.Save(param);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SaveItem
        ///</summary>
        [TestMethod()]
        public void SaveItemTest()
        {
            DailyAnalyseReportBiz target = new DailyAnalyseReportBiz(); // TODO: Initialize to an appropriate value
            DailyAnalyseReportModel dataItem = null; // TODO: Initialize to an appropriate value
            DailyAnalyseReportModel expected = null; // TODO: Initialize to an appropriate value
            DailyAnalyseReportModel actual;
            actual = target.SaveItem(dataItem);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Totbl_DailyAnalyseReport
        ///</summary>
        [TestMethod()]
        public void Totbl_DailyAnalyseReportTest()
        {
            DailyAnalyseReportModel param = null; // TODO: Initialize to an appropriate value
            tbl_DailyAnalyseReport expected = null; // TODO: Initialize to an appropriate value
            tbl_DailyAnalyseReport actual;
            actual = DailyAnalyseReportBiz.Totbl_DailyAnalyseReport(param);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

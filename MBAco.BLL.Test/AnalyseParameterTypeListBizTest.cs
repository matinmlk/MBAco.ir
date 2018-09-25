using MBAco.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MBAco.BusinessModel;
using System.Collections.Generic;

namespace MBAco.BLL.Test
{
    
    
    /// <summary>
    ///This is a test class for AnalyseParameterTypeListBizTest and is intended
    ///to contain all AnalyseParameterTypeListBizTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AnalyseParameterTypeListBizTest
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
        ///A test for Count
        ///</summary>
        [TestMethod()]
        public void CountTest()
        {
            AnalyseParameterTypeListBiz target = new AnalyseParameterTypeListBiz(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Count;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Save
        ///</summary>
        [TestMethod()]
        public void SaveTest()
        {
            AnalyseParameterTypeModel param = null; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel expected = null; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel actual;
            actual = AnalyseParameterTypeListBiz.Save(param);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for New
        ///</summary>
        [TestMethod()]
        public void NewTest()
        {
            AnalyseParameterTypeModel expected = null; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel actual;
            actual = AnalyseParameterTypeListBiz.New();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAnalyseParameterTypeModel
        ///</summary>
        [TestMethod()]
        public void GetAnalyseParameterTypeModelTest()
        {
            int analyseParameterTypeID = 0; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel expected = null; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel actual;
            actual = AnalyseParameterTypeListBiz.GetAnalyseParameterTypeModel(analyseParameterTypeID);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAllWithSearch
        ///</summary>
        [TestMethod()]
        public void GetAllWithSearchTest()
        {
            AnalyseParameterTypeListBiz target = new AnalyseParameterTypeListBiz(); // TODO: Initialize to an appropriate value
            string searchString = string.Empty; // TODO: Initialize to an appropriate value
            bool searchPartial = false; // TODO: Initialize to an appropriate value
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<AnalyseParameterTypeModel> expected = null; // TODO: Initialize to an appropriate value
            List<AnalyseParameterTypeModel> actual;
            actual = target.GetAllWithSearch(searchString, searchPartial, maximumRows, startRowIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAll
        ///</summary>
        [TestMethod()]
        public void GetAllTest()
        {
            AnalyseParameterTypeListBiz target = new AnalyseParameterTypeListBiz(); // TODO: Initialize to an appropriate value
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<AnalyseParameterTypeModel> expected = null; // TODO: Initialize to an appropriate value
            List<AnalyseParameterTypeModel> actual;
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
            AnalyseParameterTypeListBiz target = new AnalyseParameterTypeListBiz(); // TODO: Initialize to an appropriate value
            List<AnalyseParameterTypeModel> expected = null; // TODO: Initialize to an appropriate value
            List<AnalyseParameterTypeModel> actual;
            actual = target.GetAll();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAll
        ///</summary>
        [TestMethod()]
        public void GetAllTest2()
        {
            AnalyseParameterTypeListBiz target = new AnalyseParameterTypeListBiz(); // TODO: Initialize to an appropriate value
            string sortExpression = string.Empty; // TODO: Initialize to an appropriate value
            List<AnalyseParameterTypeModel> expected = null; // TODO: Initialize to an appropriate value
            List<AnalyseParameterTypeModel> actual;
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
            AnalyseParameterTypeListBiz target = new AnalyseParameterTypeListBiz(); // TODO: Initialize to an appropriate value
            string sortExpression = string.Empty; // TODO: Initialize to an appropriate value
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<AnalyseParameterTypeModel> expected = null; // TODO: Initialize to an appropriate value
            List<AnalyseParameterTypeModel> actual;
            actual = target.GetAll(sortExpression, maximumRows, startRowIndex);
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
            AnalyseParameterTypeModel expected = null; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel actual;
            actual = AnalyseParameterTypeListBiz.Get(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FindByAnalyseParameterTypeId
        ///</summary>
        [TestMethod()]
        public void FindByAnalyseParameterTypeIdTest()
        {
            long Id = 0; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel expected = null; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel actual;
            actual = AnalyseParameterTypeListBiz.FindByAnalyseParameterTypeId(Id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        public void DisposeTest()
        {
            AnalyseParameterTypeListBiz target = new AnalyseParameterTypeListBiz(); // TODO: Initialize to an appropriate value
            target.Dispose();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteAnalyseParameterTypeModel
        ///</summary>
        [TestMethod()]
        public void DeleteAnalyseParameterTypeModelTest()
        {
            int analyseParameterTypeID = 0; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeListBiz.DeleteAnalyseParameterTypeModel(analyseParameterTypeID);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        [TestMethod()]
        public void DeleteTest()
        {
            long id = 0; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeListBiz.Delete(id);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AnalyseParameterTypeListBiz Constructor
        ///</summary>
        [TestMethod()]
        public void AnalyseParameterTypeListBizConstructorTest()
        {
            AnalyseParameterTypeListBiz target = new AnalyseParameterTypeListBiz();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for AnalyseParameterTypeListBiz Constructor
        ///</summary>
        [TestMethod()]
        public void AnalyseParameterTypeListBizConstructorTest1()
        {
            AnalyseParameterTypeListBiz target = new AnalyseParameterTypeListBiz();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        [TestMethod()]
        public void DeleteTest1()
        {
            long id = 0; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeListBiz.Delete(id);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteAnalyseParameterTypeModel
        ///</summary>
        [TestMethod()]
        public void DeleteAnalyseParameterTypeModelTest1()
        {
            int analyseParameterTypeID = 0; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeListBiz.DeleteAnalyseParameterTypeModel(analyseParameterTypeID);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        public void DisposeTest1()
        {
            AnalyseParameterTypeListBiz target = new AnalyseParameterTypeListBiz(); // TODO: Initialize to an appropriate value
            target.Dispose();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for FindByAnalyseParameterTypeId
        ///</summary>
        [TestMethod()]
        public void FindByAnalyseParameterTypeIdTest1()
        {
            long Id = 0; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel expected = null; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel actual;
            actual = AnalyseParameterTypeListBiz.FindByAnalyseParameterTypeId(Id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Get
        ///</summary>
        [TestMethod()]
        public void GetTest1()
        {
            long id = 0; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel expected = null; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel actual;
            actual = AnalyseParameterTypeListBiz.Get(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAll
        ///</summary>
        [TestMethod()]
        public void GetAllTest4()
        {
            AnalyseParameterTypeListBiz target = new AnalyseParameterTypeListBiz(); // TODO: Initialize to an appropriate value
            string sortExpression = string.Empty; // TODO: Initialize to an appropriate value
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<AnalyseParameterTypeModel> expected = null; // TODO: Initialize to an appropriate value
            List<AnalyseParameterTypeModel> actual;
            actual = target.GetAll(sortExpression, maximumRows, startRowIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAll
        ///</summary>
        [TestMethod()]
        public void GetAllTest5()
        {
            AnalyseParameterTypeListBiz target = new AnalyseParameterTypeListBiz(); // TODO: Initialize to an appropriate value
            string sortExpression = string.Empty; // TODO: Initialize to an appropriate value
            List<AnalyseParameterTypeModel> expected = null; // TODO: Initialize to an appropriate value
            List<AnalyseParameterTypeModel> actual;
            actual = target.GetAll(sortExpression);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAll
        ///</summary>
        [TestMethod()]
        public void GetAllTest6()
        {
            AnalyseParameterTypeListBiz target = new AnalyseParameterTypeListBiz(); // TODO: Initialize to an appropriate value
            List<AnalyseParameterTypeModel> expected = null; // TODO: Initialize to an appropriate value
            List<AnalyseParameterTypeModel> actual;
            actual = target.GetAll();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAll
        ///</summary>
        [TestMethod()]
        public void GetAllTest7()
        {
            AnalyseParameterTypeListBiz target = new AnalyseParameterTypeListBiz(); // TODO: Initialize to an appropriate value
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<AnalyseParameterTypeModel> expected = null; // TODO: Initialize to an appropriate value
            List<AnalyseParameterTypeModel> actual;
            actual = target.GetAll(maximumRows, startRowIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAllWithSearch
        ///</summary>
        [TestMethod()]
        public void GetAllWithSearchTest1()
        {
            AnalyseParameterTypeListBiz target = new AnalyseParameterTypeListBiz(); // TODO: Initialize to an appropriate value
            string searchString = string.Empty; // TODO: Initialize to an appropriate value
            bool searchPartial = false; // TODO: Initialize to an appropriate value
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<AnalyseParameterTypeModel> expected = null; // TODO: Initialize to an appropriate value
            List<AnalyseParameterTypeModel> actual;
            actual = target.GetAllWithSearch(searchString, searchPartial, maximumRows, startRowIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAnalyseParameterTypeModel
        ///</summary>
        [TestMethod()]
        public void GetAnalyseParameterTypeModelTest1()
        {
            int analyseParameterTypeID = 0; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel expected = null; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel actual;
            actual = AnalyseParameterTypeListBiz.GetAnalyseParameterTypeModel(analyseParameterTypeID);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for New
        ///</summary>
        [TestMethod()]
        public void NewTest1()
        {
            AnalyseParameterTypeModel expected = null; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel actual;
            actual = AnalyseParameterTypeListBiz.New();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Save
        ///</summary>
        [TestMethod()]
        public void SaveTest1()
        {
            AnalyseParameterTypeModel param = null; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel expected = null; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel actual;
            actual = AnalyseParameterTypeListBiz.Save(param);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Count
        ///</summary>
        [TestMethod()]
        public void CountTest1()
        {
            AnalyseParameterTypeListBiz target = new AnalyseParameterTypeListBiz(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Count;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

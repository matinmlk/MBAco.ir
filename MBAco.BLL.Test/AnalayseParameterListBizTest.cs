using MBAco.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MBAco.BusinessModel;
using System.Collections.Generic;

namespace MBAco.BLL.Test
{
    
    
    /// <summary>
    ///This is a test class for AnalayseParameterListBizTest and is intended
    ///to contain all AnalayseParameterListBizTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AnalayseParameterListBizTest
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
            AnalayseParameterListBiz target = new AnalayseParameterListBiz(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Count;
        }

        /// <summary>
        ///A test for Save
        ///</summary>
        [TestMethod()]
        public void SaveTest()
        {
            AnalayseParameterModel param = new AnalayseParameterModel() { AnalyseParameterType = AnalyseParameterTypeBiz.Get(1), Name = "پارامتر تست", Comment = "تست", Symbol= "$$" }; // TODO: Initialize to an appropriate value
            AnalayseParameterModel actual;
            actual = AnalayseParameterListBiz.Save(param);
        }

        /// <summary>
        ///A test for New
        ///</summary>
        [TestMethod()]
        public void NewTest()
        {
            AnalayseParameterModel actual;
            actual = AnalayseParameterListBiz.New();
        }

        /// <summary>
        ///A test for GetAnalayseParametersByAnalyseParameterType
        ///</summary>
        [TestMethod()]
        public void GetAnalayseParametersByAnalyseParameterTypeTest()
        {
            AnalayseParameterListBiz target = new AnalayseParameterListBiz(); // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel analyseParameterType = AnalyseParameterTypeBiz.Get(2); // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> actual;
            //actual = target.GetAnalayseParametersByAnalyseParameterType(analyseParameterType);
        }

        /// <summary>
        ///A test for GetAnalayseParameterModel
        ///</summary>
        [TestMethod()]
        public void GetAnalayseParameterModelTest()
        {
            int analayseParameterID = 0; // TODO: Initialize to an appropriate value
            AnalayseParameterModel expected = null; // TODO: Initialize to an appropriate value
            AnalayseParameterModel actual;
            actual = AnalayseParameterListBiz.GetAnalayseParameterModel(analayseParameterID);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAllWithSearch
        ///</summary>
        [TestMethod()]
        public void GetAllWithSearchTest()
        {
            AnalayseParameterListBiz target = new AnalayseParameterListBiz(); // TODO: Initialize to an appropriate value
            string searchString = string.Empty; // TODO: Initialize to an appropriate value
            bool searchPartial = false; // TODO: Initialize to an appropriate value
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> actual;
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
            AnalayseParameterListBiz target = new AnalayseParameterListBiz(); // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> actual;
            actual = target.GetAll();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAll
        ///</summary>
        [TestMethod()]
        public void GetAllTest1()
        {
            AnalayseParameterListBiz target = new AnalayseParameterListBiz(); // TODO: Initialize to an appropriate value
            string sortExpression = string.Empty; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> actual;
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
            AnalayseParameterListBiz target = new AnalayseParameterListBiz(); // TODO: Initialize to an appropriate value
            string sortExpression = string.Empty; // TODO: Initialize to an appropriate value
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> actual;
            actual = target.GetAll(sortExpression, maximumRows, startRowIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAll
        ///</summary>
        [TestMethod()]
        public void GetAllTest3()
        {
            AnalayseParameterListBiz target = new AnalayseParameterListBiz(); // TODO: Initialize to an appropriate value
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> actual;
            actual = target.GetAll(maximumRows, startRowIndex);
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
            AnalayseParameterModel expected = null; // TODO: Initialize to an appropriate value
            AnalayseParameterModel actual;
            actual = AnalayseParameterListBiz.Get(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FindByAnalayseParameterId
        ///</summary>
        [TestMethod()]
        public void FindByAnalayseParameterIdTest()
        {
            long Id = 0; // TODO: Initialize to an appropriate value
            AnalayseParameterModel expected = null; // TODO: Initialize to an appropriate value
            AnalayseParameterModel actual;
            actual = AnalayseParameterListBiz.FindByAnalayseParameterId(Id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        public void DisposeTest()
        {
            AnalayseParameterListBiz target = new AnalayseParameterListBiz(); // TODO: Initialize to an appropriate value
            target.Dispose();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteAnalayseParametersByAnalyseParameterType
        ///</summary>
        [TestMethod()]
        public void DeleteAnalayseParametersByAnalyseParameterTypeTest()
        {
            int analyseParameterTypeID = 0; // TODO: Initialize to an appropriate value
            AnalayseParameterListBiz.DeleteAnalayseParametersByAnalyseParameterType(analyseParameterTypeID);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteAnalayseParameterModel
        ///</summary>
        [TestMethod()]
        public void DeleteAnalayseParameterModelTest()
        {
            int analayseParameterID = 0; // TODO: Initialize to an appropriate value
            AnalayseParameterListBiz.DeleteAnalayseParameterModel(analayseParameterID);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        [TestMethod()]
        public void DeleteTest()
        {
            long id = 0; // TODO: Initialize to an appropriate value
            AnalayseParameterListBiz.Delete(id);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AnalayseParameterListBiz Constructor
        ///</summary>
        [TestMethod()]
        public void AnalayseParameterListBizConstructorTest()
        {
            AnalayseParameterListBiz target = new AnalayseParameterListBiz();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for AnalayseParameterListBiz Constructor
        ///</summary>
        [TestMethod()]
        public void AnalayseParameterListBizConstructorTest1()
        {
            AnalayseParameterListBiz target = new AnalayseParameterListBiz();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        [TestMethod()]
        public void DeleteTest1()
        {
            long id = 0; // TODO: Initialize to an appropriate value
            AnalayseParameterListBiz.Delete(id);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteAnalayseParameterModel
        ///</summary>
        [TestMethod()]
        public void DeleteAnalayseParameterModelTest1()
        {
            int analayseParameterID = 0; // TODO: Initialize to an appropriate value
            AnalayseParameterListBiz.DeleteAnalayseParameterModel(analayseParameterID);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteAnalayseParametersByAnalyseParameterType
        ///</summary>
        [TestMethod()]
        public void DeleteAnalayseParametersByAnalyseParameterTypeTest1()
        {
            int analyseParameterTypeID = 0; // TODO: Initialize to an appropriate value
            AnalayseParameterListBiz.DeleteAnalayseParametersByAnalyseParameterType(analyseParameterTypeID);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        public void DisposeTest1()
        {
            AnalayseParameterListBiz target = new AnalayseParameterListBiz(); // TODO: Initialize to an appropriate value
            target.Dispose();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for FindByAnalayseParameterId
        ///</summary>
        [TestMethod()]
        public void FindByAnalayseParameterIdTest1()
        {
            long Id = 0; // TODO: Initialize to an appropriate value
            AnalayseParameterModel expected = null; // TODO: Initialize to an appropriate value
            AnalayseParameterModel actual;
            actual = AnalayseParameterListBiz.FindByAnalayseParameterId(Id);
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
            AnalayseParameterModel expected = null; // TODO: Initialize to an appropriate value
            AnalayseParameterModel actual;
            actual = AnalayseParameterListBiz.Get(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAll
        ///</summary>
        [TestMethod()]
        public void GetAllTest4()
        {
            AnalayseParameterListBiz target = new AnalayseParameterListBiz(); // TODO: Initialize to an appropriate value
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> actual;
            actual = target.GetAll(maximumRows, startRowIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAll
        ///</summary>
        [TestMethod()]
        public void GetAllTest5()
        {
            AnalayseParameterListBiz target = new AnalayseParameterListBiz(); // TODO: Initialize to an appropriate value
            string sortExpression = string.Empty; // TODO: Initialize to an appropriate value
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> actual;
            actual = target.GetAll(sortExpression, maximumRows, startRowIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAll
        ///</summary>
        [TestMethod()]
        public void GetAllTest6()
        {
            AnalayseParameterListBiz target = new AnalayseParameterListBiz(); // TODO: Initialize to an appropriate value
            string sortExpression = string.Empty; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> actual;
            actual = target.GetAll(sortExpression);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAll
        ///</summary>
        [TestMethod()]
        public void GetAllTest7()
        {
            AnalayseParameterListBiz target = new AnalayseParameterListBiz(); // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> actual;
            actual = target.GetAll();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAllWithSearch
        ///</summary>
        [TestMethod()]
        public void GetAllWithSearchTest1()
        {
            AnalayseParameterListBiz target = new AnalayseParameterListBiz(); // TODO: Initialize to an appropriate value
            string searchString = string.Empty; // TODO: Initialize to an appropriate value
            bool searchPartial = false; // TODO: Initialize to an appropriate value
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> actual;
            actual = target.GetAllWithSearch(searchString, searchPartial, maximumRows, startRowIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAnalayseParameterModel
        ///</summary>
        [TestMethod()]
        public void GetAnalayseParameterModelTest1()
        {
            int analayseParameterID = 0; // TODO: Initialize to an appropriate value
            AnalayseParameterModel expected = null; // TODO: Initialize to an appropriate value
            AnalayseParameterModel actual;
            actual = AnalayseParameterListBiz.GetAnalayseParameterModel(analayseParameterID);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetAnalayseParametersByAnalyseParameterType
        ///</summary>
        [TestMethod()]
        public void GetAnalayseParametersByAnalyseParameterTypeTest1()
        {
            AnalayseParameterListBiz target = new AnalayseParameterListBiz(); // TODO: Initialize to an appropriate value
            //AnalyseParameterTypeModel analyseParameterType = null; // TODO: Initialize to an appropriate value
            //List<AnalayseParameterModel> expected = null; // TODO: Initialize to an appropriate value
            //List<AnalayseParameterModel> actual;
            //actual = target.GetAnalayseParametersByAnalyseParameterType(analyseParameterType);
            //Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for New
        ///</summary>
        [TestMethod()]
        public void NewTest1()
        {
            AnalayseParameterModel expected = null; // TODO: Initialize to an appropriate value
            AnalayseParameterModel actual;
            actual = AnalayseParameterListBiz.New();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Save
        ///</summary>
        [TestMethod()]
        public void SaveTest1()
        {
            AnalayseParameterModel param = null; // TODO: Initialize to an appropriate value
            AnalayseParameterModel expected = null; // TODO: Initialize to an appropriate value
            AnalayseParameterModel actual;
            actual = AnalayseParameterListBiz.Save(param);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Count
        ///</summary>
        [TestMethod()]
        public void CountTest1()
        {
            AnalayseParameterListBiz target = new AnalayseParameterListBiz(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Count;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

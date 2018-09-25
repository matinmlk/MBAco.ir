using MBAco.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MBAco.BusinessModel;
using System.Collections.Generic;

namespace MBAco.BLL.Test
{
    
    
    /// <summary>
    ///This is a test class for AnalayseParameterServicesTest and is intended
    ///to contain all AnalayseParameterServicesTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AnalayseParameterServicesTest
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
        ///A test for UpdateObject
        ///</summary>
        [TestMethod()]
        public void UpdateObjectTest()
        {
            int analayseParameterID = 0; // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string symbol = string.Empty; // TODO: Initialize to an appropriate value
            int analyseParameterTypeId = 0; // TODO: Initialize to an appropriate value
            string comment = string.Empty; // TODO: Initialize to an appropriate value
            AnalayseParameterModel expected = null; // TODO: Initialize to an appropriate value
            AnalayseParameterModel actual;
            actual = AnalayseParameterServices.UpdateObject(analayseParameterID, name, symbol, analyseParameterTypeId, comment);
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
            string symbol = string.Empty; // TODO: Initialize to an appropriate value
            int analyseParameterTypeId = 0; // TODO: Initialize to an appropriate value
            string comment = string.Empty; // TODO: Initialize to an appropriate value
            AnalayseParameterModel expected = null; // TODO: Initialize to an appropriate value
            AnalayseParameterModel actual;
            actual = AnalayseParameterServices.InsertObject(name, symbol, analyseParameterTypeId, comment);
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
            actual = AnalayseParameterServices.GetTotalCount();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetList
        ///</summary>
        [TestMethod()]
        public void GetListTest()
        {
            string searchString = string.Empty; // TODO: Initialize to an appropriate value
            bool searchPartial = false; // TODO: Initialize to an appropriate value
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> actual;
            actual = AnalayseParameterServices.GetList(searchString, searchPartial, maximumRows, startRowIndex);
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
            List<AnalayseParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> actual;
            actual = AnalayseParameterServices.GetList(maximumRows, startRowIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetList
        ///</summary>
        [TestMethod()]
        public void GetListTest2()
        {
            string searchString = string.Empty; // TODO: Initialize to an appropriate value
            bool searchPartial = false; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> actual;
            actual = AnalayseParameterServices.GetList(searchString, searchPartial);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetList
        ///</summary>
        [TestMethod()]
        public void GetListTest3()
        {
            string SortExpression = string.Empty; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> actual;
            actual = AnalayseParameterServices.GetList(SortExpression);
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
            string sortExpression = string.Empty; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> actual;
            actual = AnalayseParameterServices.GetList(maximumRows, startRowIndex, sortExpression);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetList
        ///</summary>
        [TestMethod()]
        public void GetListTest5()
        {
            List<AnalayseParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> actual;
            actual = AnalayseParameterServices.GetList();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Get
        ///</summary>
        [TestMethod()]
        public void GetTest()
        {
            long objectID = 0; // TODO: Initialize to an appropriate value
            AnalayseParameterModel expected = null; // TODO: Initialize to an appropriate value
            AnalayseParameterModel actual;
            actual = AnalayseParameterServices.Get(objectID);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DeleteObject
        ///</summary>
        [TestMethod()]
        public void DeleteObjectTest()
        {
            long objectID = 0; // TODO: Initialize to an appropriate value
            AnalayseParameterServices.DeleteObject(objectID);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteObject
        ///</summary>
        [TestMethod()]
        public void DeleteObjectTest1()
        {
            long objectID = 0; // TODO: Initialize to an appropriate value
            AnalayseParameterServices.DeleteObject(objectID);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Get
        ///</summary>
        [TestMethod()]
        public void GetTest1()
        {
            long objectID = 0; // TODO: Initialize to an appropriate value
            AnalayseParameterModel expected = null; // TODO: Initialize to an appropriate value
            AnalayseParameterModel actual;
            actual = AnalayseParameterServices.Get(objectID);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetList
        ///</summary>
        [TestMethod()]
        public void GetListTest6()
        {
            List<AnalayseParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> actual;
            actual = AnalayseParameterServices.GetList();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetList
        ///</summary>
        [TestMethod()]
        public void GetListTest7()
        {
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            string sortExpression = string.Empty; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> actual;
            actual = AnalayseParameterServices.GetList(maximumRows, startRowIndex, sortExpression);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetList
        ///</summary>
        [TestMethod()]
        public void GetListTest8()
        {
            string SortExpression = string.Empty; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> actual;
            actual = AnalayseParameterServices.GetList(SortExpression);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetList
        ///</summary>
        [TestMethod()]
        public void GetListTest9()
        {
            string searchString = string.Empty; // TODO: Initialize to an appropriate value
            bool searchPartial = false; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> actual;
            actual = AnalayseParameterServices.GetList(searchString, searchPartial);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetList
        ///</summary>
        [TestMethod()]
        public void GetListTest10()
        {
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> actual;
            actual = AnalayseParameterServices.GetList(maximumRows, startRowIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetList
        ///</summary>
        [TestMethod()]
        public void GetListTest11()
        {
            string searchString = string.Empty; // TODO: Initialize to an appropriate value
            bool searchPartial = false; // TODO: Initialize to an appropriate value
            int maximumRows = 0; // TODO: Initialize to an appropriate value
            int startRowIndex = 0; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> expected = null; // TODO: Initialize to an appropriate value
            List<AnalayseParameterModel> actual;
            actual = AnalayseParameterServices.GetList(searchString, searchPartial, maximumRows, startRowIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetTotalCount
        ///</summary>
        [TestMethod()]
        public void GetTotalCountTest1()
        {
            long expected = 0; // TODO: Initialize to an appropriate value
            long actual;
            actual = AnalayseParameterServices.GetTotalCount();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for InsertObject
        ///</summary>
        [TestMethod()]
        public void InsertObjectTest1()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string symbol = string.Empty; // TODO: Initialize to an appropriate value
            int analyseParameterTypeId = 0; // TODO: Initialize to an appropriate value
            string comment = string.Empty; // TODO: Initialize to an appropriate value
            AnalayseParameterModel expected = null; // TODO: Initialize to an appropriate value
            AnalayseParameterModel actual;
            actual = AnalayseParameterServices.InsertObject(name, symbol, analyseParameterTypeId, comment);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UpdateObject
        ///</summary>
        [TestMethod()]
        public void UpdateObjectTest1()
        {
            int analayseParameterID = 0; // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string symbol = string.Empty; // TODO: Initialize to an appropriate value
            int analyseParameterTypeId = 0; // TODO: Initialize to an appropriate value
            string comment = string.Empty; // TODO: Initialize to an appropriate value
            AnalayseParameterModel expected = null; // TODO: Initialize to an appropriate value
            AnalayseParameterModel actual;
            actual = AnalayseParameterServices.UpdateObject(analayseParameterID, name, symbol, analyseParameterTypeId, comment);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

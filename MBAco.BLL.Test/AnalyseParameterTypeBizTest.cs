using MBAco.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MBAco.BusinessModel;
using MBAco.DAL;

namespace MBAco.BLL.Test
{
    
    
    /// <summary>
    ///This is a test class for AnalyseParameterTypeBizTest and is intended
    ///to contain all AnalyseParameterTypeBizTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AnalyseParameterTypeBizTest
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
        ///A test for Totbl_AnalyseParameterType
        ///</summary>
        [TestMethod()]
        public void Totbl_AnalyseParameterTypeTest()
        {
            AnalyseParameterTypeModel param = null; // TODO: Initialize to an appropriate value
            tbl_AnalyseParameterType expected = null; // TODO: Initialize to an appropriate value
            tbl_AnalyseParameterType actual;
            actual = AnalyseParameterTypeBiz.Totbl_AnalyseParameterType(param);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SaveItem
        ///</summary>
        [TestMethod()]
        public void SaveItemTest()
        {
            AnalyseParameterTypeBiz target = new AnalyseParameterTypeBiz(); // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel dataItem = null; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel expected = null; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel actual;
            actual = target.SaveItem(dataItem);
            Assert.AreEqual(expected, actual);
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
            actual = AnalyseParameterTypeBiz.Save(param);
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
            AnalyseParameterTypeModel param = null; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel expected = null; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel actual;
            actual = AnalyseParameterTypeBiz_Accessor.ObjectSave(param);
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
            actual = AnalyseParameterTypeBiz.New();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetItem
        ///</summary>
        [TestMethod()]
        public void GetItemTest()
        {
            AnalyseParameterTypeBiz target = new AnalyseParameterTypeBiz(); // TODO: Initialize to an appropriate value
            long id = 0; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel expected = null; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel actual;
            actual = target.GetItem(id);
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
            actual = AnalyseParameterTypeBiz.Get(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Fromtbl_AnalyseParameterType
        ///</summary>
        [TestMethod()]
        public void Fromtbl_AnalyseParameterTypeTest()
        {
            tbl_AnalyseParameterType m_tbl_AnalyseParameterType = null; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel expected = null; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel actual;
            actual = AnalyseParameterTypeBiz.Fromtbl_AnalyseParameterType(m_tbl_AnalyseParameterType);
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
            actual = AnalyseParameterTypeBiz.FindByAnalyseParameterTypeId(Id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        public void DisposeTest()
        {
            AnalyseParameterTypeBiz target = new AnalyseParameterTypeBiz(); // TODO: Initialize to an appropriate value
            target.Dispose();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteItem
        ///</summary>
        [TestMethod()]
        public void DeleteItemTest()
        {
            AnalyseParameterTypeBiz target = new AnalyseParameterTypeBiz(); // TODO: Initialize to an appropriate value
            long id = 0; // TODO: Initialize to an appropriate value
            target.DeleteItem(id);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteItem
        ///</summary>
        [TestMethod()]
        public void DeleteItemTest1()
        {
            AnalyseParameterTypeBiz target = new AnalyseParameterTypeBiz(); // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel dataItem = null; // TODO: Initialize to an appropriate value
            target.DeleteItem(dataItem);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        [TestMethod()]
        public void DeleteTest()
        {
            long id = 0; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeBiz.Delete(id);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AnalyseParameterTypeBiz Constructor
        ///</summary>
        [TestMethod()]
        public void AnalyseParameterTypeBizConstructorTest()
        {
            AnalyseParameterTypeBiz target = new AnalyseParameterTypeBiz();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for AnalyseParameterTypeBiz Constructor
        ///</summary>
        [TestMethod()]
        public void AnalyseParameterTypeBizConstructorTest1()
        {
            AnalyseParameterTypeBiz target = new AnalyseParameterTypeBiz();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        [TestMethod()]
        public void DeleteTest1()
        {
            long id = 0; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeBiz.Delete(id);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteItem
        ///</summary>
        [TestMethod()]
        public void DeleteItemTest2()
        {
            AnalyseParameterTypeBiz target = new AnalyseParameterTypeBiz(); // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel dataItem = null; // TODO: Initialize to an appropriate value
            target.DeleteItem(dataItem);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteItem
        ///</summary>
        [TestMethod()]
        public void DeleteItemTest3()
        {
            AnalyseParameterTypeBiz target = new AnalyseParameterTypeBiz(); // TODO: Initialize to an appropriate value
            long id = 0; // TODO: Initialize to an appropriate value
            target.DeleteItem(id);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        public void DisposeTest1()
        {
            AnalyseParameterTypeBiz target = new AnalyseParameterTypeBiz(); // TODO: Initialize to an appropriate value
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
            actual = AnalyseParameterTypeBiz.FindByAnalyseParameterTypeId(Id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Fromtbl_AnalyseParameterType
        ///</summary>
        [TestMethod()]
        public void Fromtbl_AnalyseParameterTypeTest1()
        {
            tbl_AnalyseParameterType m_tbl_AnalyseParameterType = null; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel expected = null; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel actual;
            actual = AnalyseParameterTypeBiz.Fromtbl_AnalyseParameterType(m_tbl_AnalyseParameterType);
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
            actual = AnalyseParameterTypeBiz.Get(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetItem
        ///</summary>
        [TestMethod()]
        public void GetItemTest1()
        {
            AnalyseParameterTypeBiz target = new AnalyseParameterTypeBiz(); // TODO: Initialize to an appropriate value
            long id = 0; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel expected = null; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel actual;
            actual = target.GetItem(id);
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
            actual = AnalyseParameterTypeBiz.New();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ObjectSave
        ///</summary>
        [TestMethod()]
        [DeploymentItem("MBAco.BLL.dll")]
        public void ObjectSaveTest1()
        {
            AnalyseParameterTypeModel param = null; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel expected = null; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel actual;
            actual = AnalyseParameterTypeBiz_Accessor.ObjectSave(param);
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
            actual = AnalyseParameterTypeBiz.Save(param);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SaveItem
        ///</summary>
        [TestMethod()]
        public void SaveItemTest1()
        {
            AnalyseParameterTypeBiz target = new AnalyseParameterTypeBiz(); // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel dataItem = null; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel expected = null; // TODO: Initialize to an appropriate value
            AnalyseParameterTypeModel actual;
            actual = target.SaveItem(dataItem);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Totbl_AnalyseParameterType
        ///</summary>
        [TestMethod()]
        public void Totbl_AnalyseParameterTypeTest1()
        {
            AnalyseParameterTypeModel param = null; // TODO: Initialize to an appropriate value
            tbl_AnalyseParameterType expected = null; // TODO: Initialize to an appropriate value
            tbl_AnalyseParameterType actual;
            actual = AnalyseParameterTypeBiz.Totbl_AnalyseParameterType(param);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

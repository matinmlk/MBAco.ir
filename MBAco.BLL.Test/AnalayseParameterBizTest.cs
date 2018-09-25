using MBAco.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MBAco.BusinessModel;
using MBAco.DAL;

namespace MBAco.BLL.Test
{
    
    
    /// <summary>
    ///This is a test class for AnalayseParameterBizTest and is intended
    ///to contain all AnalayseParameterBizTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AnalayseParameterBizTest
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
        ///A test for Totbl_AnalayseParameter
        ///</summary>
        [TestMethod()]
        public void Totbl_AnalayseParameterTest()
        {
            AnalayseParameterModel param = null; // TODO: Initialize to an appropriate value
            tbl_AnalayseParameter expected = null; // TODO: Initialize to an appropriate value
            tbl_AnalayseParameter actual;
            actual = AnalayseParameterBiz.Totbl_AnalayseParameter(param);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for SaveItem
        ///</summary>
        [TestMethod()]
        public void SaveItemTest()
        {
            AnalayseParameterBiz target = new AnalayseParameterBiz(); // TODO: Initialize to an appropriate value
            AnalayseParameterModel dataItem = null; // TODO: Initialize to an appropriate value
            AnalayseParameterModel expected = null; // TODO: Initialize to an appropriate value
            AnalayseParameterModel actual;
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
            AnalayseParameterModel param = null; // TODO: Initialize to an appropriate value
            AnalayseParameterModel expected = null; // TODO: Initialize to an appropriate value
            AnalayseParameterModel actual;
            actual = AnalayseParameterBiz.Save(param);
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
            AnalayseParameterModel param = null; // TODO: Initialize to an appropriate value
            AnalayseParameterModel expected = null; // TODO: Initialize to an appropriate value
            AnalayseParameterModel actual;
            actual = AnalayseParameterBiz_Accessor.ObjectSave(param);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for New
        ///</summary>
        [TestMethod()]
        public void NewTest()
        {
            AnalayseParameterModel expected = null; // TODO: Initialize to an appropriate value
            AnalayseParameterModel actual;
            actual = AnalayseParameterBiz.New();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetItem
        ///</summary>
        [TestMethod()]
        public void GetItemTest()
        {
            AnalayseParameterBiz target = new AnalayseParameterBiz(); // TODO: Initialize to an appropriate value
            long id = 0; // TODO: Initialize to an appropriate value
            AnalayseParameterModel expected = null; // TODO: Initialize to an appropriate value
            AnalayseParameterModel actual;
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
            AnalayseParameterModel expected = null; // TODO: Initialize to an appropriate value
            AnalayseParameterModel actual;
            actual = AnalayseParameterBiz.Get(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Fromtbl_AnalayseParameter
        ///</summary>
        [TestMethod()]
        public void Fromtbl_AnalayseParameterTest()
        {
            tbl_AnalayseParameter m_tbl_AnalayseParameter = null; // TODO: Initialize to an appropriate value
            AnalayseParameterModel expected = null; // TODO: Initialize to an appropriate value
            AnalayseParameterModel actual;
            actual = AnalayseParameterBiz.Fromtbl_AnalayseParameter(m_tbl_AnalayseParameter);
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
            actual = AnalayseParameterBiz.FindByAnalayseParameterId(Id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        public void DisposeTest()
        {
            AnalayseParameterBiz target = new AnalayseParameterBiz(); // TODO: Initialize to an appropriate value
            target.Dispose();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteItem
        ///</summary>
        [TestMethod()]
        public void DeleteItemTest()
        {
            AnalayseParameterBiz target = new AnalayseParameterBiz(); // TODO: Initialize to an appropriate value
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
            AnalayseParameterBiz target = new AnalayseParameterBiz(); // TODO: Initialize to an appropriate value
            AnalayseParameterModel dataItem = null; // TODO: Initialize to an appropriate value
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
            AnalayseParameterBiz.Delete(id);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AnalayseParameterBiz Constructor
        ///</summary>
        [TestMethod()]
        public void AnalayseParameterBizConstructorTest()
        {
            AnalayseParameterBiz target = new AnalayseParameterBiz();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for AnalayseParameterBiz Constructor
        ///</summary>
        [TestMethod()]
        public void AnalayseParameterBizConstructorTest1()
        {
            AnalayseParameterBiz target = new AnalayseParameterBiz();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        [TestMethod()]
        public void DeleteTest1()
        {
            long id = 0; // TODO: Initialize to an appropriate value
            AnalayseParameterBiz.Delete(id);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteItem
        ///</summary>
        [TestMethod()]
        public void DeleteItemTest2()
        {
            AnalayseParameterBiz target = new AnalayseParameterBiz(); // TODO: Initialize to an appropriate value
            AnalayseParameterModel dataItem = null; // TODO: Initialize to an appropriate value
            target.DeleteItem(dataItem);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteItem
        ///</summary>
        [TestMethod()]
        public void DeleteItemTest3()
        {
            AnalayseParameterBiz target = new AnalayseParameterBiz(); // TODO: Initialize to an appropriate value
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
            AnalayseParameterBiz target = new AnalayseParameterBiz(); // TODO: Initialize to an appropriate value
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
            actual = AnalayseParameterBiz.FindByAnalayseParameterId(Id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Fromtbl_AnalayseParameter
        ///</summary>
        [TestMethod()]
        public void Fromtbl_AnalayseParameterTest1()
        {
            tbl_AnalayseParameter m_tbl_AnalayseParameter = null; // TODO: Initialize to an appropriate value
            AnalayseParameterModel expected = null; // TODO: Initialize to an appropriate value
            AnalayseParameterModel actual;
            actual = AnalayseParameterBiz.Fromtbl_AnalayseParameter(m_tbl_AnalayseParameter);
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
            actual = AnalayseParameterBiz.Get(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetItem
        ///</summary>
        [TestMethod()]
        public void GetItemTest1()
        {
            AnalayseParameterBiz target = new AnalayseParameterBiz(); // TODO: Initialize to an appropriate value
            long id = 0; // TODO: Initialize to an appropriate value
            AnalayseParameterModel expected = null; // TODO: Initialize to an appropriate value
            AnalayseParameterModel actual;
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
            AnalayseParameterModel expected = null; // TODO: Initialize to an appropriate value
            AnalayseParameterModel actual;
            actual = AnalayseParameterBiz.New();
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
            AnalayseParameterModel param = null; // TODO: Initialize to an appropriate value
            AnalayseParameterModel expected = null; // TODO: Initialize to an appropriate value
            AnalayseParameterModel actual;
            actual = AnalayseParameterBiz_Accessor.ObjectSave(param);
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
            actual = AnalayseParameterBiz.Save(param);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SaveItem
        ///</summary>
        [TestMethod()]
        public void SaveItemTest1()
        {
            AnalayseParameterBiz target = new AnalayseParameterBiz(); // TODO: Initialize to an appropriate value
            AnalayseParameterModel dataItem = null; // TODO: Initialize to an appropriate value
            AnalayseParameterModel expected = null; // TODO: Initialize to an appropriate value
            AnalayseParameterModel actual;
            actual = target.SaveItem(dataItem);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Totbl_AnalayseParameter
        ///</summary>
        [TestMethod()]
        public void Totbl_AnalayseParameterTest1()
        {
            AnalayseParameterModel param = null; // TODO: Initialize to an appropriate value
            tbl_AnalayseParameter expected = null; // TODO: Initialize to an appropriate value
            tbl_AnalayseParameter actual;
            actual = AnalayseParameterBiz.Totbl_AnalayseParameter(param);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

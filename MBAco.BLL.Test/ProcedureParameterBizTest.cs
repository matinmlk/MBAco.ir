using MBAco.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MBAco.BusinessModel;
using MBAco.DAL;

namespace MBAco.BLL.Test
{
    
    
    /// <summary>
    ///This is a test class for ProcedureParameterBizTest and is intended
    ///to contain all ProcedureParameterBizTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProcedureParameterBizTest
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
        ///A test for ProcedureParameterBiz Constructor
        ///</summary>
        [TestMethod()]
        public void ProcedureParameterBizConstructorTest()
        {
            ProcedureParameterBiz target = new ProcedureParameterBiz();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        [TestMethod()]
        public void DeleteTest()
        {
            long id = 0; // TODO: Initialize to an appropriate value
            ProcedureParameterBiz.Delete(id);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteItem
        ///</summary>
        [TestMethod()]
        public void DeleteItemTest()
        {
            ProcedureParameterBiz target = new ProcedureParameterBiz(); // TODO: Initialize to an appropriate value
            ProcedureParameterModel dataItem = null; // TODO: Initialize to an appropriate value
            target.DeleteItem(dataItem);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteItem
        ///</summary>
        [TestMethod()]
        public void DeleteItemTest1()
        {
            ProcedureParameterBiz target = new ProcedureParameterBiz(); // TODO: Initialize to an appropriate value
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
            ProcedureParameterBiz target = new ProcedureParameterBiz(); // TODO: Initialize to an appropriate value
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
            actual = ProcedureParameterBiz.FindByProcedureParameterId(Id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Fromtbl_ProcedureParameter
        ///</summary>
        [TestMethod()]
        public void Fromtbl_ProcedureParameterTest()
        {
            tbl_ProcedureParameter m_tbl_ProcedureParameter = null; // TODO: Initialize to an appropriate value
            ProcedureParameterModel expected = null; // TODO: Initialize to an appropriate value
            ProcedureParameterModel actual;
            actual = ProcedureParameterBiz.Fromtbl_ProcedureParameter(m_tbl_ProcedureParameter);
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
            actual = ProcedureParameterBiz.Get(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetItem
        ///</summary>
        [TestMethod()]
        public void GetItemTest()
        {
            ProcedureParameterBiz target = new ProcedureParameterBiz(); // TODO: Initialize to an appropriate value
            long id = 0; // TODO: Initialize to an appropriate value
            ProcedureParameterModel expected = null; // TODO: Initialize to an appropriate value
            ProcedureParameterModel actual;
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
            ProcedureParameterModel expected = null; // TODO: Initialize to an appropriate value
            ProcedureParameterModel actual;
            actual = ProcedureParameterBiz.New();
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
            ProcedureParameterModel param = null; // TODO: Initialize to an appropriate value
            ProcedureParameterModel expected = null; // TODO: Initialize to an appropriate value
            ProcedureParameterModel actual;
            actual = ProcedureParameterBiz_Accessor.ObjectSave(param);
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
            actual = ProcedureParameterBiz.Save(param);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SaveItem
        ///</summary>
        [TestMethod()]
        public void SaveItemTest()
        {
            ProcedureParameterBiz target = new ProcedureParameterBiz(); // TODO: Initialize to an appropriate value
            ProcedureParameterModel dataItem = null; // TODO: Initialize to an appropriate value
            ProcedureParameterModel expected = null; // TODO: Initialize to an appropriate value
            ProcedureParameterModel actual;
            actual = target.SaveItem(dataItem);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Totbl_ProcedureParameter
        ///</summary>
        [TestMethod()]
        public void Totbl_ProcedureParameterTest()
        {
            ProcedureParameterModel param = null; // TODO: Initialize to an appropriate value
            tbl_ProcedureParameter expected = null; // TODO: Initialize to an appropriate value
            tbl_ProcedureParameter actual;
            actual = ProcedureParameterBiz.Totbl_ProcedureParameter(param);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

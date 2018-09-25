using MBAco.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MBAco.BusinessModel;
using MBAco.DAL;

namespace MBAco.BLL.Test
{
    
    
    /// <summary>
    ///This is a test class for CultureBizTest and is intended
    ///to contain all CultureBizTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CultureBizTest
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
        ///A test for CultureBiz Constructor
        ///</summary>
        [TestMethod()]
        public void CultureBizConstructorTest()
        {
            CultureBiz target = new CultureBiz();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        [TestMethod()]
        public void DeleteTest()
        {
            long id = 0; // TODO: Initialize to an appropriate value
            CultureBiz.Delete(id);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteItem
        ///</summary>
        [TestMethod()]
        public void DeleteItemTest()
        {
            CultureBiz target = new CultureBiz(); // TODO: Initialize to an appropriate value
            CultureModel dataItem = null; // TODO: Initialize to an appropriate value
            target.DeleteItem(dataItem);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteItem
        ///</summary>
        [TestMethod()]
        public void DeleteItemTest1()
        {
            CultureBiz target = new CultureBiz(); // TODO: Initialize to an appropriate value
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
            CultureBiz target = new CultureBiz(); // TODO: Initialize to an appropriate value
            target.Dispose();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for FindByCultureId
        ///</summary>
        [TestMethod()]
        public void FindByCultureIdTest()
        {
            long Id = 0; // TODO: Initialize to an appropriate value
            CultureModel expected = null; // TODO: Initialize to an appropriate value
            CultureModel actual;
            actual = CultureBiz.FindByCultureId(Id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Fromtbl_Culture
        ///</summary>
        [TestMethod()]
        public void Fromtbl_CultureTest()
        {
            tbl_Culture m_tbl_Culture = null; // TODO: Initialize to an appropriate value
            CultureModel expected = null; // TODO: Initialize to an appropriate value
            CultureModel actual;
            actual = CultureBiz.Fromtbl_Culture(m_tbl_Culture);
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
            CultureModel expected = null; // TODO: Initialize to an appropriate value
            CultureModel actual;
            actual = CultureBiz.Get(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetItem
        ///</summary>
        [TestMethod()]
        public void GetItemTest()
        {
            CultureBiz target = new CultureBiz(); // TODO: Initialize to an appropriate value
            long id = 0; // TODO: Initialize to an appropriate value
            CultureModel expected = null; // TODO: Initialize to an appropriate value
            CultureModel actual;
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
            CultureModel expected = null; // TODO: Initialize to an appropriate value
            CultureModel actual;
            actual = CultureBiz.New();
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
            CultureModel param = null; // TODO: Initialize to an appropriate value
            CultureModel expected = null; // TODO: Initialize to an appropriate value
            CultureModel actual;
            actual = CultureBiz_Accessor.ObjectSave(param);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Save
        ///</summary>
        [TestMethod()]
        public void SaveTest()
        {
            CultureModel param = null; // TODO: Initialize to an appropriate value
            CultureModel expected = null; // TODO: Initialize to an appropriate value
            CultureModel actual;
            actual = CultureBiz.Save(param);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SaveItem
        ///</summary>
        [TestMethod()]
        public void SaveItemTest()
        {
            CultureBiz target = new CultureBiz(); // TODO: Initialize to an appropriate value
            CultureModel dataItem = null; // TODO: Initialize to an appropriate value
            CultureModel expected = null; // TODO: Initialize to an appropriate value
            CultureModel actual;
            actual = target.SaveItem(dataItem);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Totbl_Culture
        ///</summary>
        [TestMethod()]
        public void Totbl_CultureTest()
        {
            CultureModel param = null; // TODO: Initialize to an appropriate value
            tbl_Culture expected = null; // TODO: Initialize to an appropriate value
            tbl_Culture actual;
            actual = CultureBiz.Totbl_Culture(param);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

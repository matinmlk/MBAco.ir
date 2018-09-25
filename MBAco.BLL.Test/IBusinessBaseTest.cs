using MBAco.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MBAco.BLL.Test
{
    
    
    /// <summary>
    ///This is a test class for IBusinessBaseTest and is intended
    ///to contain all IBusinessBaseTest Unit Tests
    ///</summary>
    [TestClass()]
    public class IBusinessBaseTest
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
        ///A test for DeleteItem
        ///</summary>
        public void DeleteItemTestHelper<TItem>()
        {
            IBusinessBase<TItem> target = CreateIBusinessBase<TItem>(); // TODO: Initialize to an appropriate value
            long id = 0; // TODO: Initialize to an appropriate value
            target.DeleteItem(id);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        internal virtual IBusinessBase<TItem> CreateIBusinessBase<TItem>()
        {
            // TODO: Instantiate an appropriate concrete class.
            IBusinessBase<TItem> target = null;
            return target;
        }

        [TestMethod()]
        public void DeleteItemTest()
        {
            DeleteItemTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for DeleteItem
        ///</summary>
        public void DeleteItemTest1Helper<TItem>()
        {
            IBusinessBase<TItem> target = CreateIBusinessBase<TItem>(); // TODO: Initialize to an appropriate value
            TItem dataItem = default(TItem); // TODO: Initialize to an appropriate value
            target.DeleteItem(dataItem);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void DeleteItemTest1()
        {
            DeleteItemTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetItem
        ///</summary>
        public void GetItemTestHelper<TItem>()
        {
            IBusinessBase<TItem> target = CreateIBusinessBase<TItem>(); // TODO: Initialize to an appropriate value
            long id = 0; // TODO: Initialize to an appropriate value
            TItem expected = default(TItem); // TODO: Initialize to an appropriate value
            TItem actual;
            actual = target.GetItem(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void GetItemTest()
        {
            GetItemTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for SaveItem
        ///</summary>
        public void SaveItemTestHelper<TItem>()
        {
            IBusinessBase<TItem> target = CreateIBusinessBase<TItem>(); // TODO: Initialize to an appropriate value
            TItem dataItem = default(TItem); // TODO: Initialize to an appropriate value
            TItem expected = default(TItem); // TODO: Initialize to an appropriate value
            TItem actual;
            actual = target.SaveItem(dataItem);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void SaveItemTest()
        {
            SaveItemTestHelper<GenericParameterHelper>();
        }
    }
}

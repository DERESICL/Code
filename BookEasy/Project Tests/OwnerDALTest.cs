using BookEasy.DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using BookEasy.Models;

namespace Project_Tests
{
    

    [TestClass()]
    public class OwnerDALTest
    {


        private TestContext testContextInstance;


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


        [TestMethod()]
        public void updateOwnerDbTest()
        {
            OwnerDAL target = new OwnerDAL(); 
            bool expected = true; 
            bool actual;
            Owner check =new Owner();
            check.firstname = "Alexander";
            check.surname = "Carson";
            check.address1 = "92 Margarenstrasse";
            check.address2 = "Vienna";
            check.country = "Italy";
            check.email = "alexcarson@sabio.il";
            check.contactno = "+353 67639287828";
            check.holidayhomeno = "9876";
            actual = target.updateOwnerDb(check);
            Assert.AreEqual(expected, actual);

        }
        
   
        
        [TestMethod()]
        public void addOwnerDbTest()
        {
            OwnerDAL target = new OwnerDAL(); 
            Owner owns = new Owner();
            owns.firstname="Alexander";
            owns.surname="Carson";
            owns.address1="92 Margarenstrasse";
            owns.address2="Vienna";
            owns.country = "Italy";
            owns.email="alexcarson@sabio.il";
            owns.contactno="+353 67639287828";
            owns.holidayhomeno="9876";
            
            bool expected = true; 
            bool actual;
            actual = target.addOwnerDb(owns);
            Assert.AreEqual(expected, actual);

        }


        [TestMethod()]
        public void OwnerDALConstructorTest()
        {
            OwnerDAL target = new OwnerDAL();
           
        }
    }
}

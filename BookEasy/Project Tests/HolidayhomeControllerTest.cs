using BookEasy.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using BookEasy.DAL;
using System.Web.Mvc;
using BookEasy.Models;

namespace Project_Tests
{
    
    
    /// <summary>
    ///This is a test class for HolidayhomeControllerTest and is intended
    ///to contain all HolidayhomeControllerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class HolidayhomeControllerTest
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


        [TestMethod()]
        public void HolidayhomeControllerConstructorTest()
        {
            HolidayhomeController target = new HolidayhomeController();

        }


        [TestMethod()]
        public void HolidayhomeControllerConstructorTest1()
        {
            IHolidayhomeRepository HolidayhomeRepository = null; 
            HolidayhomeController target = new HolidayhomeController(HolidayhomeRepository);

        }


        [TestMethod()]
        public void BookingTest()
        {
            HolidayhomeController target = new HolidayhomeController(); // TODO: Initialize to an appropriate value
            int id = 1; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Booking(id);
            Assert.AreEqual(expected, actual);

        }

   /*     /// <summary>
        ///A test for Create
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\NCI\\BookEasy", "/")]
        [UrlToTest("http://localhost:49997/")]
        public void CreateTest()
        {
            HolidayhomeController target = new HolidayhomeController(); // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Create();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Create
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\NCI\\BookEasy", "/")]
        [UrlToTest("http://localhost:49997/")]
        public void CreateTest1()
        {
            HolidayhomeController target = new HolidayhomeController(); // TODO: Initialize to an appropriate value
            Holidayhome Holidayhome = null; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Create(Holidayhome);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\NCI\\BookEasy", "/")]
        [UrlToTest("http://localhost:49997/")]
        public void DeleteTest()
        {
            HolidayhomeController target = new HolidayhomeController(); // TODO: Initialize to an appropriate value
            int id = 0; // TODO: Initialize to an appropriate value
            Nullable<bool> saveChangesError = new Nullable<bool>(); // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Delete(id, saveChangesError);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DeleteConfirmed
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\NCI\\BookEasy", "/")]
        [UrlToTest("http://localhost:49997/")]
        public void DeleteConfirmedTest()
        {
            HolidayhomeController target = new HolidayhomeController(); // TODO: Initialize to an appropriate value
            int id = 0; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.DeleteConfirmed(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Details
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\NCI\\BookEasy", "/")]
        [UrlToTest("http://localhost:49997/")]
        public void DetailsTest()
        {
            HolidayhomeController target = new HolidayhomeController(); // TODO: Initialize to an appropriate value
            int id = 0; // TODO: Initialize to an appropriate value
            ViewResult expected = null; // TODO: Initialize to an appropriate value
            ViewResult actual;
            actual = target.Details(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\NCI\\BookEasy", "/")]
        [UrlToTest("http://localhost:49997/")]
        [DeploymentItem("BookEasy.dll")]
        public void DisposeTest()
        {
            HolidayhomeController_Accessor target = new HolidayhomeController_Accessor(); // TODO: Initialize to an appropriate value
            bool disposing = false; // TODO: Initialize to an appropriate value
            target.Dispose(disposing);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Edit
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\NCI\\BookEasy", "/")]
        [UrlToTest("http://localhost:49997/")]
        public void EditTest()
        {
            HolidayhomeController target = new HolidayhomeController(); // TODO: Initialize to an appropriate value
            Holidayhome Holidayhome = null; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Edit(Holidayhome);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Edit
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\NCI\\BookEasy", "/")]
        [UrlToTest("http://localhost:49997/")]
        public void EditTest1()
        {
            HolidayhomeController target = new HolidayhomeController(); // TODO: Initialize to an appropriate value
            int id = 0; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Edit(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Index
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\NCI\\BookEasy", "/")]
        [UrlToTest("http://localhost:49997/")]
        public void IndexTest()
        {
            HolidayhomeController target = new HolidayhomeController(); // TODO: Initialize to an appropriate value
            string sortOrder = string.Empty; // TODO: Initialize to an appropriate value
            string searchString = string.Empty; // TODO: Initialize to an appropriate value
            ViewResult expected = null; // TODO: Initialize to an appropriate value
            ViewResult actual;
            actual = target.Index(sortOrder, searchString);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        } */
    }
}

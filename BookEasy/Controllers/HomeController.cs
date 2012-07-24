using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookEasy.DAL;
using BookEasy.Models;


namespace BookEasy.Controllers
{
    public class HomeController : Controller

    {

    
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to BookEasy";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Search(string country)
        {
            return View();
        }
    }
}

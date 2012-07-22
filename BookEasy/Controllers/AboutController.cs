using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookEasy.Models;

namespace BookEasy.Controllers
{
    public class AboutController : Controller
    {
        private PropertyContext db = new PropertyContext();

        //
        // GET: /About/

        public ViewResult Index()
        {
            return View(db.Holidayhomes.ToList());
        }

    }
}
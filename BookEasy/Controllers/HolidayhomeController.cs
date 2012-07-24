using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookEasy.Models;
using BookEasy.DAL;


namespace BookEasy.Controllers
{ 
    public class HolidayhomeController : Controller
    {
        private PropertyContext db = new PropertyContext();

        //
        // GET: /Holidayhome/
/*
        public ViewResult Index()
        {
            return View(db.Holidayhomes.ToList());
        }
        */
        //Used to display holiday homes. Checks to see if a search enquiry
        //and if there is respond to user search enquiry
        public ViewResult Index(string sortOrder, string searchString)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Price" : "";
            var holidayhomes = from hse in db.Holidayhomes
                           select hse;


            if (!String.IsNullOrEmpty(searchString))
            {
                holidayhomes = holidayhomes.Where(hse => hse.country.ToUpper().Contains(searchString.ToUpper()));
            } 






            switch (sortOrder)
            {
                case "Loaction":
                    holidayhomes = holidayhomes.OrderByDescending(hse => hse.location);
                    break;
                case "Address1":
                    holidayhomes = holidayhomes.OrderBy(hse => hse.address1);
                    break;
                case "Address2":
                    holidayhomes = holidayhomes.OrderByDescending(hse => hse.address2);
                    break;
                case "Country":
                    holidayhomes = holidayhomes.OrderByDescending(hse => hse.country);
                    break;
                case "Email":
                    holidayhomes = holidayhomes.OrderByDescending(hse => hse.email);
                    break;
                case "Contactno":
                    holidayhomes = holidayhomes.OrderByDescending(hse => hse.contactno);
                    break;
                case "Amenities":
                    holidayhomes = holidayhomes.OrderByDescending(hse => hse.amenities);
                    break;
                case "Price":
                    holidayhomes = holidayhomes.OrderByDescending(hse => hse.price);
                    break;

                    //If no sort prefernece given sort by email 
                default:
                    holidayhomes = holidayhomes.OrderBy(hse => hse.email);
                    break;
            }
            return View(holidayhomes.ToList()); 

        }
        



        //
        // GET: /Holidayhome/Details/5

        public ViewResult Details(int id)
        {
            Holidayhome holidayhome = db.Holidayhomes.Find(id);
            return View(holidayhome);
        }

        //
        // GET: /Holidayhome/Create

        public ActionResult Create()
        {
            return View();
        }




        //
        // POST: /Holidayhome/Create

        [HttpPost]
        public ActionResult Create(Holidayhome holidayhome)
        {
            if (ModelState.IsValid)
            {
                db.Holidayhomes.Add(holidayhome);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(holidayhome);
        }
      
        //
        // GET: /Holidayhome/Edit/5
 
        public ActionResult update(int id)
        {
            Holidayhome holidayhome = db.Holidayhomes.Find(id);
            return View(holidayhome);
        }

        //
        // POST: /Holidayhome/Edit/5

        [HttpPost]
        public ActionResult update(Holidayhome holidayhome)
        {
            if (ModelState.IsValid)
            {
                db.Entry(holidayhome).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(holidayhome);
        }

        //
        // GET: /Holidayhome/Delete/5
 
        public ActionResult Delete(int id)
        {
            Holidayhome holidayhome = db.Holidayhomes.Find(id);
            return View(holidayhome);
        }

        //
        // POST: /Holidayhome/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Holidayhome holidayhome = db.Holidayhomes.Find(id);
            db.Holidayhomes.Remove(holidayhome);
            db.SaveChanges();
            return RedirectToAction("Index");
        }




        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
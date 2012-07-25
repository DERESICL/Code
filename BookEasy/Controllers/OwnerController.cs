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
    public class OwnerController : Controller
    {
        private PropertyContext db = new PropertyContext();

        //
        // GET: /Owner/

        //Used to display holiday homes. Checks to see if a search enquiry
        //and if there is respond to user search enquiry
        public ViewResult Index(string sortOrder, string searchString)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Country" : "";
            var owners = from own in db.Owners
                               select own;


            if (!String.IsNullOrEmpty(searchString))
            {
                owners = owners.Where(own => own.surname.ToUpper().Contains(searchString.ToUpper()) ||
                                             own.firstname.ToUpper().Contains(searchString.ToUpper()) ||
                                             own.address1.ToUpper().Contains(searchString.ToUpper()) ||
                                             own.address2.ToUpper().Contains(searchString.ToUpper()) ||
                                             own.country.ToUpper().Contains(searchString.ToUpper()) ||
                                             own.email.ToUpper().Contains(searchString.ToUpper()) ||
                                             own.contactno.ToUpper().Contains(searchString.ToUpper()) ||
                                             own.holidayhomeno.ToUpper().Contains(searchString.ToUpper()));   
            
            }


         




            switch (sortOrder)
            {
                case "Firstname":
                    owners = owners.OrderByDescending(own => own.firstname);
                    break;
                case "Surnmae":
                    owners = owners.OrderByDescending(own => own.surname);
                    break;
                case "Address1":
                    owners = owners.OrderBy(own => own.address1);
                    break;
                case "Address2":
                    owners = owners.OrderByDescending(own => own.address2);
                    break;
                case "Country":
                    owners = owners.OrderByDescending(own => own.country);
                    break;
                case "Email":
                    owners = owners.OrderByDescending(own => own.email);
                    break;
                case "Contactno":
                    owners = owners.OrderByDescending(own => own.contactno);
                    break;
                case "Holidayhomeno":
                    owners = owners.OrderByDescending(own => own.holidayhomeno);
                    break;


                //If no sort prefernece given sort by email 
                default:
                    owners = owners.OrderBy(own => own.surname);
                    break;
            }
            return View(owners.ToList());

        }
        


        //
        // GET: /Owner/Details/5

        public ViewResult Details(int id)
        {
            Owner owner = db.Owners.Find(id);
            return View(owner);
        }

        //
        // GET: /Owner/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Owner/Create

        [HttpPost]
        public ActionResult Create(Owner owner)
        {
            if (ModelState.IsValid)
            {
                db.Owners.Add(owner);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(owner);
        }
        
        //
        // GET: /Owner/Edit/5
 
        public ActionResult Edit(int id)
        {
            Owner owner = db.Owners.Find(id);
            return View(owner);
        }

        //
        // POST: /Owner/Edit/5

        [HttpPost]
        public ActionResult Edit(Owner owner)
        {
            if (ModelState.IsValid)
            {
                db.Entry(owner).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(owner);
        }

        //
        // GET: /Owner/Delete/5
 
        public ActionResult Delete(int id)
        {
            Owner owner = db.Owners.Find(id);
            return View(owner);
        }

        //
        // POST: /Owner/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Owner owner = db.Owners.Find(id);
            db.Owners.Remove(owner);
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
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
    public class HolidayhomeController : Controller
    {
        private PropertyContext db = new PropertyContext();

        //
        // GET: /Holidayhome/

        public ViewResult Index()
        {
            return View(db.Holidayhomes.ToList());
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
 
        public ActionResult Edit(int id)
        {
            Holidayhome holidayhome = db.Holidayhomes.Find(id);
            return View(holidayhome);
        }

        //
        // POST: /Holidayhome/Edit/5

        [HttpPost]
        public ActionResult Edit(Holidayhome holidayhome)
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
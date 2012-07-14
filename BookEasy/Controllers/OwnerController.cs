﻿using System;
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

        public ViewResult Index()
        {
            return View(db.Owners.ToList());
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
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookEasy.Models;
using BookEasy.DAL;


namespace ContosoUniversity.Controllers
{
    public class OwnerController : Controller
    {
        private IOwnerRepository OwnerRepository;


        public OwnerController()
        {
            this.OwnerRepository = new OwnerRepository(new PropertyContext());
        }

        public OwnerController(IOwnerRepository OwnerRepository)
        {
            this.OwnerRepository = OwnerRepository;
        }

        //Used to display holiday homes. Checks to see if a search enquiry
        //and if there is respond to user search enquiry
        public ViewResult Index(string sortOrder, string searchString)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Country" : "";




            var Owners = from own in OwnerRepository.GetOwners()
                               select own;


            if (!String.IsNullOrEmpty(searchString))
            {
                Owners = Owners.Where(own => own.firstname.ToUpper().Contains(searchString.ToUpper()) ||
                                             own.surname.ToUpper().Contains(searchString.ToUpper()) ||                         
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
                    Owners = Owners.OrderByDescending(own => own.firstname);
                    break;
                case "Surname":
                    Owners = Owners.OrderByDescending(own => own.surname);
                    break;
                case "Address1":
                    Owners = Owners.OrderBy(own => own.address1);
                    break;
                case "Address2":
                    Owners = Owners.OrderByDescending(own => own.address2);
                    break;
                case "Country":
                    Owners = Owners.OrderByDescending(own => own.country);
                    break;
                case "Email":
                    Owners = Owners.OrderByDescending(own => own.email);
                    break;

                case "Contactno":
                    Owners = Owners.OrderByDescending(own => own.contactno);
                    break;
                case "Holidayhomeid":
                    Owners = Owners.OrderByDescending(own => own.holidayhomeno);
                    break;

                //If no sort prefernece given sort by email 
                default:
                    Owners = Owners.OrderBy(own => own.email);
                    break;
            }
            return View(Owners.ToList());

        }


        // 
        // GET: /Owner/Edit/5 

        public ActionResult Edit(int id)
        {
            Owner Owner = OwnerRepository.GetOwnerByID(id);
            return View(Owner);
        }

        // 
        // POST: /Owner/Edit/5 

        [HttpPost]
        public ActionResult Edit(Owner Owner)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    OwnerRepository.UpdateOwner(Owner);
                    OwnerRepository.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                //Log the error (add a variable name after DataException) 
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(Owner);
        }

        // 
        // GET: /Owner/Delete/5 

        public ActionResult Delete(int id, bool? saveChangesError)
        {
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Unable to save changes. Try again, and if the problem persists see your system administrator.";
            }
            Owner Owner = OwnerRepository.GetOwnerByID(id);
            return View(Owner);
        }


        // 
        // POST: /Owner/Delete/5 

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                Owner Owner = OwnerRepository.GetOwnerByID(id);
                OwnerRepository.DeleteOwner(id);
                OwnerRepository.Save();
            }
            catch (DataException)
            {
                //Log the error (add a variable name after DataException) 
                return RedirectToAction("Delete",
                    new System.Web.Routing.RouteValueDictionary {  
                { "id", id },  
                { "saveChangesError", true } });
            }
            return RedirectToAction("Index");
        }


        // 
        // GET: /Owner/Details/5 

        public ViewResult Details(int id)
        {
            Owner Owner = OwnerRepository.GetOwnerByID(id);
            return View(Owner);
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
        public ActionResult Create(Owner Owner)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    OwnerRepository.InsertOwner(Owner);
                    OwnerRepository.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                //Log the error (add a variable name after DataException) 
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(Owner);
        }


        protected override void Dispose(bool disposing)
        {
            OwnerRepository.Dispose();
            base.Dispose(disposing);
        }
    }
}
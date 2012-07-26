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
    public class HolidayhomeController : Controller 
    {
        private IHolidayhomeRepository HolidayhomeRepository;
 
 
        public HolidayhomeController() 
        { 
            this.HolidayhomeRepository = new HolidayhomeRepository(new PropertyContext()); 
        } 
 
        public HolidayhomeController(IHolidayhomeRepository HolidayhomeRepository) 
        { 
            this.HolidayhomeRepository = HolidayhomeRepository; 
        } 

        //Used to display holiday homes. Checks to see if a search enquiry
        //and if there is respond to user search enquiry
        public ViewResult Index(string sortOrder, string searchString)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Price" : "";



                      
            var holidayhomes = from hse in HolidayhomeRepository.GetHolidayhomes()
                           select hse;


            if (!String.IsNullOrEmpty(searchString))
            {
                holidayhomes = holidayhomes.Where(hse => hse.location.ToUpper().Contains(searchString.ToUpper()) ||
                                             hse.address1.ToUpper().Contains(searchString.ToUpper()) ||
                                             hse.address2.ToUpper().Contains(searchString.ToUpper()) ||
                                             hse.country.ToUpper().Contains(searchString.ToUpper()) ||
                                             hse.email.ToUpper().Contains(searchString.ToUpper()) ||
                                             hse.contactno.ToUpper().Contains(searchString.ToUpper()) ||
                                             hse.amenities.ToUpper().Contains(searchString.ToUpper()) ||
                                             hse.price.ToUpper().Contains(searchString.ToUpper())); 

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
        // GET: /Holidayhome/Edit/5 

        public ActionResult Edit(int id)
        {
            Holidayhome Holidayhome = HolidayhomeRepository.GetHolidayhomeByID(id);
            return View(Holidayhome);
        }

        // 
        // POST: /Holidayhome/Edit/5 

        [HttpPost]
        public ActionResult Edit(Holidayhome Holidayhome)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    HolidayhomeRepository.UpdateHolidayhome(Holidayhome);
                    HolidayhomeRepository.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                //Log the error (add a variable name after DataException) 
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(Holidayhome);
        }

        // 
        // GET: /Holidayhome/Delete/5 

        public ActionResult Delete(int id, bool? saveChangesError)
        {
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Unable to save changes. Try again, and if the problem persists see your system administrator.";
            }
            Holidayhome Holidayhome = HolidayhomeRepository.GetHolidayhomeByID(id);
            return View(Holidayhome);
        }


        // 
        // POST: /Holidayhome/Delete/5 

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                Holidayhome Holidayhome = HolidayhomeRepository.GetHolidayhomeByID(id);
                HolidayhomeRepository.DeleteHolidayhome(id);
                HolidayhomeRepository.Save();
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
        // GET: /Holidayhome/Details/5 

        public ViewResult Details(int id)
        {
            Holidayhome Holidayhome = HolidayhomeRepository.GetHolidayhomeByID(id);
            return View(Holidayhome);
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
        public ActionResult Create(Holidayhome Holidayhome)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    HolidayhomeRepository.InsertHolidayhome(Holidayhome);
                    HolidayhomeRepository.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                //Log the error (add a variable name after DataException) 
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(Holidayhome);
        } 


        protected override void Dispose(bool disposing)
        {
            HolidayhomeRepository.Dispose();
            base.Dispose(disposing);
        }
    }
}
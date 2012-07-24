using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using BookEasy.Models;
using System.Data.Entity;
using System.Data;

namespace BookEasy.DAL
{
    public class HolidayhomeDAL
    {
        // for writing to the dB
        protected PropertyContext db = new PropertyContext();
        // for reading from the dB and showing graphically
        protected PropertyContext dbr = new PropertyContext();


        public bool updateHolidayhomeDb(Holidayhome hse)
        {
            db.Entry(hse).State = EntityState.Modified;

                db.SaveChanges();
                return true;

        }

        public bool addHolidayhomeDb(Holidayhome hse)
        {
            Holidayhome home = new Holidayhome();
         
                home = db.Holidayhomes.Add(hse);
      

            if (home is Holidayhome)
            {
                db.SaveChanges();
                return true;
            }
            return false;
        }


        //Respond to user search enquiry

        public List<Holidayhome> Search(string country)
        {   

            List<Holidayhome> Search= new List<Holidayhome>();
            List<Holidayhome> listed = null;
                listed = db.Holidayhomes.ToList();

                    foreach (Holidayhome ctry in listed)
                    {
                        ctry.country.Equals(country);
                        Search.Add(ctry);
                    }
                return Search;
            
        }
    } 
}
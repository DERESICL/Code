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
            try
            {
                db.SaveChanges();
                return true;
            }
            catch (Exception exp)
            {
               
                return false;
            }
        }

        public bool addHolidayhomeDb(Holidayhome hse)
        {
            Holidayhome home = new Holidayhome();
            try
            {
                home = db.Holidayhomes.Add(hse);
            }
            
            catch (Exception exp)
            {
               
                Exception j = exp;
                return false;
                //do something
            }

            if (home is Holidayhome)
            {
                db.SaveChanges();
                return true;
            }
            return false;
        }

    } 
}
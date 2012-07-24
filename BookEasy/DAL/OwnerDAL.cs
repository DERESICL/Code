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
    public class OwnerDAL
    {
        // for writing to the dB
        protected PropertyContext db = new PropertyContext();
        // for reading from the dB and showing graphically
        protected PropertyContext dbr = new PropertyContext();


        public bool updateOwnerDb(Owner own)
        {
            db.Entry(own).State = EntityState.Modified;
            db.SaveChanges();
            return true;
        }
        

        public bool addOwnerDb(Owner own)
        {
            Owner owr = new Owner();
            try
            {
                owr = db.Owners.Add(own);
            }

            catch (Exception exp)
            {

                Exception j = exp;
                return false;
                
            }

            if (owr is Owner)
            {
                db.SaveChanges();
                return true;
            }
            return false;
        }

    }
}

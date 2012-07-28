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
    public class BookingDAL
    {
        // for writing to the dB
        protected PropertyContext db = new PropertyContext();
        // for reading from the dB and showing graphically
        protected PropertyContext dbr = new PropertyContext();


        public bool updateBookingDb(Booking bok)
        {
            db.Entry(bok).State = EntityState.Modified;
            db.SaveChanges();
            return true;
        }
        

        public bool addBookingDb(Booking bok)
        {
            Booking book = new Booking();
            try
            {
                book = db.Bookings.Add(bok);
            }

            catch (Exception exp)
            {

                Exception j = exp;
                return false;
                
            }

            if (bok is Booking)
            {
                db.SaveChanges();
                return true;
            }
            return false;
        }

    }
}


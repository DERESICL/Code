using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using BookEasy.Models;
using System.Data.Entity;
using System.Data;
using BookEasy.DAL;
using BookEasy.Ingestion;

namespace BookEasy.BLL
{
    public class BookingBL
    {
        // for writing to the dB
        protected PropertyContext db = new PropertyContext();
        // for reading from the dB and showing graphically
        protected PropertyContext dbr = new PropertyContext();


        public List<Holidayhome> Booking(int id,string holidayhomeno)
        {

            List<Holidayhome> Search = new List<Holidayhome>();
            List<Holidayhome> listed = null;
            listed = db.Holidayhomes.ToList();


            foreach (Holidayhome refno in listed)
            {
                refno.holidayhomeno.Equals(holidayhomeno);
                Search.Add(refno);
            }
            return Search;

                            
          
           }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;



//Add the following four properties to the Booking class:
namespace BookEasy.Models
{
    public class Booking
    {

        public int BookingID { get; set; }
        public string holidayhomeno { get; set; }
        public string customername { get; set; }
        public string address { get; set; }
        public string price { get; set; }
        public string startdate { get; set; }
        public string enddate { get; set; }
        public string creditcardtype { get; set; }
        public string expirydate { get; set; }
        public string csvno{ get; set; }
       
    }
}
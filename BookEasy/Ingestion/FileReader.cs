using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookEasy.Models;
using BookEasy.Ingestion;
using System.IO;

namespace BookEasy.Ingestion
{
    public class FileReader
    {
        private string Holidayhomefile = "D:\\NCI\\holidayhomes.csv";
        private string Ownerfile = "D:\\NCI\\owners.csv";
        private string Bookingfile = "D:\\NCI\\bookings.csv";
        private StreamReader Reader;


        public List<Holidayhome> getCSVdata()
        {   
            //Checks to see your CSV file exists
            if (!File.Exists(Holidayhomefile))
            {
                return null;
            }

            Reader = new StreamReader(Holidayhomefile);
            CSVParser dataparse = new CSVParser();
            
            dataparse.setStreamSource(Reader);
            return (dataparse.parseHolidayhomes());

        }


        public List<Owner> getCSVOwnerdata()
        {
            //Checks to see your CSV file exists
            if (!File.Exists(Holidayhomefile))
            {
                return null;
            }

            Reader = new StreamReader(Ownerfile);
            CSVParser dataparse = new CSVParser();

            dataparse.setStreamSource(Reader);
            return (dataparse.parseOwners());

        }

        public List<Booking> getCSVBookingdata()
        {
            //Checks to see your CSV file exists
            if (!File.Exists(Bookingfile))
            {
                return null;
            }

            Reader = new StreamReader(Bookingfile);
            CSVParser dataparse = new CSVParser();

            dataparse.setStreamSource(Reader);
            return (dataparse.parseBookings());

        }


    }
}
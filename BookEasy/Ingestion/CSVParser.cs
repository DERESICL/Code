using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using LumenWorks.Framework.IO.Csv;
using BookEasy.Models;


namespace BookEasy.Ingestion
{
    public class CSVParser : IDataParser
    {

        private String supportedFormat = "csv";
        private StreamReader reader; 

        //Create List to store your CSV data
        public List<Models.Holidayhome> parseHolidayhomes()
        {
            CsvReader csv = new CsvReader(reader, true);
            int fieldCount = csv.FieldCount;
            List<Holidayhome> holidaylist = new List<Holidayhome>();
            

            String[] headers = csv.GetFieldHeaders();
                        




            while (csv.ReadNextRecord())
            {
                Holidayhome exObj = new Holidayhome();
                   
                for (int i = 0; i < fieldCount; i++)
                {
                    if (headers[i].Equals("holidayhomeno"))  {exObj.holidayhomeno = csv[i];}
                    else if (headers[i].Equals("address1")) { exObj.address1 = csv[i]; }
                    else if (headers[i].Equals("address2")) { exObj.address2 = csv[i]; }
                    else if (headers[i].Equals("country"))  { exObj.country = csv[i];  }
                    else if (headers[i].Equals("email"))    { exObj.email = csv[i];    }
                    else if (headers[i].Equals("contactno")){ exObj.contactno = csv[i];}
                    else if (headers[i].Equals("amenities")){ exObj.amenities = csv[i];}
                    else if (headers[i].Equals("price")) { exObj.price = csv[i]; }



                }

                holidaylist.Add(exObj);
            }

           return holidaylist;
        }




        //Create List to store your CSV data
        public List<Models.Owner> parseOwners()
        {
            CsvReader csv = new CsvReader(reader, true);
            int fieldCount = csv.FieldCount;
            List<Owner> ownerlist = new List<Owner>();


            String[] headers = csv.GetFieldHeaders();





            while (csv.ReadNextRecord())
            {
                Owner exObj = new Owner();

                for (int i = 0; i < fieldCount; i++)
                {
                    if (headers[i].Equals("firstname")) { exObj.firstname = csv[i]; }
                    else if (headers[i].Equals("surname")) { exObj.surname = csv[i]; }
                    else if (headers[i].Equals("address1")) { exObj.address1 = csv[i]; }
                    else if (headers[i].Equals("address2")) { exObj.address2 = csv[i]; }
                    else if (headers[i].Equals("country")) { exObj.country = csv[i]; }
                    else if (headers[i].Equals("email")) { exObj.email = csv[i]; }
                    else if (headers[i].Equals("contactno")) { exObj.contactno = csv[i]; }
                    else if (headers[i].Equals("holidayhomeno")) { exObj.holidayhomeno = csv[i]; }
                 }

                ownerlist.Add(exObj);
            }

            return ownerlist;
        }


        //Create List to store your CSV data
        public List<Models.Booking> parseBookings()
        {
            CsvReader csv = new CsvReader(reader, true);
            int fieldCount = csv.FieldCount;
            List<Booking> bookinglist = new List<Booking>();


            String[] headers = csv.GetFieldHeaders();





            while (csv.ReadNextRecord())
            {
                Booking exObj = new Booking();

                for (int i = 0; i < fieldCount; i++)
                {
                    if (headers[i].Equals("holidayhomeno")) { exObj.holidayhomeno = csv[i]; }
                    else if (headers[i].Equals("customername")) { exObj.customername = csv[i]; }
                    else if (headers[i].Equals("address")) { exObj.address = csv[i]; }
                    else if (headers[i].Equals("price")) { exObj.price = csv[i]; }
                    else if (headers[i].Equals("startdate")) { exObj.startdate = csv[i]; }
                    else if (headers[i].Equals("enddate")) { exObj.enddate = csv[i]; }
                    else if (headers[i].Equals("creditcardtype")) { exObj.creditcardtype = csv[i]; }
                    else if (headers[i].Equals("expirydate")) { exObj.expirydate = csv[i]; }
                }

                bookinglist.Add(exObj);
            }

            return bookinglist;
        }

        public void setStreamSource(StreamReader reader)
        {
            this.reader = reader;
        }

        public bool supportsType(string format)
        {
            // What if format is null??
            if (format == null)
            {
                return false;
            }

            if (format.Equals(supportedFormat)) {
                return true;
            }
            return false;
        }


    }
}
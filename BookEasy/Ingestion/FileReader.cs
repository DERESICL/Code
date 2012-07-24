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



    }
}
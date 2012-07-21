using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookEasy.Models;
using BookEasy.Ingestion;
using BookEasy.DAL;

namespace BookEasy.Logic
{
    public class BuildDatabase
    {
        private FileReader parsefile = new FileReader();

        public BuildDatabase()
        {
            addHomestoDb();
        }


        private void addHomestoDb()
        {

            List<Holidayhome> homes = parsefile.getCSVdata();
            HolidayhomeDAL homeDAL = new HolidayhomeDAL();
            

            foreach (Holidayhome hse in homes)
            {
              homeDAL.addHolidayhomeDb(hse);

            }

        }
    }

    }

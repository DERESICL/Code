using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookEasy.Models;
using BookEasy.DAL;

namespace BookEasy.Ingestion
{
    public class BuildDatabase
    {
        private FileReader parsefile = new FileReader();

        public BuildDatabase()
        {
            addHomestoDb();
            addOwnerstoDb();
        }


        private void addHomestoDb()
        {

            List<Holidayhome> holidaylist = parsefile.getCSVdata();
            HolidayhomeDAL homeDAL = new HolidayhomeDAL();


            foreach (Holidayhome hse in holidaylist)
            {
                homeDAL.addHolidayhomeDb(hse);

            }

        }


        private void addOwnerstoDb()
        {

            List<Owner> Ownerlist = parsefile.getCSVOwnerdata();
            OwnerDAL owrDAL = new OwnerDAL();


            foreach (Owner own in Ownerlist)
            {
                owrDAL.addOwnerDb(own);

            }

        }




    }

}

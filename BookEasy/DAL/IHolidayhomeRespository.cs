using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookEasy.Models;

namespace BookEasy.DAL
{

    //This code declares a typical set of CRUD methods, including 
    //two read methods — one that returns all Holidayhome entities, and one that finds a single Holidayhome entity by ID.
    public interface IHolidayhomeRepository : IDisposable
    {
        IEnumerable<Holidayhome> GetHolidayhomes();
        Holidayhome GetHolidayhomeByID(int holidayhomeId);
        void InsertHolidayhome(Holidayhome holidayhome);
        void DeleteHolidayhome(int holidayhomeID);
        void UpdateHolidayhome(Holidayhome holidayhome);
        void Save();
    }
}
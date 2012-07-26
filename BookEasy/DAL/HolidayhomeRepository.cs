using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using BookEasy.Models;


namespace BookEasy.DAL
{
    public class HolidayhomeRepository : IHolidayhomeRepository, IDisposable
    {
        private PropertyContext context;

        public HolidayhomeRepository(PropertyContext context)
        {
            this.context = context;
        }

        public IEnumerable<Holidayhome> GetHolidayhomes()
        {
            return context.Holidayhomes.ToList();
        }

        public Holidayhome GetHolidayhomeByID(int id)
        {
            return context.Holidayhomes.Find(id);
        }

        public void InsertHolidayhome(Holidayhome Holidayhome)
        {
            context.Holidayhomes.Add(Holidayhome);
        }

        public void DeleteHolidayhome(int HolidayhomeID)
        {
            Holidayhome Holidayhome = context.Holidayhomes.Find(HolidayhomeID);
            context.Holidayhomes.Remove(Holidayhome);
        }

        public void UpdateHolidayhome(Holidayhome Holidayhome)
        {
            context.Entry(Holidayhome).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookEasy.Models;
using BookEasy.DAL;

namespace BookEasy.DAL
{
    public class BookingRepository : IDisposable
    {
        private BookingEntities context = new BookingEntities();

        public IEnumerable<Booking> GetBookings()
        {
            return context.Booking.Include("Customername").ToList();
        }

        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposedValue = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookEasy.Models;

namespace BookEasy.DAL
{
    public interface IBookingRepository : IDisposable
    {
        IEnumerable<Booking> GetBookings();
        void InsertBooking(Booking Booking);
        void DeleteBooking(Booking Booking);
        void UpdateBooking(Booking Booking, Booking origBooking);
        
    }
}

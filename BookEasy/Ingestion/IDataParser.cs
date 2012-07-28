using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookEasy.Models;
using System.IO;

namespace BookEasy.Ingestion
{
    public interface IDataParser
    {
        List<Holidayhome> parseHolidayhomes();
        List<Owner> parseOwners();
        List<Booking> parseBookings();
        void setStreamSource(StreamReader reader);
        Boolean supportsType(String format);

        
    }
}

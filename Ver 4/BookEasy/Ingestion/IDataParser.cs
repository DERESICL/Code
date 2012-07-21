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
        void setStreamSource(StreamReader reader);
        Boolean supportsType(String format);
    }
}

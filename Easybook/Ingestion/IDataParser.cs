using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Easybook.Models;
using System.IO;

namespace Easybook.Ingestion
{
    interface IDataParser
    {
        List<Holidayhome> parseHolidayhomes();
        void setStreamSource(StreamReader reader);
        Boolean supportsType(String format);
    }
}

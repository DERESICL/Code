using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Easybook.Models;
using System.IO;

namespace Easybook.Dataingestion
{
    interface IHolidayHomeParser
    {
        public List<Holidayhome> parseHolidayhomes();
        public void setDataSource(StreamReader reader);
    }
}

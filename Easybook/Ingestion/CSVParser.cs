using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using LumenWorks.Framework.IO.Csv;
using Easybook.Models;

namespace Easybook.Ingestion
{
    public class CSVParser : IDataParser
    {

        private String supportedFormat = "csv";
        private StreamReader reader;

        List<Models.Holidayhome> IDataParser.parseHolidayhomes()
        {
            CsvReader csv = new CsvReader(reader, true);
            int fieldCount = csv.FieldCount;
            List<Holidayhome> rates = new List<Holidayhome>();

            String[] headers = csv.GetFieldHeaders();

            while (csv.ReadNextRecord())
            {
                Holidayhome exObj = new Holidayhome();

                for (int i = 0; i < fieldCount; i++)
                {
                    if (headers[i].Equals("location"))
                    {
                        exObj.location = csv[i];
                    }
                    else if (headers[i].Equals("address1"))
                    {
                        exObj.address1 = csv[i];
                    }
                    else if (headers[i].Equals("address2"))
                    {
                        exObj.address2 = csv[i];
                    }
                    else if (headers[i].Equals("country"))
                    {
                        exObj.country = csv[i];
                    }
                    else if (headers[i].Equals("email"))
                    {
                        exObj.email = csv[i];
                    }
                    else if (headers[i].Equals("contactno"))
                    {
                        exObj.contactno = csv[i];
                    }
                    else if (headers[i].Equals("amenities"))
                    {
                        exObj.amenities = csv[i];
                    }

                    
                }

                return location;
            }
        }
        void IDataParser.setStreamSource(StreamReader reader)
        {
            this.reader = reader;
        }

        public bool supportsType(string format)
        {
            // What if format is null??
            if (format == null)
            {
                return false;
            }

            if (format.Equals(supportedFormat)) {
                return true;
            }
            return false;
        }

           }
}
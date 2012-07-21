using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using BookEasy.Models;
using System.Data.Entity;
using System.Data;

namespace BookEasy.DAL
{
    public class HolidayhomeDAL
    {
        // for writing to the dB
        protected PropertyContext db = new PropertyContext();
        // for reading from the dB and showing graphically
        // protected PropertyContext dbr = new PropertyContext(false);

        public HolidayhomeDAL()
        {
            Database.SetInitializer<PropertyContext>(new DropCreateDatabaseIfModelChanges<PropertyContext>());
            ConnectionStringSettingsCollection connections = ConfigurationManager.ConnectionStrings;
            if (connections.Count != 0)
            {
                Console.WriteLine();
                System.Diagnostics.Debug.WriteLine("Using connection strings property");

                // Get the collection elements
                foreach (ConnectionStringSettings connection in connections)
                {
                    string name = connection.Name;
                    string provider = connection.ProviderName;
                    string connectionString = connection.ConnectionString;

                    System.Diagnostics.Debug.WriteLine("Name:           {0}", name);
                    System.Diagnostics.Debug.WriteLine("Connection String:           {0}", connectionString);
                    System.Diagnostics.Debug.WriteLine("Provider:           {0}", provider);
                }
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("No connection string is defined");
            }
        }

        public bool updateHolidayhomeDb(Holidayhome hse)
        {
            db.Entry(hse).State = EntityState.Modified;
            try
            {
                db.SaveChanges();
                return true;
            }
            catch (Exception exp)
            {
                // do something
                return false;
            }
        }

        public bool addHolidayhomeDb(Holidayhome hse)
        {
            Holidayhome home = new Holidayhome();
            try
            {
                home = db.Holidayhomes.Add(hse);
            }
            
            catch (Exception exp)
            {
                Exception j = exp;
                return false;
                //do something
            }

            if (home is Holidayhome)
            {
                db.SaveChanges();
                return true;
            }
            return false;
        }

    } 
}
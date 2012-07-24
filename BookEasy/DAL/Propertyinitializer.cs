using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using BookEasy.Models;
using BookEasy.Ingestion;

namespace BookEasy.DAL
{
    public class Propertyinitializer : DropCreateDatabaseIfModelChanges<PropertyContext>
    {
        protected override void Seed(PropertyContext context)
        {
            BuildDatabase DB = new BuildDatabase();
            context.SaveChanges();
             
        }
    }
}




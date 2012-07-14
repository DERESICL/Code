using System;
using System.Collections.Generic;
using System.Data.Entity;
using BookEasy.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BookEasy.Models
{
    public class Properties : DbContext
    {
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Holidayhome> Holidayhomes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}

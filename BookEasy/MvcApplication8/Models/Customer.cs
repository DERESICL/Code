using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;  

// Data.Entity needed for Dbset and DbContext

//Add the following seven properties to the Customer class:
namespace Easybook.Models
{
    public class Customer
    {

        public int CustomerID { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Email { get; set; }
        public string Contactno { get; set; }


    }

    //We'll use the Customer class to represent a customer in our database. Each instance of a 
    //Customerobject will correspond to a row within our database table, and each property 
    //of the Customerclass will map to a column in the table.
//
  //  public class HolidayhomeDBContext : DbContext
  //  {
  //      public DbSet<Customer> Customers { get; set; }
  //  }


    // The Customer DBContext class represents the Entity Framework Customerdatabase context, which 
    // handles fetching, storing, and updating Customers class instances in a database. 

}
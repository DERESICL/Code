using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

// Data.Entity needed for Dbset and DbContext

//Add the following seven properties to the Customer class:

public class Holidayhome
{

    public int HolidayhomeID { get; set; }
    public string Location { get; set; }
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string Country { get; set; }
    public string Email { get; set; }
    public string Contactno { get; set; }
    public string Amenities { get; set; }


}

//We'll use the Customer class to represent a customer in our database. Each instance of a 
//Holiday home object will correspond to a row within our database table, and each property 
//of the Holiday Home class will map to a column in the table.

public class HolidayhomeDBContext : DbContext
{
    public DbSet<Holidayhome> Holodayhomes { get; set; }
}


// The Holidayhome DBContext class represents the Entity Framework Holiday Home database context, which 
// handles fetching, storing, and updating Holiday Homes class instances in a database.

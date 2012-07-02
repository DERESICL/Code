using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

// Data.Entity needed for Dbset and DbContext

//Add the following two properties to the Customer class:

public class Availability
{

    public int startdate { get; set; }
    public int enddate { get; set; }

}

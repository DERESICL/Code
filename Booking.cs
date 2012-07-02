using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;



//Add the following four properties to the Booking class:

public class Booking
{

    public int HolidayhomeID { get; set; }
    public string Price { get; set; }
    public DateTime Startdate { get; set; }
    public DateTime Enddate { get; set; }

}

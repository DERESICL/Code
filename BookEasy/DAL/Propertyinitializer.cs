using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using BookEasy.Models;

namespace BookEasy.DAL
{
    public class PropertyInitializer : DropCreateDatabaseIfModelChanges<PropertyContext>
    {
        protected override void Seed(PropertyContext context)
        {
            var owners = new List<Owner> 
            { 
                new Owner { Firstname = "Carson",   Surname = "Alexander", Address1 =" 1 james Street", Address2 ="Booterstown", Contactno ="1928828", Email ="jjjhh@kk/iw", Holidayhomeno ="1" }, 
                new Owner { Firstname = "Meredith", Surname = "Alonso",   Address1 =" 1 james Street", Address2 ="Booterstown", Contactno ="1928828", Email ="jjjhh@kk/iw", Holidayhomeno ="1" },  
                new Owner { Firstname  = "Arturo",   Surname = "Anand",  Address1 =" 1 james Street", Address2 ="Booterstown", Contactno ="1928828", Email ="jjjhh@kk/iw", Holidayhomeno ="1" },  
                new Owner { Firstname  = "Gytis",    Surname = "Barzdukas",  Address1 =" 1 james Street", Address2 ="Booterstown", Contactno ="1928828", Email ="jjjhh@kk/iw", Holidayhomeno ="1" }, 
                new Owner { Firstname  = "Yan",      Surname = "Li", Address1 =" 1 james Street", Address2 ="Booterstown", Contactno ="1928828", Email ="jjjhh@kk/iw", Holidayhomeno ="1" }, 
                new Owner { Firstname  = "Peggy",    Surname = "Justice", Address1 =" 1 james Street", Address2 ="Booterstown", Contactno ="1928828", Email ="jjjhh@kk/iw", Holidayhomeno ="1" },  
                new Owner { Firstname  = "Laura",    Surname = "Norman", Address1 =" 1 james Street", Address2 ="Booterstown", Contactno ="1928828", Email ="jjjhh@kk/iw", Holidayhomeno ="1" },  
                new Owner { Firstname  = "Nino",     Surname = "Olivetto", Address1 =" 1 james Street", Address2 ="Booterstown", Contactno ="1928828", Email ="jjjhh@kk/iw", Holidayhomeno ="1" } 
            };
            owners.ForEach(s => context.Owners.Add(s));
            context.SaveChanges();

    



            var holidayhomes = new List<Holidayhome> 
            { 
                new Holidayhome { location = "Spain", address1 = "1 Costa", address2 = "Valencia", country = "Ireland", email ="jjjhh@kk/iw", contactno ="1928828", amenities ="jjjhh@kk/iw" },
                new Holidayhome { location = "France", address1 = "14 Rue De Pierre", address2 = "Biot" ,  country = "Ireland", email ="jjjhh@kk/iw", contactno ="1928828", amenities ="jjjhh@kk/iw" },
                new Holidayhome { location = "Ireland", address1 = "114 Peter Street", address2 = "Dublin 2" ,  country = "Ireland", email ="jjjhh@kk/iw", contactno ="1928828", amenities ="jjjhh@kk/iw" }
            };
            holidayhomes.ForEach(s => context.Holidayhomes.Add(s));
            context.SaveChanges();

           // var subscribes = new List<Subscribe>
//            { 
  //              new Subscribe { SubscribeID = 1, HolidayhomeID = 2, OwnerID=3 }, 
    //            new Subscribe { SubscribeID = 21, HolidayhomeID = 22, OwnerID=23 }, 
      //      };
        //    subscribes.ForEach(s => context.Subscribes.Add(s));
          //  context.SaveChanges();
        }
    }
}

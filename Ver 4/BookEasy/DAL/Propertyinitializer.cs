using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using BookEasy.Models;
using BookEasy.Logic;

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

        /*
            { 
                new Owner { Firstname = "Alexander",   Surname = "Carson", Address1 =" 92 Margarenstrasse", Address2 ="Vienna", Contactno ="+353 67639287828", Email ="alexcarson@sabio.il", Holidayhomeno ="1" }, 
                new Owner { Firstname = "Alonso", Surname = "Meredith",   Address1 =" 12 avenue Felix Faure", Address2 ="Nice", Contactno ="+353 32 6726539", Email ="alonso@orange.fr", Holidayhomeno ="60" },  
                new Owner { Firstname  = "Anand",   Surname = "Arturo",  Address1 =" 41 Gurtelstrasse", Address2 ="Berlin", Contactno ="+353 1928828", Email ="andart@o2.eu", Holidayhomeno ="901" },  
                new Owner { Firstname  = "Barzdukas",    Surname = "Gytis",  Address1 =" Ul. Przy Rondzie 2", Address2 ="Krakow", Contactno ="+353 768 1928828", Email ="barz@jujt.pl", Holidayhomeno ="6321" }, 
                new Owner { Firstname  = "Li",      Surname = "Yan", Address1 =" 65 Dozsa Gyorgy Ut", Address2 ="1134 Budapest", Contactno ="+353 76 8776628", Email ="yan@hotmail.com", Holidayhomeno ="01191" }, 
                new Owner { Firstname  = "Peggy",    Surname = "Juan", Address1 =" Plaza del Conde de Casal 6", Address2 ="Barcelona", Contactno ="+353 8768828", Email ="juan@hotmail.com", Holidayhomeno ="7631" },  
                new Owner { Firstname  = "Laura",    Surname = "Norman", Address1 =" Calle Loop de Vega 49", Address2 ="Madrid", Contactno ="+353 9881928828", Email ="laura@tiscali.co.uk", Holidayhomeno ="47651" },  
                new Owner { Firstname  = "Nino",     Surname = "Olivetto", Address1 =" 63 Via Piemonte", Address2 ="Rome", Contactno ="+353 87361928828", Email ="olivetto@lambda.il", Holidayhomeno ="87471" } 
            };
            owners.ForEach(s => context.Owners.Add(s));
            context.SaveChanges();

    



            var holidayhomes = new List<Holidayhome> 
            { 
                new Holidayhome { location = "~/Content/themes/base/images/pool.jpg", address1 = "1 Costa", address2 = "Valencia", country = "Spain", email ="maria@o2.i2", contactno ="+ 353 1928828", amenities ="Swimming pool, Golf, Tennis, Spa" },
                new Holidayhome { location = "~/Content/themes/base/images/family.jpg", address1 = "14 Rue De Pierre", address2 = "Biot" ,  country = "France", email ="pierre@orange.fr", contactno ="+353 44 876554434", amenities ="Gym, Spa, Squah Corts, Tennis, Swimming Pool" },
                new Holidayhome { location = "", address1 = "114 Peter Street", address2 = "Dublin 2" ,  country = "Ireland", email ="sean@eircom.net", contactno ="01 287828", amenities ="Shops, Sport Centre, Cafe, Restaurants" },
                new Holidayhome { location = "~/Content/themes/base/images/sunset.jpg", address1 = "674 Von Struss", address2 = "Berlin" ,  country = "Germany", email ="han@orange.eu", contactno ="+353 7630987", amenities ="Sport Centre, Restaurants" },
                new Holidayhome { location = "~/Content/themes/base/images/patio.jpg", address1 = "114 Torquay Road", address2 = "Manchester" ,  country = "United Kingdom", email ="Sebsean@live.com", contactno ="+53 98 765309", amenities ="Shops, Spa" },
                new Holidayhome { location = "~/Content/themes/base/images/sittingroom.jpg", address1 = "Calle De Gyogt", address2 = "Amsterdam" ,  country = "Holland", email ="monaurd@siemens.sp", contactno ="+353 9876223", amenities ="Sport Centre, Golf, Cafe, Restaurants" }


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
        } */



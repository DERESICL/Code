using System;
using System.Collections.Generic;




//Add the following eight properties to the Owners class:
namespace BookEasy.Models
{
    public class Owner
    {

        public int OwnerID { get; set; }
  
        public string Firstname { get; set; }

        public string Surname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Email { get; set; }
        public string Contactno { get; set; }
        public string Holidayhomeno { get; set; }
        public virtual ICollection<Subscribe> Subscribes { get; set; } 

    }
}
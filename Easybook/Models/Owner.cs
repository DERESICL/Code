using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;



//Add the following eight properties to the Owners class:
namespace Easybook.Models
{
    public class Owner
    {

        public int OwnerID { get; set; }
        [Required(ErrorMessage = "First Name is required")] 
        public string Firstname { get; set; }

        public string Surname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Email { get; set; }
        public string Contactno { get; set; }
        public string HolidayhomeID { get; set; }


    }
}
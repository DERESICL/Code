using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;



//Add the following seven properties to the Customer class:
namespace Easybook.Models
{
    [Table(Name = "HOLIDAYHOMES")]
    public class Holidayhome
    {
        [Column(IsPrimaryKey = true)]
        public int holidayhomeID { get; set; }
        [Column(Name = "LOCATION")]
        public string location { get; set; }
        [Column(Name = "ADDRESS1")]
        public string address1 { get; set; }
        [Column(Name = "ADDRESS2")]
        public string address2 { get; set; }
        [Column(Name = "COUNTRY")]
        public string country { get; set; }
        [Column(Name = "EMAIL")]
        public string email { get; set; }
        [Column(Name = "CONTACTNO")]
        public string contactno { get; set; }
        [Column(Name = "AMENITIES")]
        public string amenities { get; set; }

        public Holidayhome()
        {
        }
        public Holidayhome(String _location, String _address1, String _address2, String _country,String _email, String _contactno, String _amenities)
        {
            this.location = _location;
            this.address1 = _address1;
            this.address2 = _address2;
            this.country = _country;
            this.email = _email;
            this.contactno = _contactno;
            this.amenities = _amenities;
         
        }

    }
}




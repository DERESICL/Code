using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;
using System.ComponentModel.DataAnnotations;



//Add the following seven properties to the Customer class:
namespace BookEasy.Models
{

    public class Holidayhome
    {
        public int holidayhomeID { get; set; }

        public string location { get; set; }

        [Required(ErrorMessage = "Addrsss is required.")]
        [Display(Name = "address1")]
        [MaxLength(50)] 
        public string address1 { get; set; }

        public string address2 { get; set; }

        [Required(ErrorMessage = "Country is required.")]
        [Display(Name = "country")]
        [MaxLength(30)]
        public string country { get; set; }

        [Required(ErrorMessage = "Your email address is required.")]
        [Display(Name = "email")]
        [MaxLength(30)] 
        public string email { get; set; }

        [Required(ErrorMessage = "A phone number is required.")]
        [Display(Name = "contactno")]
        [MaxLength(30)]
        public string contactno { get; set; }

        public string amenities { get; set; }

        public string price { get; set; }
        public virtual ICollection<Subscribe> Subscribes { get; set; } 


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




using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;




//Add the following eight properties to the Owners class:
namespace BookEasy.Models
{
    public class Owner
    {

        public int OwnerID { get; set; }
        [Required(ErrorMessage = "First name is required.")]
        [Display(Name = "firstname")]
        [MaxLength(30)] 
        public string firstname { get; set; }
        
        [Required(ErrorMessage = "Last name is required.")]
        [Display(Name = "surname")]
        [MaxLength(30)] 
        public string surname { get; set; }

        [Required(ErrorMessage = "Addrsss is required.")]
        [Display(Name = "address1")]
        [MaxLength(50)] 
        public string address1 { get; set; }
        public string address2 { get; set; }

        [Required(ErrorMessage = "Country is required.")]
        [Display(Name = "country")]
        [MaxLength(50)] 
        public string country { get; set; }

        [Required(ErrorMessage = "Your email address is required.")]
        [Display(Name = "email")]
        [MaxLength(50)] 
        public string email { get; set; }

        [Required(ErrorMessage = "A phone number is required.")]
        [Display(Name = "contactno")]
        [MaxLength(50)]
        public string contactno { get; set; }
        public string holidayhomeno { get; set; }
        public virtual ICollection<Subscribe> Subscribes { get; set; } 

    }
}
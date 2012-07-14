using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;



//Add the following five properties to the Payment class:
namespace Easybook.Models
{
    public class Payment
    {


        public int Price { get; set; }
        public string Creditcardtype { get; set; }
        public string Number { get; set; }
        public string Expirydate { get; set; }
        public string CSV { get; set; }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace HolidayhomeApplication.Models
{
    [Table (Name="PERSON")] 
    public class Person
    {
        [Column(IsPrimaryKey = true)]
        int id;
        [Column(Name = "FIRSTNAME")]
        String firstname;
        [Column(Name = "SECONDNAME")]
        String secondname;
        [Column(Name = "ADDRESS1")]
        String address1;
        [Column(Name = "ADDRESS2")]
        String address2;
        [Column(Name = "COUNTRY")]
        String country;
        [Column(Name = "EMAIL")]
        String email;
        [Column(Name = "TELEPHONE")]
        int telephone;


        public Person(String _firstname, String _secondname, String _email, int _telephone)
        {
            this.firstname = _firstname;
            this.secondname = _secondname;
            this.email = _email;
            this.telephone = _telephone;
        }






    }
}
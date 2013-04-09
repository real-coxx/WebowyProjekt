using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Notowania.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String PhoneNumber { get; set; }
        public String Login { get; set; }
        //public String PasswordMD5 { get; set; }
        //public String PasswordSALT { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String PostalCode { get; set; }
        public bool isAdmin { get; set; }
        public virtual ICollection<MyValue> MyValues { get; set; }
    }
}
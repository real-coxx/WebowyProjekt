using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Notowania.Models
{
    public class Notification
    {
        [Key]
        public int NotificationID { get; set; }
        public String Title { get; set; }
        public System.Nullable<decimal> BottomPriceLimit { get; set; }
        public System.Nullable<decimal> UpperPriceLimit { get; set; }
        public bool isSMSType { get; set; }
        public bool isEmailType { get; set; }
    }
}
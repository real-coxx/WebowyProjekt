using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Notowania.Models
{
    public class MyValue
    {
        [Key]
        public int MyValueID { get; set; }
        public DateTime AdditionTime { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
    }
}
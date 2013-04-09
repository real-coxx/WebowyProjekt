using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Notowania.Models
{
    public class Value
    {
        [Key]
        public int ValueID { get; set; }
        public String Name { get; set; }
        public int? Category { get; set; }
        [ForeignKey("Category")]
        public virtual Category CategoryID { get; set; }
    }
}
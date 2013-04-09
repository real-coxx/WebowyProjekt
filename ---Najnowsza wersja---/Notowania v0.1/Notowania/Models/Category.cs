using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Notowania.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public String Name { get; set; }
        public int? Parent { get; set; }
        [ForeignKey("Parent")]
        public virtual Category ParentID { get; set; }
    }
}
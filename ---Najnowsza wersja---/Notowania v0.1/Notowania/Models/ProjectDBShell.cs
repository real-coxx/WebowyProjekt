using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Notowania.Models
{
    public class ProjectDBShell : DbContext 
    {
        public DbSet<User> User { get; set; }
        public DbSet<Value> Value { get; set; }
        public DbSet<Notification> Notification { get; set; }
        public DbSet<MyValue> MyValue { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
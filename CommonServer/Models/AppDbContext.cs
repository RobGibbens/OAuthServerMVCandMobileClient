using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApiOauth.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("DefaultConnection")
        {
        }
        
        public System.Data.Entity.DbSet<MVCOauthProject.Models.Customer> Customers { get; set; }
    }
}
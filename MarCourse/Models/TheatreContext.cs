using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MarCourse.Models
{
    public class TheatreContext : DbContext
    {
        public TheatreContext() : base("ProductConnection")
        {

        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<MembershipType> MembershipTypes { get; set; }
    }
}
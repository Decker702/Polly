using Polly.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Polly.DAL
{
    public class PollyContext : DbContext
    {
        public PollyContext() : base("PollyContext")
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<Polly.Models.Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<Polly.Models.Department> Departments { get; set; }

        public System.Data.Entity.DbSet<Polly.Models.Assignment> Assignments { get; set; }
    }
}
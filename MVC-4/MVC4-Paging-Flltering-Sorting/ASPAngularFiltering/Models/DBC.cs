using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ASPAngularFiltering.Models
{
    public class DBC : DbContext
    {
   
        public DbSet<Employee> Employees { get; set; }


        public DBC()
            : base("name=DefaultConnection")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();

        }
    }

    public class DbInit
    {
        public void CreateDatabase()
        {
            Database.SetInitializer<DBC>(null);
        }
    }
}
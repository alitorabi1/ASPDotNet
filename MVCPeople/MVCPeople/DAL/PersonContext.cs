using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MVCPeople.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MVCPeople.DAL
{
    public class PersonContext : DbContext
    {
        public PersonContext() { }
        public DbSet<Person> People { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
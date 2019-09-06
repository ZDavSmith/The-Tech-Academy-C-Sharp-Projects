using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityMVC.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace UniversityMVC.DAL
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("SchoolContext") //The name of the connection string in the Web.Config is passed to this constructor
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet <Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //prevents table names from being plural. The table names will all be singular. 
        }
    }
}
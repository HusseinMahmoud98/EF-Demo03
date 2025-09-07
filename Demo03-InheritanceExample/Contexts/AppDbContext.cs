using Demo03_InheritanceExample.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03_InheritanceExample.Contexts
{
    internal class AppDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ////TPH
            //modelBuilder.Entity<FullTimeEmployee>().HasBaseType<Employee>();
            //modelBuilder.Entity<PartTimeEmployee>().HasBaseType<Employee>();

            ////TPC
            //modelBuilder.Entity<Employee>().ToTable(nameof(Employee));
            //modelBuilder.Entity<FullTimeEmployee>().ToTable(nameof(FullTimeEmployee));
            //modelBuilder.Entity<PartTimeEmployee>().ToTable(nameof(PartTimeEmployee));
        }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = EF-Demo03-InheritanceExample; Trusted_Connection=True; TrustServerCertificate=True;");

        }

        //public DbSet<Employee> Employees { get; set; }
        public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }

    }
}

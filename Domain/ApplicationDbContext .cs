using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SPA.Domain.Entity;

namespace SPA.Domain
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Operator> Operators { get; set; }
        public DbSet<TypeNumber> TypeNumbers { get; set; }
        public DbSet<Number> Numbers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Employee> Employees { get; set; }
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder )
        {
            if ( !optionsBuilder.IsConfigured ) {
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TypeNumber>().HasData(
                new TypeNumber { Id = 1, Name = "Celular", Archived = false, Created =  DateTime.Now },
                new TypeNumber { Id = 2, Name = "Convencional", Archived = false, Created = DateTime.Now }
                );
            modelBuilder.Entity<Operator>().HasData(
                new Operator { Id = 1, Name = "Claro", Archived = false, Created = DateTime.Now },
                new Operator { Id = 2, Name = "Tigo", Archived = false, Created = DateTime.Now }
                );
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Administrador" },
                new Role { Id = 2, Name = "Supervisor" },
                new Role { Id = 3, Name = "Vendedor" }
                );
        }
    }
}

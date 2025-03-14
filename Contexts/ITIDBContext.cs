using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Session01Assignment.Entities;
using Session03Assignment.Confiugrations;
using Session03Assignment.Entities;


namespace Session01Assignment.Contexts
{
    internal class ITIDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; DataBase = ITIEFAssignment3; Trusted_Connection = True; TrustServerCertificate=true");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
        }
        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Topic> Topic { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
    }
}

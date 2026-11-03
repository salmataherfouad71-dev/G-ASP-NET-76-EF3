using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment._18.Models;
using System.Reflection;

namespace Assignment._18
{
    public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=EventHub; Trusted_Connection=True; TrustServerCertificate=True");
        }
        public DbSet<Category> Categories { set; get; }
        public DbSet<Course> Courses{ set; get; }
        public DbSet<Enrollment> Enrollments{ set; get; }
        public DbSet<Instructor> Instructors{ set; get; }
        public DbSet<Student>Students{ set; get; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

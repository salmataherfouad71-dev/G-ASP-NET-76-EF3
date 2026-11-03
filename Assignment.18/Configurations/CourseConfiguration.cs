using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment._18.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment._18.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.Property(c=>c.Title)
                   .HasColumnType("varchar(100)");
            builder.Property(c => c.Description)
                   .IsRequired(false)
                   .HasColumnType("varchar(100)");
            builder.Property(c=>c.Price)
                   .HasColumnType("decimal(18,2)");
            builder.Property(c => c.Level)
                   .HasColumnType("varchar(20)");
            builder.HasData(new Course[]
            {
                new Course 
                {
                    Id=1,Title="ASP-NET-G01",Price=8000,Level=CourseLevel.Beginner,
                    Flag=true,InstructorId=1,CategoryId= 4
                },
                new Course
                {
                    Id=2,Title="ASP-NET-G02",Price=8000,Level=CourseLevel.Intermediate,
                    Flag=false,InstructorId=1,CategoryId=4
                },
                new Course
                {
                    Id=3,Title="NODE-JS-G01",Price=8000,Level=CourseLevel.Beginner,
                    Flag=true,InstructorId=2,CategoryId=5
                },
                new Course
                {
                    Id=4,Title="NODE-JS-G02",Price=8000,Level=CourseLevel.Intermediate,
                    Flag=false,InstructorId=2,CategoryId=5
                },
                new Course
                {
                    Id=5,Title="REACT-G01",Price=8000,Level=CourseLevel.Beginner,
                    Flag=true,InstructorId=3,CategoryId=6
                },
                new Course
                {
                    Id=6,Title="ANGULAR-G01",Price=8000,Level=CourseLevel.Advanced,
                    Flag=true,InstructorId=3,CategoryId=7
                },
            });
        }
    }
}

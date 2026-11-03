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
        }
    }
}

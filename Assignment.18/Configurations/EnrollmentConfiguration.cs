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
    public class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            builder.HasKey(e => new{ e.StudentId,e.CourseId});
            builder.Property(e => e.ProgressPrecentage)
                   .HasColumnType("decimal(5,2)");
            builder.Property(e => e.Status)
                   .HasColumnType("varchar(20)");
            builder.Property(e => e.FinalGrade)
                   .HasColumnType("decimal(10,2)")
                   .IsRequired(false);
        }
    }
}

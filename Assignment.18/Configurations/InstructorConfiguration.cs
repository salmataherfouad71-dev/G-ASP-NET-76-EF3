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
    public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.Property(i=>i.FullName)
                   .HasColumnType("varchar(200)");
            builder.Property(i => i.EmailAddress)
                   .HasColumnType("varchar(200)");
            builder.Property(i => i.Bio)
                   .IsRequired(false);
            builder.Property(i => i.JoinedDate)
                   .HasDefaultValueSql("GETDATE()");
        }
    }
}

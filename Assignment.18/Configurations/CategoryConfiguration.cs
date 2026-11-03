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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(c => c.Description)
                   .IsRequired(false)
                   .HasColumnType("varchar(200)");
            builder.Property(c => c.ParentId).IsRequired(false);
            builder.HasOne(c => c.Parent)
                   .WithMany(c => c.SubCategories)
                   .HasForeignKey(c => c.ParentId)
                   .OnDelete(DeleteBehavior.NoAction);
            builder.Property(c => c.Name)
                   .HasColumnType("varchar(100)");
            builder.HasData(new Category[]
                {
                    new Category { Id = 1, Name = "Programming"},
                    new Category { Id = 2, Name = "Back-End" , ParentId = 1},
                    new Category { Id = 3, Name = "Front-End" , ParentId = 1},
                    new Category { Id = 4, Name = "ASP.NET" , ParentId = 2},
                    new Category { Id = 5, Name = "Node.js" , ParentId = 2},
                    new Category { Id = 6, Name = "React" , ParentId = 3},
                    new Category { Id = 7, Name = "Angular" , ParentId = 3},
                });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment._18.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment._18.Services
{
    public static class BulkOperations
    {
        public static void UpdatePrice(AppDbContext context,CourseLevel level)
        {
            Console.WriteLine("Operation: Update Price");
            int count = context.Courses.Where(e => e.Flag == true && e.Level == level)
                             .ExecuteUpdate(
                                                c=>c.SetProperty(c=>c.Price,c=>c.Price*1.1m)
                                            );
            Console.WriteLine($"Chnaged Courses:{count}");
            Console.WriteLine("-----------------------------");
            context.SaveChanges();
        }
        public static void DeleteEnrollment(AppDbContext context)
        {
            Console.WriteLine("Operation: Delete Enrollments");
            int count = context.Enrollments.Where(e => e.Status == EnrollmentStatus.Dropped)
                                         .ExecuteDelete();
            Console.WriteLine($"Deleted enrollments:{count}");
            Console.WriteLine("-----------------------------");
            context.SaveChanges();
        }
    }
}

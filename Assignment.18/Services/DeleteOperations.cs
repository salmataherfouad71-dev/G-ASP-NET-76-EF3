using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Assignment._18.Services
{
    public static class DeleteOperations
    {
        public static void Unenroll(AppDbContext context,int studentId,int courseId)
        {
            Console.WriteLine("Operation: Unenroll");
            var enrollment=context.Enrollments.FirstOrDefault(e=>e.StudentId==studentId&&e.CourseId==courseId);
            if (enrollment==null)
            {
                Console.WriteLine("Enrollment is not found!");
                return;
            }
            context.Remove(enrollment);
            Console.WriteLine("-----------------------------");
            context.SaveChanges();
        }
        public static void DeleteCategory(AppDbContext context,int categoryId)
        {
            Console.WriteLine("Operation: Delete a Category");
            var category=context.Categories.FirstOrDefault(c=>c.Id==categoryId);
            if (category==null)
            {
                Console.WriteLine("Category is not found!");
                return;
            }
            //unsafe
            try
            {
                context.Remove(category);
                context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine("Cannot remove a parent category!");
                Console.WriteLine(ex);
                context.Entry(category).State = EntityState.Unchanged;
            }
            //safe
            bool hasSubCategories = context.Categories.Any(c => c.ParentId==categoryId);
            if (hasSubCategories==true)
            {
                Console.WriteLine("Cannot remove a parent category!");
                return;
            }
            context.Remove(category);
            Console.WriteLine("-----------------------------");
            context.SaveChanges();
        }
        public static void DeleteCourse (AppDbContext context,int courseId)
        {
            Console.WriteLine("Operation: Delete a Course");
            var course=context.Courses.FirstOrDefault(c => c.Id == courseId);
            if (course == null)
            {
                Console.WriteLine("Course is not found!");
                return;
            }
            int before = context.Enrollments.Count(e=>e.CourseId==courseId);
            context.Remove(course);
            int after = context.Enrollments.Count(e => e.CourseId == courseId);
            Console.WriteLine($"Number of Enrollments before deleting the course:{before}");
            Console.WriteLine($"Number of Enrollments after deleting the course:{after}");
            Console.WriteLine("-----------------------------");
            context.SaveChanges();
            //all enrollment was deleted because the foreign key relationship is cascade by default.
        }
    }
}

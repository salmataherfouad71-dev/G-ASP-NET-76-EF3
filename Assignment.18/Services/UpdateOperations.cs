using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment._18.Models;

namespace Assignment._18.Services
{
    public static class UpdateOperations
    {
        public static void ChangePrice(AppDbContext context, int courseId, decimal newPrice)
        {
            Console.WriteLine("Operation: Change a Price");
            var course=context.Courses.FirstOrDefault(c=>c.Id==courseId);
            if (course == null)
            {
                Console.WriteLine("Course is not found!");
                return;
            }
            course.Price=newPrice;
            Console.WriteLine("-----------------------------");
            context.SaveChanges();
        }
        public static void UpdateProgress(AppDbContext context, int studentId, int courseId)
        {
            Console.WriteLine("Operation: Update Progress");
            var enrollment = context.Enrollments.FirstOrDefault(e=>e.StudentId==studentId&&e.CourseId==courseId);
            if (enrollment == null)
            {
                Console.WriteLine("Enrollment is not found!");
                return;
            }
            enrollment.ProgressPrecentage =100;
            enrollment.Status = EnrollmentStatus.Completed;
            Console.WriteLine("-----------------------------");
            context.SaveChanges();
        }
        public static void PublishCourse(AppDbContext context, int id)
        {
            Console.WriteLine("Operation: Publish a Course");
            var course=context.Courses.FirstOrDefault(c=>c.Id==id);
            if (course == null)
            {
                Console.WriteLine("Course is not found!");
                return;
            }
            course.Flag=true;
            course.PublishedDate=DateTime.Now; 
            Console.WriteLine("-----------------------------");
            context.SaveChanges();
        }
    }
}

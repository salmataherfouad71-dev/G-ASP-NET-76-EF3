using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment._18.Models;

namespace Assignment._18.Services
{
    public static class CreateOperatinos
    {
        public static void AddInstructor(AppDbContext context, string name, string email)
        {
            Console.WriteLine("Operation: Add Instructor");
            var instructor = new Instructor { FullName = name, EmailAddress = email };
            context.Instructors.Add(instructor);
            context.SaveChanges();
            Console.WriteLine($"Instructor Name: {instructor.FullName}\nGenerated Id:{instructor.Id}");
            Console.WriteLine("-----------------------------");
        }
        public static void AddCourse(AppDbContext context, string title, decimal price, CourseLevel level, bool flag, int instructorId, int categoryId)
        {
            Console.WriteLine("Operation: Add Course");
            if (!(context.Instructors.Any(i => i.Id == instructorId)))
            {
                Console.WriteLine("There is no instructor with this Id!");
                return;
            }
            if (!(context.Categories.Any(c => c.Id == categoryId)))
            {
                Console.WriteLine("There is no category with this Id!");
                return;
            }
            var course = new Course
            {
                Title = title,
                Price = price,
                Level = level,
                Flag = flag,
                InstructorId = instructorId,
                CategoryId = categoryId
            };
            context.Courses.Add(course);
            context.SaveChanges();
            Console.WriteLine("Course is added successfully!");
            Console.WriteLine("-----------------------------");
        }
        public static void AddSeveralStudents(AppDbContext context, List<Student> students)
        {
            Console.WriteLine("Operation: Add Several Students");
            context.Students.AddRange(students);
            context.SaveChanges();
            var studentsIds = context.Students.Select(s => new { s.Id, s.FullName }).ToList();
            foreach (var s in students)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("-----------------------------");
        }
        public static void EnrollStudent(AppDbContext context, int studentId, int courseId, decimal progress, EnrollmentStatus status)
        {
            Console.WriteLine("Operation: Enroll Students");
            if (!context.Students.Any(s => s.Id == studentId))
            {
                Console.WriteLine("There is no student with this Id!");
                return;
            }
            if (!context.Courses.Any(c => c.Id == courseId))
            {
                Console.WriteLine("There is no course with this Id!");
                return;
            }
            if (context.Courses.FirstOrDefault(c => c.Id == courseId).Flag == false)
            {
                Console.WriteLine("The course is not published!");
                return;
            }
            if (context.Enrollments.Any(e => e.StudentId == studentId && e.CourseId == courseId))
            {
                Console.WriteLine("Student is already enrolled in this course!");
                return;
            }
            context.Enrollments.Add(new Enrollment { StudentId = studentId, CourseId = courseId, ProgressPrecentage = progress, Status = status });
            context.SaveChanges();
            Console.WriteLine("Enrollment done successfully!");
            Console.WriteLine("-----------------------------");
        }
    }
}

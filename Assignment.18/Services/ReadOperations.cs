using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment._18.Services
{
    public static class ReadOperations
    {
        public static void FindCourse(AppDbContext context,int id,string title)
        {
            Console.WriteLine("Operation: Find a Course");
            var courseById = context.Courses.Find(id);
            if (courseById == null)
            {
                Console.WriteLine("There is no course with this Id!");
            }
            else 
            {
                Console.WriteLine($"Course found [{id}]: {courseById.Title}");
            }
            Console.WriteLine("-----------------------------");
            var courseByTitle=context.Courses.FirstOrDefault(c=>c.Title==title);
            if (courseByTitle == null)
            {
                Console.WriteLine("There is no course with this title!");
            }
            else
            {
                Console.WriteLine($"Course found [{title}]: {courseByTitle.Id}");
            }
            Console.WriteLine("-----------------------------");
        }
        public static void FilterCourses(AppDbContext context, decimal minPrice, decimal maxPrice)
        {
            Console.WriteLine("Operation: Filter Courses");
            var filter = context.Courses.Where(c => c.Price >= minPrice && c.Price <= maxPrice)
                                        .OrderByDescending(c => c.Price)
                                        .Select(c=>new { c.Title,c.Level,c.Price});
            if (!filter.Any())
            {
                Console.WriteLine("There is no course!");
            }
            else
            {
                foreach (var f in filter)
                {
                    Console.WriteLine(f);
                }
            }
            Console.WriteLine("-----------------------------");
        }
        public static void SubCategories(AppDbContext context,int id)
        {
            Console.WriteLine("Operation: Find Sub Categories");
            var subCategories=context.Categories.Where(c => c.ParentId==id)
                                                .Select(c=>c.Name);
            Console.WriteLine("Direct sub-categories:");
            if (!subCategories.Any())
                Console.WriteLine("None");
            else
            {
                foreach (var sub in subCategories)
                {
                    Console.WriteLine(sub);
                }
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Top - level categories:");
            var topCategories = context.Categories.Where(c=>c.ParentId==null)
                                        .Select(c => c.Name);
            foreach (var top in topCategories)
            {
                Console.WriteLine(top);
            }
            Console.WriteLine("-----------------------------");
        }
        public static void CourseRoster(AppDbContext context,int courseId)
        {
            Console.WriteLine("Operation: Find Course Roster");

            Console.WriteLine("-----------------------------");
            if (context.Courses.FirstOrDefault(c => c.Id == courseId) == null)
            {
                Console.WriteLine("Course is not found!");
                return;
            }
            var students = context.Enrollments
                                 .Where(e => e.CourseId == courseId)
                                 .Select(e=>e.StudentId);
            var studentNames = context.Students
                                    .Where(s=>students.Contains(s.Id))
                                    .Select(s=>s.FullName);
            Console.WriteLine($"Number of students:{studentNames.Count()}");
            foreach (var student in studentNames)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("-----------------------------");
        }
    }
}

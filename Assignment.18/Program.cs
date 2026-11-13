using Microsoft.EntityFrameworkCore;
using Assignment._18.Models;
using Assignment._18.Services;

namespace Assignment._18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AppDbContext context = new AppDbContext();
            #region Seeding
            context.Database.Migrate();
            if (!context.Students.Any())
            {
                context.AddRange(new Student[]
                {
                    new Student {FullName="Noor Jaber",EmailAddress="Noor12@gmail.com",DateOfBirth=new DateTime(2000, 4, 16) },
                    new Student {FullName="Amira Zahran",EmailAddress="AmiraZ76@gmail.com",DateOfBirth=new DateTime(1999,6,3) },
                    new Student {FullName="Khalid Mansour",EmailAddress="Khalid09@gmail.com",DateOfBirth=new DateTime(2002,1,22) },
                    new Student {FullName="Yusuf Al-Masri",EmailAddress="Yusuf65@gmail.com",DateOfBirth=new DateTime(1998,12,12) },
                    new Student {FullName="Aisha Tawfiq",EmailAddress="Aisha44@gmail.com",DateOfBirth=new DateTime(2005,11,6) },
                });
                context.SaveChanges();
            }
            if (!context.Enrollments.Any())
            {
                context.AddRange(new Enrollment[]
                {
                    new Enrollment { StudentId=1,CourseId=1,ProgressPrecentage=50,Status=EnrollmentStatus.Active},
                    new Enrollment { StudentId=1,CourseId=5,ProgressPrecentage=30,Status=EnrollmentStatus.Dropped},
                    new Enrollment { StudentId=2,CourseId=3,ProgressPrecentage=70,Status=EnrollmentStatus.Active},
                    new Enrollment { StudentId=2,CourseId=6,ProgressPrecentage=100,Status=EnrollmentStatus.Completed,FinalGrade=80},
                    new Enrollment { StudentId=3,CourseId=1,ProgressPrecentage=50,Status=EnrollmentStatus.Active},
                    new Enrollment { StudentId=3,CourseId=3,ProgressPrecentage=70,Status=EnrollmentStatus.Active},
                    new Enrollment { StudentId=4,CourseId=5,ProgressPrecentage=30,Status=EnrollmentStatus.Dropped},
                    new Enrollment { StudentId=5,CourseId=6,ProgressPrecentage=100,Status=EnrollmentStatus.Completed,FinalGrade=65},
                });
                context.SaveChanges();
            }
            #endregion
            #region Create
            //CreateOperatinos.AddInstructor(context, "Malek Ahmad", "Malek99@gmail.com");
            //CreateOperatinos.AddCourse(context, "Mobile Application", 6000, CourseLevel.Intermediate, false, 1, 1);
            //CreateOperatinos.AddSeveralStudents(context, new List<Student>{
            //                                                                new Student { FullName = "Amr Jaber", EmailAddress = "Amr02@gmail.com", DateOfBirth = new DateTime(2003, 8, 16) },
            //                                                                new Student { FullName = "Sleem Mohammed", EmailAddress = "Sleem13@gmail.com", DateOfBirth = new DateTime(2000, 4, 9) }
            //                                                            });
            //CreateOperatinos.EnrollStudent(context, 5, 1, 10, EnrollmentStatus.Active);
            #endregion
            #region Read
            //ReadOperations.FindCourse(context,6,"ASP-NET-G01");
            //ReadOperations.FilterCourses(context, 6000, 7000);
            //ReadOperations.SubCategories(context,2);
            //ReadOperations.CourseRoster(context, 1);
            #endregion
            #region Update
            //UpdateOperations.ChangePrice(context, 1, 7500);
            //UpdateOperations.UpdateProgress(context,1,1);
            //UpdateOperations.PublishCourse(context, 1);
            #endregion
        }
    }
}

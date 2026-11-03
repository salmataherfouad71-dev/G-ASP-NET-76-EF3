using Microsoft.EntityFrameworkCore;
using Assignment._18.Models;

namespace Assignment._18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AppDbContext context = new AppDbContext();
            context.Database.Migrate();
            if (!context.Students.Any())
            {
                context.AddRange(new Student[] 
                { 
                    new Student {Id=1,FullName="Noor Jaber",EmailAddress="Noor12@gmail.com",DateOfBirth=new DateTime(2000, 4, 16) },
                    new Student {Id=2,FullName="Amira Zahran",EmailAddress="AmiraZ76@gmail.com",DateOfBirth=new DateTime(1999,6,3) },
                    new Student {Id=3,FullName="Khalid Mansour",EmailAddress="Khalid09@gmail.com",DateOfBirth=new DateTime(2002,1,22) },
                    new Student {Id=4,FullName="Yusuf Al-Masri",EmailAddress="Yusuf65@gmail.com",DateOfBirth=new DateTime(1998,12,12) },
                    new Student {Id=5,FullName="Aisha Tawfiq",EmailAddress="Aisha44@gmail.com",DateOfBirth=new DateTime(2005,11,6) },
                });
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
            }
        }
    }
}

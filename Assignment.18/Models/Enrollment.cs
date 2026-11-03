using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment._18.Models
{
    public class Enrollment
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public DateTime EnrollmentDate { set; get; }
        public decimal progressPercentage ;
        public decimal ProgressPrecentage
        {
            set 
            {
                if(value >=0 && value <=100)
                    progressPercentage = value;
            }
            get 
            {
                return progressPercentage; 
            } 
        }
        public EnrollmentStatus status;
        public EnrollmentStatus Status 
        {
            set
            {
                if (ProgressPrecentage == 100)
                    status = EnrollmentStatus.Completed;
                else
                    status = value;
            }
            get { return status; }
        }
        public decimal? finalGrade;
        public decimal? FinalGrade 
        {
            set
            { 
                if (Status== EnrollmentStatus.Completed)
                    finalGrade = value;
            }
            get { return finalGrade; }
        }
    }
}

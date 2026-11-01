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
        public int Id { get; set; }
        public DateTime EnrollmentDate { set; get; }
        public decimal ProgressPercentage { set; get; }
        public EnrollmentStatus Status { set; get; }
        public decimal? FinalGrade { set; get; }
    }
}

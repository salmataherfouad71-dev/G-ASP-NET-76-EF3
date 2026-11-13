using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Assignment._18.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { set; get; }
        public string EmailAddress { set; get; }
        public DateTime DateOfBirth { set; get; }
        public List<Enrollment> Enrollment { set; get; }
    }
}

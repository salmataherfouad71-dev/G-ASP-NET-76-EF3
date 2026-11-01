using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment._18.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { set; get; }
        public string? Description { set; get; }
        public decimal Price { set; get; }
        public CourseLevel Level { set; get; }
        public bool Flag { set; get; }
    }
}

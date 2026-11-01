using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment._18.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string FullName { set; get; }
        public string EmailAddress { set; get; }
        public string? Bio { set; get; }
        public DateTime JoinedDate { set; get; }
    }
}

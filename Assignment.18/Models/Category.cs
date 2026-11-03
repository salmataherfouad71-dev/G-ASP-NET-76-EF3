using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment._18.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { set; get; }
        public string? Description{ set; get; }
        public List<Course> Course { set; get; }
        public int? ParentId { get; set; }
        public Category? Parent { set; get; }
        public List<Category>? SubCategories { set; get; }
    }
}

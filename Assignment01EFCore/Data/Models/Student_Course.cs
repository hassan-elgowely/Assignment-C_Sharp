using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01EFCore.Data.Models
{
    internal class Student_Course
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public decimal Grade { get; set; }
    }
}

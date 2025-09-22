using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01EFCore.Data.Models
{
    internal class Course_Instructor
    {
        public int InstructorId { get; set; }
        public int CourseId { get; set; }
        public int Evaluate { get; set; }
    }
}

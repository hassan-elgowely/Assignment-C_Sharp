using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        [InverseProperty(nameof(Student.student_Courses))]
        public Student student { get; set; } = null!;

        [InverseProperty(nameof(Course.student_Courses))]
        public Course course { get; set; } = null!;
    }
}

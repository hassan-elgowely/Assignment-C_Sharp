using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01EFCore.Data.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Duration { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int TopId { get; set; }
        [InverseProperty(nameof(Student_Course.course))]
        public ICollection<Student_Course> student_Courses { get; set; } = new HashSet<Student_Course>();

        [InverseProperty(nameof(Topic.courses))]
        public Topic topic { get; set; } = null!;

        [InverseProperty(nameof(Course_Instructor.course))]
        public ICollection<Course_Instructor> instructors_course { get; set; } = new HashSet<Course_Instructor>();
    }
}

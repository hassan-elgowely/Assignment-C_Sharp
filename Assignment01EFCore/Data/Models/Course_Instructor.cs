using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        [InverseProperty(nameof(Course.instructors_course))]
        public Course course { get; set; } = null!;

        [InverseProperty(nameof(Instructor.course_Instructors))]
        public Instructor instructor { get; set; } = null!;
    }
}

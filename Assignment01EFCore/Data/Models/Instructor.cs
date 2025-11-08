using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01EFCore.Data.Models
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Bouns { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; } = null!;
        public decimal HourRate { get; set; }
        public int DeptId { get; set; }

        [InverseProperty(nameof(Course_Instructor.instructor))]
        public ICollection<Course_Instructor> course_Instructors { get; set; } = new HashSet<Course_Instructor>();

        [InverseProperty(nameof(Department.instructor))]
        public Department? department { get; set; }

        [InverseProperty(nameof(Department.instructors))]
        public Department departmentInclude { get; set; } = null!;
    }
}

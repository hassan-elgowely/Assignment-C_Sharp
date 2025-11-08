using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01EFCore.Data.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateOnly HiringDate { get; set; }
        public int InstructorId { get; set; }

        [InverseProperty(nameof(Student.department))]
        public ICollection<Student> students { get; set; } = new HashSet<Student>();

        [InverseProperty(nameof(Instructor.department))]
        public Instructor instructor { get; set; } = null!;

        [InverseProperty(nameof(Instructor.departmentInclude))]
        public ICollection<Instructor> instructors { get; set; } = new HashSet<Instructor>();
    }
}

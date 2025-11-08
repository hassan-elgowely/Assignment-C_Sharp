using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01EFCore.Data.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public int Age { get; set; }
        public int DeptId { get; set; }
        [InverseProperty(nameof(Student_Course.student))]
        public ICollection<Student_Course> student_Courses { get; set; } = new HashSet<Student_Course>();

        [InverseProperty(nameof(Department.students))]
        public Department department { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01EFCore.Data.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly HiringDate { get; set; }
        public int InstructorId { get; set; }
    }
}

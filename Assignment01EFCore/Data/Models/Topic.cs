using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01EFCore.Data.Models
{
    internal class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        [InverseProperty(nameof(Course.topic))]
        public ICollection<Course> courses { get; set; } = new HashSet<Course>();
    }
}

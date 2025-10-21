using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBLL.DTOS.DepartmentModule
{
    public class AddDepartmentDTO
    {
        [Required(ErrorMessage ="Code is Required !!")]
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateOnly DateCreatedOn { get; set; }
    }
}

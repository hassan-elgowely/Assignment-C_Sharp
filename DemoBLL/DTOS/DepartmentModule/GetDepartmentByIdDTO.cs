using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBLL.DTOS.DepartmentModule
{
    public class GetDepartmentByIdDTO
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public DateOnly? DateCreatedOn { get; set; } 
        public int ModifiedBy { get; set; }
        public DateOnly? DateModifiedOn { get; set; } 
        public bool IsDeleted { get; set; }
    }
}

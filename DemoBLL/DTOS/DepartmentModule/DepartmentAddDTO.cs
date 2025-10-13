using DemoDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBLL.DTOS.DepartmentModule
{
    public class DepartmentAddDTO
    {
        public string? Code { get; set; } = string.Empty;
        public string? Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateOnly DateCreatedOn { get; set; } 

    }
}

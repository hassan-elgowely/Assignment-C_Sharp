using DemoDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBLL.DTOS.DepartmentModule
{
    public class DepartmentGetAllDTO
    {
        public int DeptId { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateOnly DateofCreation { get; set; }

        // constructor mapping
        //public DepartmentGetAllDTO(Department department)
        //{
        //    DeptId = department.Id;
        //    Code = department.Code;
        //    Name = department.Name;
        //    Description = department.Description;
        //    DateofCreation = department.CreatedOn.HasValue ? DateOnly.FromDateTime(department.CreatedOn.Value) : default;
        //}
    }
}

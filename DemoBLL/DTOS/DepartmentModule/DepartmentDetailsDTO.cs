using DemoDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBLL.DTOS.DepartmentModule
{
    public class DepartmentDetailsDTO
    {
        public string? Code { get; set; } = string.Empty;
        public string? Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public DateOnly? DateCreatedOn { get; set; } // nullable ==> has default value
        public int ModifiedBy { get; set; }
        public DateOnly? DateModifiedOn { get; set; } // nullable ==> has default value
        public bool IsDeleted { get; set; }

        //public DepartmentDetailsDTO(Department d)
        //{
        //    Code = d.Code;
        //    Name = d.Name;
        //    Description = d.Description;
        //    Id = d.Id;
        //    CreatedBy = d.CreatedBy;
        //    DateCreatedOn = d.CreatedOn.HasValue ? DateOnly.FromDateTime(d.CreatedOn.Value) : default;
        //    ModifiedBy = d.ModifiedBy;
        //    DateModifiedOn = d.ModifiedOn.HasValue ? DateOnly.FromDateTime(d.ModifiedOn.Value) : default;
        //    IsDeleted = d.IsDeleted;
        //}
    }
}

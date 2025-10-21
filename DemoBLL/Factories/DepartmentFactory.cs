using DemoBLL.DTOS.DepartmentModule;
using DemoDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBLL.Factories
{
    public static class DepartmentFactory
    {
        public static GetAllllDepartmentDTO TOGetAllllDepartmentList(this Department d)
        {
            return new GetAllllDepartmentDTO()
            {
                ID = d.Id,
                Name = d.Name,
                Code = d.Code,
                Description = d.Description,
                DateOfCreation = d.CreatedOn.HasValue ? DateOnly.FromDateTime(d.CreatedOn.Value) : default
            };
        }
        public static GetDepartmentByIdDTO ToDepartmentDetails(this Department d)
        {
            return new GetDepartmentByIdDTO()
            {
                Id = d.Id,
                Name = d.Name,
                Code = d.Code,
                Description = d.Description,
                CreatedBy = d.CreatedBy,
                ModifiedBy = d.ModifiedBy,
                IsDeleted = d.IsDeleted,
                DateCreatedOn = d.CreatedOn.HasValue ? DateOnly.FromDateTime(d.CreatedOn.Value) : default,
                DateModifiedOn = d.ModifiedOn.HasValue ? DateOnly.FromDateTime(d.ModifiedOn.Value) : default,
            };
        }
        public static Department ToAddDepartment(this AddDepartmentDTO addDepartmentDTO)
        {
            return new Department()
            {
                Name = addDepartmentDTO.Name,
                Code = addDepartmentDTO.Code,
                Description = addDepartmentDTO.Description,
                CreatedOn = addDepartmentDTO.DateCreatedOn.ToDateTime(new TimeOnly())
            };
        }
        public static Department ToUpdateDepartment(this UpdateDepartmentDTO updateDepartmentDTO)
        {
            return new Department()
            {
                Id = updateDepartmentDTO.Id,
                Name = updateDepartmentDTO.Name,
                Code = updateDepartmentDTO.Code,
                Description = updateDepartmentDTO.Description,
                CreatedOn = updateDepartmentDTO.DateCreatedOn.ToDateTime(new TimeOnly())
            };
        }
    }
}

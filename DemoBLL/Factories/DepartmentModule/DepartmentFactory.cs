using DemoBLL.DTOS.DepartmentModule;
using DemoDAL.Model.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBLL.Factories.DepartmentModule
{
    public static class DepartmentFactory
    {
        public static GetAllDepartmentDTO ToGetAllDepartment(this Department department)
        {
            return new GetAllDepartmentDTO()
            {
                Id = department.Id,
                Code = department.Code,
                Name = department.Name,
                Description = department.Description,
                DateOfCreated = department.CreatedOn.HasValue ? DateOnly.FromDateTime(department.CreatedOn.Value) : default
            };
        }

        public static GetDepartmentDetailsDTO ToGetDepartmentDetails(this Department department)
        {
            return new GetDepartmentDetailsDTO()
            {
                Id = department.Id,
                Name = department.Name,
                Description = department.Description,
                Code = department.Code,
                ModifiedBy = department.ModifiedBy,
                CreatedBy = department.CreatedBy,
                IsDeleted = department.IsDeleted,
                DateCreatedOn = department.CreatedOn.HasValue ? DateOnly.FromDateTime(department.CreatedOn.Value) : default,
                DateModifiedOn = department.ModifiedOn.HasValue ? DateOnly.FromDateTime(department.ModifiedOn.Value) : default
            };
        }

        public static Department ToAddDepartment(this AddDepartmentDTO addDepartmentDTO)
        {
            return new Department()
            {
                Code = addDepartmentDTO.Code,
                Name = addDepartmentDTO.Name,
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
                Description = updateDepartmentDTO.Description,
                Code = updateDepartmentDTO.Code,
                CreatedOn = updateDepartmentDTO.DateCreatedOn.ToDateTime(new TimeOnly())
            };
        }
    }
}

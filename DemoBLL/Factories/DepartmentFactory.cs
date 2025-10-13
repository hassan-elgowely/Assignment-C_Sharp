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
        public static DepartmentGetAllDTO ToGetAllDepartmentDTO(this Department department)
        {
            return new DepartmentGetAllDTO()
            {
                DeptId = department.Id,
                Code = department.Code,
                Name = department.Name,
                Description = department.Description,
                DateofCreation = department.CreatedOn.HasValue ? DateOnly.FromDateTime(department.CreatedOn.Value) : default,
            };
        }
        public static DepartmentDetailsDTO ToGetDepartmentById(this Department d)
        {
            return new DepartmentDetailsDTO()
            {
                Code = d.Code,
                Name = d.Name,
                Description = d.Description,
                Id = d.Id,
                CreatedBy = d.CreatedBy,
                DateCreatedOn = d.CreatedOn.HasValue ? DateOnly.FromDateTime(d.CreatedOn.Value) : default,
                ModifiedBy = d.ModifiedBy,
                DateModifiedOn = d.ModifiedOn.HasValue ? DateOnly.FromDateTime(d.ModifiedOn.Value) : default,
                IsDeleted = d.IsDeleted
            };
        }
        public static Department ToAddDepartment(this DepartmentAddDTO departmentAddDTO)
        {
            return new Department()
            {
                Code = departmentAddDTO.Code,
                Name = departmentAddDTO.Name,
                Description = departmentAddDTO.Description,
                CreatedOn = departmentAddDTO.DateCreatedOn.ToDateTime(new TimeOnly())
            };
        }

        public static Department ToUpdateDepartment(this DepartmentUpdateDTO departmentUpdateDTO)
        {
            return new Department()
            {
                Id = departmentUpdateDTO.Id,
                Code = departmentUpdateDTO.Code,
                Name = departmentUpdateDTO.Name,
                Description = departmentUpdateDTO.Description,
                CreatedOn = departmentUpdateDTO.DateCreatedOn.ToDateTime(new TimeOnly())
            };
        }
    }
}

using DemoBLL.DTOS.DepartmentModule;
using DemoBLL.Factories;
using DemoBLL.Services.Interfaces;
using DemoDAL.Models;
using DemoDAL.Repositories.Classes;
using DemoDAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBLL.Services.Classes
{
    public class DepartmentService(IDepartmentRepository _departmentRepository) : IDepartmentService
    {
        public IEnumerable<DepartmentGetAllDTO> GetAllDepartment()
        {
            // Extension Method mapping
            return _departmentRepository.GetAll().Select(d => d.ToGetAllDepartmentDTO());


            // manual mapping
            //var departments = _departmentRepository.GetAll();
            //return departments.Select(p => new DepartmentGetAllDTO()
            //{
            //    DeptId = p.Id,
            //    Name = p.Name,
            //    Code = p.Code,
            //    Description = p.Description,
            //    DateofCreation = p.CreatedOn.HasValue ? DateOnly.FromDateTime(p.CreatedOn.Value) : default,
            //});

        }

        public DepartmentDetailsDTO? GetDepartmentById(int id)
        {
            // Extension Method mapping
            var department = _departmentRepository.GetById(id);
            return department is null ? null : department.ToGetDepartmentById();

            // manual mapping
            //var department = _departmentRepository.GetById(id);
            //return department is null ? null : new DepartmentDetailsDTO()
            //{
            //    Id = department.Id,
            //    Name = department.Name,
            //    Code = department.Code,
            //    Description = department.Description,
            //    CreatedBy = department.CreatedBy,
            //    ModifiedBy = department.ModifiedBy,
            //    IsDeleted = department.IsDeleted,
            //    DateCreatedOn = department.CreatedOn.HasValue ? DateOnly.FromDateTime(department.CreatedOn.Value) : null,
            //    DateModifiedOn = department.ModifiedOn.HasValue ? DateOnly.FromDateTime(department.ModifiedOn.Value) : null,
            //};
            //var department = _departmentRepository.GetById(id);
            //return department is null ? null : department.ToGetDepartmentById();

            // ctor mapping
            //var department = _departmentRepository.GetById(id);
            //return department is null ? null : new DepartmentDetailsDTO(department);
        }


        public int AddDepartment(DepartmentAddDTO departmentaddDto)
        {
            //Extension Mapping
            return _departmentRepository.Add(departmentaddDto.ToAddDepartment());

            // Manual Mapping
            //var department = new Department
            //{
            //    Code = departmentaddDto.Code,
            //    Name = departmentaddDto.Name,
            //    Description = departmentaddDto.Description,
            //    CreatedOn = departmentaddDto.DateCreatedOn.ToDateTime(new TimeOnly())
            //};
            //return _departmentRepository.Add(department);
        }

        public int UpdateDepartment(DepartmentUpdateDTO departmentUpdateDTO)
        {
            // Extension Methods Mapping
            return _departmentRepository.Update(departmentUpdateDTO.ToUpdateDepartment());

            // manual mapping
            //var department = new Department
            //{
            //    Id = departmentUpdateDTO.Id,
            //    Code = departmentUpdateDTO.Code,
            //    Name = departmentUpdateDTO.Name,
            //    Description = departmentUpdateDTO.Description,
            //    CreatedOn = departmentUpdateDTO.DateCreatedOn.ToDateTime(new TimeOnly())
            //};
            //return _departmentRepository.Update(department);
        }

        public bool DeleteDepartment(int id)
        {
            var department = _departmentRepository.GetById(id);
            if (department is null)
                return false;
            int numofdepartment = _departmentRepository.Delete(department);
            return numofdepartment > 0 ? true : false;
        }
    }
}

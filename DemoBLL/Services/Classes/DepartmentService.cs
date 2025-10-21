using DemoBLL.DTOS.DepartmentModule;
using DemoBLL.Factories;
using DemoBLL.Services.Interfaces;
using DemoDAL.Repositories.Classes;
using DemoDAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBLL.Services.Classes
{
    public class DepartmentService(IDepartmentRepository _departmentRepository) : IDepartmentService
    {
        public IEnumerable<GetAllllDepartmentDTO> GetAllllDepartment()
        {
            return _departmentRepository.GetAll().Select(d => d.TOGetAllllDepartmentList());

            //return _departmentRepository.GetAll().Select(p => new GetAllllDepartmentDTO
            //{
            //    ID = p.Id,
            //    Name = p.Name,
            //    Code = p.Code,
            //    Description = p.Description,
            //    DateOfCreation = p.CreatedOn.HasValue ? DateOnly.FromDateTime(p.CreatedOn.Value) : default
            //});
        }


        public GetDepartmentByIdDTO? GetDepartmentDetailsById(int id)
        {
            var department = _departmentRepository.GetById(id);
            return department is null ? null : department.ToDepartmentDetails();

            //return department is null ? null : new GetDepartmentByIdDTO()
            //{
            //    Id = department.Id,
            //    Name = department.Name,
            //    Code = department.Code,
            //    Description = department.Description,
            //    CreatedBy = department.CreatedBy,
            //    ModifiedBy = department.ModifiedBy,
            //    IsDeleted = department.IsDeleted,
            //    DateCreatedOn = department.CreatedOn.HasValue ? DateOnly.FromDateTime(department.CreatedOn.Value) : default,
            //    DateModifiedOn = department.ModifiedOn.HasValue ? DateOnly.FromDateTime(department.ModifiedOn.Value) : default,
            //};
        }
        public int AddDepartment(AddDepartmentDTO addDepartmentDTO)
        {
            return _departmentRepository.Add(addDepartmentDTO.ToAddDepartment());
        }


        public int UpdateDepartment(UpdateDepartmentDTO updateDepartmentDTO)
        {
            return _departmentRepository.Update(updateDepartmentDTO.ToUpdateDepartment());
        }


        public bool DeleteDepartment(int id)
        {
            var department = _departmentRepository.GetById(id);
            if (department is null)
                return false;
            int numoddept = _departmentRepository.Delete(department);
            return numoddept > 0 ? true : false;
        }
    }
}

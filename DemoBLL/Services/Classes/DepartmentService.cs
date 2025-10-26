using DemoBLL.DTOS.DepartmentModule;
using DemoBLL.Factories.DepartmentModule;
using DemoBLL.Services.Interfaces;
using DemoDAL.Model.Department;
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
        public IEnumerable<GetAllDepartmentDTO> GetAllDepartment()
        {
            return _departmentRepository.GetAll().Select(d => d.ToGetAllDepartment());
        }

        public GetDepartmentDetailsDTO? GetDepartmentDetails(int id)
        {
            var dept = _departmentRepository.GetById(id);
            return dept is null ? null : dept.ToGetDepartmentDetails();
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
            var dept = _departmentRepository.GetById(id);
            if (dept is null) return false;
            else
            {
                dept.IsDeleted = true;
                return _departmentRepository.Update(dept) > 0 ? true : false;
            }
        }
    }
}

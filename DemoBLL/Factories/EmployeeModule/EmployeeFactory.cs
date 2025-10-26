using DemoBLL.DTOS.DepartmentModule;
using DemoBLL.DTOS.EmployeeModule;
using DemoDAL.Model.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBLL.Factories.EmployeeModule
{
    public static class EmployeeFactory
    {
        public static GetAllEmployeeDTO ToGetAllEmployee(this Employee employee)
        {
            return new GetAllEmployeeDTO()
            {
                Id = employee.Id,
                Name = employee.Name,
                Age = employee.Age,
                Email = employee.Email,
                Salary = employee.Salary,
                IsActive = employee.IsActive,
                EmployeeType = employee.EmployeeType.ToString(),
                EmpGender = employee.Gender.ToString(),
            };
        }
        public static GetEmployeeDetailsDTO ToEmployeeDetails(this Employee employee)
        {
            return new GetEmployeeDetailsDTO()
            {
                Id = employee.Id,
                Name = employee.Name,
                Age = employee.Age,
                Address = employee.Address,
                Salary = employee.Salary,
                Email = employee.Email,
                PhoneNumber = employee.PhoneNumber,
                IsActive = employee.IsActive,
                HiringDate = DateOnly.FromDateTime(employee.HiringDate),
                CreatedBy = employee.CreatedBy,
                ModifiedBy = employee.ModifiedBy,
                CreatedOn = employee.CreatedOn,
                ModifiedOn = employee.ModifiedOn,
                EmployeeType = employee.EmployeeType.ToString(),
                Gender = employee.Gender.ToString()
            };
        }
        public static Employee ToAddEmployee(this AddEmployeeDTO addEmployeeDTO)
        {
            return new Employee()
            {
                Name = addEmployeeDTO.Name,
                Age = addEmployeeDTO.Age.HasValue ? addEmployeeDTO.Age.Value : default,
                Address = addEmployeeDTO.Address,
                Email = addEmployeeDTO.Email,
                IsActive = addEmployeeDTO.IsActive,
                Salary = addEmployeeDTO.Salary,
                PhoneNumber = addEmployeeDTO.PhoneNumber,
                HiringDate = addEmployeeDTO.HiringDate.ToDateTime(new TimeOnly()),
                EmployeeType = addEmployeeDTO.EmployeeType,
                Gender = addEmployeeDTO.Gender,
            };
        }
        public static Employee ToUpdateEmployee(this UpdateEmployeeDTO updateEmployeeDTO)
        {
            return new Employee()
            {
                Id = updateEmployeeDTO.Id,
                Name = updateEmployeeDTO.Name,
                Address = updateEmployeeDTO.Address,
                Age = updateEmployeeDTO.Age.HasValue ? updateEmployeeDTO.Age.Value : default,
                Email = updateEmployeeDTO.Email,
                PhoneNumber = updateEmployeeDTO.PhoneNumber,
                Salary = updateEmployeeDTO.Salary,
                HiringDate = updateEmployeeDTO.HiringDate.ToDateTime(new TimeOnly()),
                Gender = updateEmployeeDTO.Gender,
                EmployeeType = updateEmployeeDTO.EmployeeType,
                IsActive = updateEmployeeDTO.IsActive
            };
        }
    }
}

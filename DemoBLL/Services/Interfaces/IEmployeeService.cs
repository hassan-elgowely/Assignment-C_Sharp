using DemoBLL.DTOS.DepartmentModule;
using DemoBLL.DTOS.EmployeeModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBLL.Services.Interfaces
{
    public interface IEmployeeService
    {
        IEnumerable<GetAllEmployeeDTO> GetAllEmployees(bool withtracking = false);
        GetEmployeeDetailsDTO? GetEmployeeDetails(int id);
        int AddEmployee(AddEmployeeDTO addEmployeeDTO);
        int UpdateEmployee(UpdateEmployeeDTO updateEmployeeDTO);
        bool DeleteEmployee(int id);
    }
}

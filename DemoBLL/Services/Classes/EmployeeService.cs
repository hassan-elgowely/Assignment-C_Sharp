using AutoMapper;
using DemoBLL.DTOS.EmployeeModule;
using DemoBLL.Services.Interfaces;
using DemoDAL.Model.Employee;
using DemoDAL.Repositories.Interfaces;


namespace DemoBLL.Services.Classes
{
    public class EmployeeService(IEmployeeRepository _employeeRepository , IMapper _mapper) : IEmployeeService
    {
        public IEnumerable<GetAllEmployeeDTO> GetAllEmployees(bool withtracking = false)
        {
            // Auto Mapper
            var employees = _employeeRepository.GetAll();
            return _mapper.Map<IEnumerable<Employee>, IEnumerable<GetAllEmployeeDTO>>(employees);

            //Extension methods mapping
            //return _employeeRepository.GetAll().Select(E => E.ToGetAllEmployee());

            // manual mapping
            //return _employeeRepository.GetAll().Select(E => new GetAllEmployeeDTO()
            //{
            //    Id = E.Id,
            //    Name = E.Name,
            //    Age = E.Age,
            //    Email = E.Email,
            //    Salary = E.Salary,
            //    IsActive = E.IsActive,
            //    EmployeeType = E.EmployeeType.ToString(),
            //    Gender = E.Gender.ToString(),
            //});
        }

        public GetEmployeeDetailsDTO? GetEmployeeDetails(int id)
        {
            // Auto Mapper
            var emp = _employeeRepository.GetById(id);
            return (emp is null) ? null : _mapper.Map<Employee, GetEmployeeDetailsDTO>(emp);

            // Extension Method Mapping
            //var emp = _employeeRepository.GetById(id);
            //return emp is null ? null : emp.ToEmployeeDetails();

            // Manual Mapping
            //var employee = _employeeRepository.GetById(id);
            //return new GetEmployeeDetails()
            //{
            //    Id = employee.Id,
            //    Name = employee.Name,
            //    Age = employee.Age,
            //    Address = employee.Address,
            //    Salary = employee.Salary,
            //    Email = employee.Email,
            //    PhoneNumber = employee.PhoneNumber,
            //    IsActive = employee.IsActive,
            //    HiringDate = DateOnly.FromDateTime(employee.HiringDate),
            //    CreatedBy = employee.CreatedBy,
            //    ModifiedBy = employee.ModifiedBy,
            //    CreatedOn = employee.CreatedOn,
            //    ModifiedOn = employee.ModifiedOn,
            //    EmployeeType = employee.EmployeeType.ToString(),
            //    Gender = employee.Gender.ToString()
            //};
        }

        public int AddEmployee(AddEmployeeDTO addEmployeeDTO)
        {
            // Auto Mapper
            return _employeeRepository.Add(_mapper.Map<AddEmployeeDTO, Employee>(addEmployeeDTO));

            // Extension Method Mapping
            //return _employeeRepository.Add(addEmployeeDTO.ToAddEmployee());

            // manual mapping
            //return _employeeRepository.Add( new Employee()
            //{
            //    Name = addEmployeeDTO.Name,
            //    Age = addEmployeeDTO.Age.HasValue ? addEmployeeDTO.Age.Value : default,
            //    Address = addEmployeeDTO.Address,
            //    Email = addEmployeeDTO.Email,
            //    IsActive = addEmployeeDTO.IsActive,
            //    Salary = addEmployeeDTO.Salary,
            //    PhoneNumber = addEmployeeDTO.PhoneNumber,
            //    HiringDate = addEmployeeDTO.HiringDate.ToDateTime(new TimeOnly()),
            //    EmployeeType = addEmployeeDTO.EmployeeType,
            //    Gender = addEmployeeDTO.Gender,
            //});
        }

        public int UpdateEmployee(UpdateEmployeeDTO updateEmployeeDTO)
        {
            // Auto Mapper
            return _employeeRepository.Update(_mapper.Map<UpdateEmployeeDTO, Employee>(updateEmployeeDTO));

            // extension method mapping
            //return _employeeRepository.Update(updateEmployeeDTO.ToUpdateEmployee());

            // manual mapping
            //return _employeeRepository.Update(new Employee()
            //{
            //    Id = updateEmployeeDTO.Id,
            //    Name = updateEmployeeDTO.Name,
            //    Address = updateEmployeeDTO.Address,
            //    Age = updateEmployeeDTO.Age.HasValue ? updateEmployeeDTO.Age.Value : default,
            //    Email = updateEmployeeDTO.Email,
            //    PhoneNumber = updateEmployeeDTO.PhoneNumber,
            //    Salary = updateEmployeeDTO.Salary,
            //    HiringDate = updateEmployeeDTO.HiringDate.ToDateTime(new TimeOnly()),
            //    Gender = updateEmployeeDTO.Gender,
            //    EmployeeType = updateEmployeeDTO.EmployeeType,
            //    IsActive = updateEmployeeDTO.IsActive
            //});
        }

        public bool DeleteEmployee(int id)
        {
            var emp = _employeeRepository.GetById(id);
            if(emp is null) return false;
            else
            {
                emp.IsDeleted = true;
                return _employeeRepository.Update(emp) > 0 ? true : false;
            }
        }
    }
}

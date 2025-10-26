using DemoBLL.DTOS.EmployeeModule;
using DemoBLL.Services.Interfaces;
using DemoDAL.Model.Employee;
using DemoDAL.Model.Shared;
using DemoPL.ViewModels.EmployeeVM;
using Microsoft.AspNetCore.Mvc;

namespace DemoPL.Controllers
{
    public class EmployeeController(IEmployeeService _employeeService, ILogger<EmployeeController> _logger, IWebHostEnvironment _environment) : Controller
    {
        #region Index
        public IActionResult Index()
        {
            var Employees = _employeeService.GetAllEmployees();
            return View(Employees);
        }
        #endregion

        #region Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(AddEmployeeDTO addEmployeeDTO)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var res = _employeeService.AddEmployee(addEmployeeDTO);
                    if (res > 0) return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    if (_environment.IsDevelopment())
                    {
                        //_logger.LogError("Employee Can't be created");
                    }
                    else
                    {
                        //_logger.LogError("Employee Can't be created");
                        return View("Error", ex);
                    }
                }
            }
            return View(addEmployeeDTO);
        }
        #endregion

        #region Details
        public IActionResult Details(int? id, GetEmployeeDetailsDTO getEmployeeDetails)
        {
            if (!id.HasValue) return BadRequest();
            var emp = _employeeService.GetEmployeeDetails(id.Value);
            if (emp is null) return NotFound();
            return View(emp);
        }
        #endregion

        //#region Edit (VM)
        //[HttpGet]
        //public IActionResult Edit(int? id)
        //{
        //    if (!id.HasValue) return BadRequest();
        //    var emp = _employeeService.GetEmployeeDetails(id.Value);
        //    if (emp is null) return NotFound();
        //    var empVm = new EmployeeUpdateVM()
        //    {
        //        Id = id.Value,
        //        Name = emp.Name,
        //        Address = emp.Address,
        //        Salary = emp.Salary,
        //        Age = emp.Age,
        //        Email = emp.Email,
        //        PhoneNumber = emp.PhoneNumber,
        //        HiringDate = emp.HiringDate,
        //        IsActive = emp.IsActive,
        //        //EmployeeType = (EmployeeType)Enum.Parse(typeof(EmployeeType), emp.EmployeeType),
        //        EmployeeType = Enum.Parse<EmployeeType>(emp.EmployeeType),
        //        //Gender = (Gender)Enum.Parse(typeof(Gender), emp.Gender)
        //        Gender = Enum.Parse<Gender>(emp.Gender)
        //    };
        //    return View(empVm);
        //}
        //[HttpPost]
        //public IActionResult Edit([FromRoute] int id, EmployeeUpdateVM employeeUpdateVM)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            var empupdate = new UpdateEmployeeDTO()
        //            {
        //                Id = id,
        //                Name = employeeUpdateVM.Name,
        //                Address = employeeUpdateVM.Address,
        //                Age = employeeUpdateVM.Age.HasValue ? employeeUpdateVM.Age.Value : default,
        //                PhoneNumber = employeeUpdateVM.PhoneNumber,
        //                Email = employeeUpdateVM.Email,
        //                Salary = employeeUpdateVM.Salary,
        //                HiringDate = employeeUpdateVM.HiringDate,
        //                IsActive = employeeUpdateVM.IsActive,
        //                EmployeeType = employeeUpdateVM.EmployeeType,
        //                Gender = employeeUpdateVM.Gender
        //            };
        //            int res = _employeeService.UpdateEmployee(empupdate);
        //            if (res > 0) return RedirectToAction(nameof(Index));
        //        }
        //        catch (Exception ex)
        //        {
        //            if (_environment.IsDevelopment())
        //            {
        //                _logger.LogError("Employee Can't be created");
        //            }
        //            else
        //            {
        //                _logger.LogError("Employee Can't be created");
        //                return View("Error", ex);
        //            }
        //        }
        //    }
        //    return View(employeeUpdateVM);
        //}
        //#endregion

        #region Edit (DTO)
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (!id.HasValue) return BadRequest();
            var emp = _employeeService.GetEmployeeDetails(id.Value);
            if (emp is null) return NotFound();
            var empdto = new UpdateEmployeeDTO()
            {
                Id = emp.Id,
                Name = emp.Name,
                Address = emp.Address,
                Salary = emp.Salary,
                Age = emp.Age,
                Email = emp.Email,
                PhoneNumber = emp.PhoneNumber,
                HiringDate = emp.HiringDate,
                IsActive = emp.IsActive,
                EmployeeType = Enum.Parse<EmployeeType>(emp.EmployeeType),
                Gender = Enum.Parse<Gender>(emp.Gender)
            };
            return View(empdto);
        }
        [HttpPost]
        public IActionResult Edit([FromRoute] int id, UpdateEmployeeDTO updateEmployeeDTO)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (id != 0 || id != updateEmployeeDTO.Id)
                    {
                        var res = _employeeService.UpdateEmployee(updateEmployeeDTO);
                        if (res > 0)
                            return RedirectToAction(nameof(Index));
                        else
                            ModelState.AddModelError(string.Empty, "Employee Can't be Updated");
                    }
                }
                catch (Exception ex)
                {
                    if (_environment.IsDevelopment())
                        _logger.LogError($"Employee can't be update {ex}");
                    else
                    {
                        _logger.LogError($"Employee can't be update {ex}");
                        return View("Error", ex);
                    }
                }
            }
            return View(updateEmployeeDTO);
        }
        #endregion

        #region Delete
        [HttpPost]
        public IActionResult Delete([FromRoute] int id)
        {
            try
            {
                if (id == 0) return BadRequest();
                var res = _employeeService.DeleteEmployee(id);
                if (res is true) return RedirectToAction(nameof(Index));
                ModelState.AddModelError(string.Empty, "Employee Can't be deleted");
            }
            catch (Exception ex)
            {
                if (_environment.IsDevelopment())
                    _logger.LogError($"Employee can't be update {ex}");
                else
                {
                    _logger.LogError($"Employee can't be update {ex}");
                    return View("Error", ex);
                }
            }
            return RedirectToAction(nameof(Delete), new { id });
        }
        #endregion
    }
}

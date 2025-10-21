using DemoBLL.DTOS.DepartmentModule;
using DemoBLL.Services.Classes;
using DemoBLL.Services.Interfaces;
using DemoPL.ViewModels.DepartmentViewModel;
using Microsoft.AspNetCore.Mvc;
using NuGet.Common;

namespace DemoPL.Controllers
{
    public class DepartmentController(IDepartmentService _departmentService, ILogger<DepartmentController> _logger, IWebHostEnvironment _environment) : Controller
    {
        #region Index
        [HttpGet]
        public IActionResult Index()
        {
            var departments = _departmentService.GetAllllDepartment();
            return View(departments);
        }
        #endregion

        #region Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(AddDepartmentDTO addDepartmentDTO)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    int result = _departmentService.AddDepartment(addDepartmentDTO);
                    if (result > 0)
                    {
                        return RedirectToAction(actionName: nameof(Index));
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Department Can Not Be Created");
                    }
                }
                catch (Exception ex)
                {
                    if (_environment.IsDevelopment())
                    {
                        _logger.LogError("Department Can Not Be Created (Development)");
                    }
                    else
                    {
                        _logger.LogError("Department Can Not Be Created (deployment)");
                        return View("Error");
                    }
                }
            }
            return View(addDepartmentDTO);
        }
        #endregion

        #region Details
        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id is null) return BadRequest(); //400
            var department = _departmentService.GetDepartmentDetailsById(id.Value);
            if (!id.HasValue) return NotFound(); //404
            return View(department);
        }
        #endregion

        #region Edit
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (!id.HasValue) return BadRequest();
            var department = _departmentService.GetDepartmentDetailsById(id.Value);
            if (department is null) return NotFound();
            var deptVM = new UpdateDepartmentViewModel()
            {
                Code = department.Code,
                Name = department.Name,
                Description = department.Description,
                DateCreated = department.DateCreatedOn.HasValue ? department.DateCreatedOn.Value : default
            };
            return View(deptVM);
        }
        [HttpPost]
        public IActionResult Edit([FromRoute]int id,  UpdateDepartmentViewModel departmentViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var deptUpdate = new UpdateDepartmentDTO()
                    {
                        Id = id,
                        Code = departmentViewModel.Code,
                        Name = departmentViewModel.Name,
                        Description = departmentViewModel.Description,
                        DateCreatedOn = departmentViewModel.DateCreated
                    };
                    int res = _departmentService.UpdateDepartment(deptUpdate);
                    if (res > 0) return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    if (_environment.IsDevelopment())
                        _logger.LogError("Department Can not Be Updated");
                    else
                    {
                        _logger.LogError("Department Can not Be Updated");
                        return View("Error", ex);
                    }
                }
            }
            return View(departmentViewModel);
        }
        #endregion

        #region Delete
        //[HttpGet]
        //public IActionResult Delete(int? id)
        //{
        //    if (!id.HasValue) return BadRequest();
        //    var dept = _departmentService.GetDepartmentDetailsById(id.Value);
        //    if (dept is null) return NotFound();
        //    return View(dept);
        //}
        [HttpPost]
        public IActionResult Delete([FromRoute] int id)
        {
            try
            {
                if (id == 0) return BadRequest();
                bool isdeleted = _departmentService.DeleteDepartment(id);
                if (isdeleted == true) return RedirectToAction(nameof(Index));
                else
                {
                    ModelState.AddModelError(string.Empty, "Department can not be deleted");
                    return RedirectToAction(nameof(Delete), new { id });
                }
            }
            catch (Exception ex)
            {
                if (_environment.IsDevelopment())
                    _logger.LogError("Department Can not Be Updated");
                else
                {
                    _logger.LogError("Department Can not Be Updated");
                    return View("Error", ex);
                }
            }
            return RedirectToAction(nameof(Delete), new { id });
        }
        #endregion
    }
}

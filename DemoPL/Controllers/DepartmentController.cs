using DemoBLL.DTOS.DepartmentModule;
using DemoBLL.Services.Interfaces;
using DemoPL.ViewModels.DepartmentVM;
using Microsoft.AspNetCore.Mvc;

namespace DemoPL.Controllers
{
    public class DepartmentController(IDepartmentService _departmentService, ILogger<DepartmentController> _logger, IWebHostEnvironment _environment) : Controller
    {
        #region Index
        public IActionResult Index()
        {
            var departments = _departmentService.GetAllDepartment();
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
                    var res = _departmentService.AddDepartment(addDepartmentDTO);
                    if (res > 0) return RedirectToAction(nameof(Index));
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Department Can't be Created");
                    }
                }
                catch (Exception ex)
                {
                    if (_environment.IsDevelopment())
                        _logger.LogError("Department Can't be Created");
                    else
                    {
                        _logger.LogError("Department Can't be Created", ex);
                        return View("Error", ex);
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
            if (!id.HasValue) return BadRequest(); //400
            var dept = _departmentService.GetDepartmentDetails(id.Value);
            if (dept is null) return NotFound(); //404
            return View(dept);
        }
        #endregion

        #region Edit
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (!id.HasValue) return BadRequest(); //400
            var dept = _departmentService.GetDepartmentDetails(id.Value);
            if (dept is null) return NotFound(); //404
            var deptVM = new DepartmentUpdateVM()
            {
                Name = dept.Name,
                Code = dept.Code,
                Description = dept.Description,
                DateCreatedOn = dept.DateCreatedOn.HasValue ? dept.DateCreatedOn.Value : default
            };
            return View(deptVM);
        }
        [HttpPost]
        public IActionResult Edit([FromRoute]int id , UpdateDepartmentDTO updateDepartmentDTO)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var deptUpdate = new UpdateDepartmentDTO()
                    {
                        Id = id,
                        Code = updateDepartmentDTO.Code,
                        Name = updateDepartmentDTO.Name,
                        Description = updateDepartmentDTO.Description,
                        DateCreatedOn = updateDepartmentDTO.DateCreatedOn
                    };
                    int res = _departmentService.UpdateDepartment(deptUpdate);
                    if (res > 0) return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    if (_environment.IsDevelopment())
                        _logger.LogError("Department Can't be updated");
                    else
                    {
                        _logger.LogError("Department Can't be updated", ex);
                        return View("Error", ex);
                    }
                }
            }
            return View(updateDepartmentDTO);

        }
        #endregion

        #region Delete
        [HttpPost]
        public IActionResult Delete([FromRoute]int id)
        {
            try
            {
                if (id == 0) return BadRequest();
                bool isdelete = _departmentService.DeleteDepartment(id);
                if (isdelete == true) return RedirectToAction(nameof(Index));
                else
                {
                    ModelState.AddModelError(string.Empty, "Not Deleted");
                    return RedirectToAction(nameof(Delete), new { id });
                }
            }
            catch (Exception ex)
            {
                if (_environment.IsDevelopment())
                    _logger.LogError("Department Can't be Deleted");
                else
                {
                    _logger.LogError("Department Can't be Deleted");
                    return View("Error", ex);
                }
            }
            return RedirectToAction(nameof(Delete), new { id });
        }
        #endregion
    }
}

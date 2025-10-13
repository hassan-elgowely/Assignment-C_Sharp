using DemoBLL.Services.Classes;
using DemoBLL.Services.Interfaces;
using DemoDAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoPL.Controllers
{
    public class DepartmentController(IDepartmentService _departmentService) : Controller
    {
        public IActionResult Index()
        {
            var departments = _departmentService.GetAllDepartment();
            return View(departments);
        }
    }
}

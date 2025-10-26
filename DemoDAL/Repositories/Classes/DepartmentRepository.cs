using DemoDAL.Data.Contexts;
using DemoDAL.Model.Department;
using DemoDAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDAL.Repositories.Classes
{
    public class DepartmentRepository(ApplicationDbContext _context) : GenericRepository<Department>(_context) , IDepartmentRepository
    {
    }
}

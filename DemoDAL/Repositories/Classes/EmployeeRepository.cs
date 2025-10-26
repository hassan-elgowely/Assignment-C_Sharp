using DemoDAL.Data.Contexts;
using DemoDAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDAL.Repositories.Classes
{
    public class EmployeeRepository(ApplicationDbContext _context) : GenericRepository<Employee>(_context) , IEmployeeRepository
    {
    }
}

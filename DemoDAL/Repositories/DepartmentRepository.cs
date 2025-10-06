using DemoDAL.Data.Contexts;
using DemoDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDAL.Repositories
{
    internal class DepartmentRepository(ApplicationDbContext _context)
    {

        public Department? GetById (int id)
        {
            
            return _context.departments?.Find(id);
        }
    }
}

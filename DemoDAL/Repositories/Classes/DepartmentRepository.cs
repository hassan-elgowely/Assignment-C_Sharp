using DemoDAL.Data.Contexts;
using DemoDAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDAL.Repositories.Classes
{
    public class DepartmentRepository(ApplicationDbContext _context) : IDepartmentRepository
    {
        public IEnumerable<Department> GetAll(bool notacking = false)
        {
            if (notacking)
                return _context.departments.ToList();
            else
                return _context.departments.AsNoTracking().ToList();
        }
        public Department? GetById(int id)
        {
            return _context.departments.Find(id);
        }
        public int Add(Department department)
        {
            _context.departments.Add(department);
            return _context.SaveChanges();
        }
        public int Update(Department department)
        {
            _context.departments.Update(department);
            return _context.SaveChanges();
        }
        public int Delete(Department department)
        {
            _context.departments.Remove(department);
            return _context.SaveChanges();
        }
    }
}

using DemoDAL.Repositories.Interfaces;

namespace DemoDAL.Repositories.Classes
{
    public class DepartmentRepository(ApplicationDbContext _context) : IDepartmentRepository
    {

        public IEnumerable<Department> GetAll(bool notracking = false)  // IEnumerable ==> General Scope 
        {
            if (notracking)
                return _context.Departments.ToList();
            else
                return _context.Departments.AsNoTracking().ToList();
        }
        public Department? GetById(int id)
        {
            return _context.Departments.Find(id);
        }
        public int Add(Department department)
        {
            _context.Departments.Add(department);     // Local
            return _context.SaveChanges();            // changed
        }
        public int Update(Department department)
        {
            _context.Departments.Update(department);  // Local
            return _context.SaveChanges();            // changed
        }
        public int Delete(Department department)
        {
            _context.Departments.Remove(department);   // Local
            return _context.SaveChanges();             // changed
        }
    }
}

namespace DemoDAL.Repositories.Interfaces
{
    public interface IDepartmentRepository
    {
        int Add(Department department);
        int Delete(Department department);
        IEnumerable<Department> GetAll(bool notracking = false);
        Department? GetById(int id);
        int Update(Department department);
    }
}
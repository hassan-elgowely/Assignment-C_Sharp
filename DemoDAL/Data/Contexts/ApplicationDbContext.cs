
using DemoDAL.Model.Department;
using System.Reflection;


namespace DemoDAL.Data.Contexts
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> _dbContext) : DbContext (_dbContext)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Department> departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}

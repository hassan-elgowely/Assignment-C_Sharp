
using System.Reflection;


namespace DemoDAL.Data.Contexts
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext (options)
    {
        //protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        //{
        //    base.ConfigureConventions(configurationBuilder);
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration<Department>(new DepartmentConfiguration());
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // prefer with many modules // ==> using System.Reflection;
        }
        public DbSet<Department> Departments { get; set; }
    }
}

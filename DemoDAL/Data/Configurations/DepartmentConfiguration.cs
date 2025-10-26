

using DemoDAL.Model.Department;

namespace DemoDAL.Data.Configurations
{
    public class DepartmentConfiguration : BaseEntityConfiguration<Department> ,  IEntityTypeConfiguration<Department>
    {
        public new void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(D => D.Id).UseIdentityColumn(10, 10);
            builder.Property(D => D.Name).HasColumnType("varchar(50)");
            builder.Property(D => D.Code).HasColumnType("varchar(50)");
            base.Configure(builder); // calling configuration for method BaseEntity
        }
    }
}

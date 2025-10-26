using DemoDAL.Model.Shared;


namespace DemoDAL.Data.Configurations
{
    public class EmployeeConfiguration : BaseEntityConfiguration<Employee>, IEntityTypeConfiguration<Employee>
    {
        public new void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(E => E.Name).HasColumnType("varchar(50)");
            builder.Property(E => E.Address).HasColumnType("varchar(50)");
            builder.Property(E => E.Salary).HasColumnType("decimal(10,2)");
            builder.Property(E => E.Email).HasAnnotation("RegexPattern", @"^[^@\s]+@[^@\s]+\.[^@\s]+$" );
            builder.Property(E => E.Gender).HasConversion((genderDB) => genderDB.ToString(), (genderAPP) => (Gender)Enum.Parse(typeof(Gender), genderAPP));
            builder.Property(E => E.EmployeeType).HasConversion((empDB) => empDB.ToString(), (empAPP) => (EmployeeType)Enum.Parse(typeof(EmployeeType), empAPP));
            base.Configure(builder); // calling configuration for method BaseEntity
        }
    }
}

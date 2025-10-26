using DemoDAL.Model.Shared;


namespace DemoDAL.Data.Configurations
{
    public class BaseEntityConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(p => p.CreatedOn).HasDefaultValueSql("Getdate()");
            builder.Property(p => p.ModifiedOn).HasComputedColumnSql("Getdate()");
        }
    }
}

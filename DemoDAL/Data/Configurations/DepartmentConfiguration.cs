using DemoDAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDAL.Data.Configurations
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(p => p.Id).UseIdentityColumn(10, 10);
            builder.Property(p => p.Name).HasColumnType("varchar(25)");
            builder.Property(p => p.Code).HasColumnType("varchar(25)");
            builder.Property(p => p.CreatedOn).HasDefaultValueSql("GetDate()");
            builder.Property(p => p.ModifiedOn).HasComputedColumnSql("GetDate()");
        }
    }
}

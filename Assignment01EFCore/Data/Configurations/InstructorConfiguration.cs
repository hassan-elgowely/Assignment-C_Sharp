using Assignment01EFCore.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01EFCore.Data.Configurations
{
    internal class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.ToTable("Instructors");
            builder.HasKey(pk => pk.Id);
            builder.Property(pk => pk.Id).UseIdentityColumn(100,2);
            builder.Property(n => n.Name).HasColumnType("varchar(50)").IsRequired();
            builder.Ignore(p => p.Bouns);
            builder.Property(p => p.Salary).HasDefaultValue("18000");
            builder.Property(p => p.Address).HasDefaultValue("Cairo");
            builder.Property(p => p.HourRate).HasComputedColumnSql("[Salary] / 160");
            builder.Property(fk => fk.DeptId).HasColumnName("DeptId_FK");
        }
    }
}

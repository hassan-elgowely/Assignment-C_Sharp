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
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).UseIdentityColumn(500, 2);
            builder.Property(p => p.FirstName).HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.LastName).HasColumnType("varchar(50)").IsRequired(false);
            builder.Property(p => p.Address).HasDefaultValue("Cairo");
            builder.Property(p => p.Age).IsRequired();
            builder.Property(p=>p.DeptId).HasColumnName("DeptId_FK");
        }
    }
}

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
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments","HR");
            builder.HasKey(pk => pk.Id);
            builder.Property(pk => pk.Id).UseIdentityColumn(10,10);
            builder.Property(n => n.Name).HasColumnType("varchar(55)").IsRequired();
            builder.Property(date => date.HiringDate).HasColumnType("date").HasAnnotation("datatype", "date");
            builder.Property(p => p.InstructorId).HasColumnName("InstructorId_FK");
        }
    }
}

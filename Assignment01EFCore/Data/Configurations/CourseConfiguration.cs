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
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses");
            builder.HasKey(pk => pk.Id);
            builder.Property(id=>id.Id).UseIdentityColumn(1000,10);
            builder.Property(n=>n.Name).IsRequired().HasColumnType("varchar(50)");
            builder.Property(d => d.Duration).IsRequired();
            builder.Property(d => d.Description).HasColumnType("varchar(200)");
            builder.Property(fk => fk.TopId).HasColumnName("TopId_FK");
        }
    }
}

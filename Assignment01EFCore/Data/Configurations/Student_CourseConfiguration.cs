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
    internal class Student_CourseConfiguration : IEntityTypeConfiguration<Student_Course>
    {
        public void Configure(EntityTypeBuilder<Student_Course> builder)
        {
            builder.ToTable("Students_Courses");
            builder.HasKey(t => new { t.StudentId, t.CourseId });
            builder.Property(t => t.Grade).HasColumnType("decimal(2,2)");
        }
    }
}

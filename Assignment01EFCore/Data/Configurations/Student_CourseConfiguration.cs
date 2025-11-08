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
            builder.HasKey(PK => new { PK.StudentId, PK.CourseId }); // composite PK
            builder.Property(t => t.Grade).HasColumnType("decimal(10,2)");

            builder.HasOne(S=>S.student)
                   .WithMany(SC=>SC.student_Courses)
                   .HasForeignKey(FK=>FK.StudentId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(C=>C.course)
                   .WithMany(SC=>SC.student_Courses)
                   .HasForeignKey(FK=>FK.CourseId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

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
    internal class Course_InstructorConfiguration : IEntityTypeConfiguration<Course_Instructor>
    {
        public void Configure(EntityTypeBuilder<Course_Instructor> builder)
        {
            builder.ToTable("Courses_Instructors");
            builder.HasKey(pk => new {pk.InstructorId , pk.CourseId});
            builder.Property(p=>p.Evaluate).HasColumnType("varchar(25)");
        }
    }
}

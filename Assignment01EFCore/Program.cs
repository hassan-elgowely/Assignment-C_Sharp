using Assignment01EFCore.Data.Models;
using Assignment02EFCore.Data.Contexts;
using Assignment02EFCore.Data.DataSeeding;
using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;

namespace Assignment01EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Data Seeding
            //using ITIDbContext context = new ITIDbContext();

            //bool topicSeeded = ITIDbContextSeed.SeedData<Topic>(context, "Files\\topics.json");
            //Console.WriteLine(topicSeeded ? "true" : "False");

            //bool courseSeeded = ITIDbContextSeed.SeedData<Course>(context, "Files\\courses.json");
            //Console.WriteLine(courseSeeded ? "true" : "False");

            //bool departmentSeeded = ITIDbContextSeed.SeedData<Department>(context, "Files\\departments.json");
            //Console.WriteLine(departmentSeeded ? "true" : "False");

            //bool instructorSeeded = ITIDbContextSeed.SeedData<Instructor>(context, "Files\\instructors.json");
            //Console.WriteLine(instructorSeeded ? "true" : "False");

            //bool studentSeeded = ITIDbContextSeed.SeedData<Student>(context, "Files\\students.json");
            //Console.WriteLine(studentSeeded ? "true" : "False");

            //bool studentCourseSeeded = ITIDbContextSeed.SeedData<Student_Course>(context, "Files\\students_courses.json");
            //Console.WriteLine(studentCourseSeeded ? "true" : "False");

            //bool courseInstructorSeeded = ITIDbContextSeed.SeedData<Course_Instructor>(context, "Files\\courses_instructors.json");
            //Console.WriteLine(courseInstructorSeeded ? "true" : "False");

            #endregion
        }

    }
}

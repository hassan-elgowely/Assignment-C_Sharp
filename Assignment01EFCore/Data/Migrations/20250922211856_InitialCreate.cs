using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment01EFCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "HR");

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1000, 10"),
                    Name = table.Column<string>(type: "varchar(50)", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "varchar(200)", nullable: false),
                    TopId_FK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses_Instructors",
                columns: table => new
                {
                    InstructorId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Evaluate = table.Column<string>(type: "varchar(25)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses_Instructors", x => new { x.InstructorId, x.CourseId });
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                schema: "HR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "10, 10"),
                    Name = table.Column<string>(type: "varchar(55)", nullable: false),
                    HiringDate = table.Column<DateOnly>(type: "date", nullable: false),
                    InstructorId_FK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100, 2"),
                    Name = table.Column<string>(type: "varchar(50)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 18000m),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Cairo"),
                    HourRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false, computedColumnSql: "[Salary] / 160"),
                    DeptId_FK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "500, 2"),
                    FirstName = table.Column<string>(type: "varchar(50)", nullable: false),
                    LastName = table.Column<string>(type: "varchar(50)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Cairo"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DeptId_FK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students_Courses",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<decimal>(type: "decimal(2,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students_Courses", x => new { x.StudentId, x.CourseId });
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "2000, 5"),
                    Name = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Courses_Instructors");

            migrationBuilder.DropTable(
                name: "Departments",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Students_Courses");

            migrationBuilder.DropTable(
                name: "Topics");
        }
    }
}

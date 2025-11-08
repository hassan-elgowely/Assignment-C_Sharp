using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment02EFCore.Migrations
{
    /// <inheritdoc />
    public partial class ResolveDepartmentEntitySETInstructorIdnullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Departments_InstructorId",
                schema: "HR",
                table: "Departments");

            migrationBuilder.AlterColumn<int>(
                name: "InstructorId",
                schema: "HR",
                table: "Departments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_InstructorId",
                schema: "HR",
                table: "Departments",
                column: "InstructorId",
                unique: true,
                filter: "[InstructorId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Departments_InstructorId",
                schema: "HR",
                table: "Departments");

            migrationBuilder.AlterColumn<int>(
                name: "InstructorId",
                schema: "HR",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_InstructorId",
                schema: "HR",
                table: "Departments",
                column: "InstructorId",
                unique: true);
        }
    }
}

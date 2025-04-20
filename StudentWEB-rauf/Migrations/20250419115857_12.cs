using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentWEB_rauf.Migrations
{
    /// <inheritdoc />
    public partial class _12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodeName",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Units",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Students",
                newName: "StudentCode");

            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "Teachers",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "Result",
                table: "Points",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Units",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "StudentCode",
                table: "Students",
                newName: "StudentId");

            migrationBuilder.AlterColumn<double>(
                name: "Salary",
                table: "Teachers",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "Result",
                table: "Points",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "CodeName",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

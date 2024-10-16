using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ST10028058_PROG6212_POE_Part2.Data.Migrations
{
    /// <inheritdoc />
    public partial class Claims : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoordinatorID",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "DateSubmitted",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "LecturerID",
                table: "Claims");

            migrationBuilder.RenameColumn(
                name: "ClaimID",
                table: "Claims",
                newName: "ClaimId");

            migrationBuilder.RenameColumn(
                name: "ManagerID",
                table: "Claims",
                newName: "LecturerName");

            migrationBuilder.AlterColumn<double>(
                name: "HoursWorked",
                table: "Claims",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "HourlyRate",
                table: "Claims",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClaimId",
                table: "Claims",
                newName: "ClaimID");

            migrationBuilder.RenameColumn(
                name: "LecturerName",
                table: "Claims",
                newName: "ManagerID");

            migrationBuilder.AlterColumn<decimal>(
                name: "HoursWorked",
                table: "Claims",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "HourlyRate",
                table: "Claims",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<string>(
                name: "CoordinatorID",
                table: "Claims",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateSubmitted",
                table: "Claims",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LecturerID",
                table: "Claims",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

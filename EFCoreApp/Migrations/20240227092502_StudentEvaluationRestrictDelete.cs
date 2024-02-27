using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreApp.Migrations
{
    /// <inheritdoc />
    public partial class StudentEvaluationRestrictDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evaluations_Student_StudentId",
                table: "Evaluations");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("1bdf3c57-845d-49aa-a455-ce876215bb7d"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("2f1efcaf-fdbb-489e-93cb-d30ca956a8e8"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("4bf7b85e-f3af-4b30-81f9-206d54923547"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("5a007adc-1a2a-4a5c-92bf-5e69960cabad"));

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "IsRegularStudent", "Name" },
                values: new object[,]
                {
                    { new Guid("3756ec90-f2e5-431c-b0bb-7dec11121a17"), 25, false, "John Depp" },
                    { new Guid("58eadc80-5a44-401f-ba14-ac64defb512b"), 100, false, "TEST Name" },
                    { new Guid("a9d3b2e1-b5cd-4bc0-8359-58aa48191cc3"), 30, false, "John Doe" },
                    { new Guid("bd596d3c-9669-46d0-9e65-b9f606135442"), 29, false, "Mike Miles" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluations_Student_StudentId",
                table: "Evaluations",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evaluations_Student_StudentId",
                table: "Evaluations");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("3756ec90-f2e5-431c-b0bb-7dec11121a17"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("58eadc80-5a44-401f-ba14-ac64defb512b"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("a9d3b2e1-b5cd-4bc0-8359-58aa48191cc3"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("bd596d3c-9669-46d0-9e65-b9f606135442"));

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "IsRegularStudent", "Name" },
                values: new object[,]
                {
                    { new Guid("1bdf3c57-845d-49aa-a455-ce876215bb7d"), 25, false, "John Depp" },
                    { new Guid("2f1efcaf-fdbb-489e-93cb-d30ca956a8e8"), 29, false, "Mike Miles" },
                    { new Guid("4bf7b85e-f3af-4b30-81f9-206d54923547"), 100, false, "TEST Name" },
                    { new Guid("5a007adc-1a2a-4a5c-92bf-5e69960cabad"), 30, false, "John Doe" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluations_Student_StudentId",
                table: "Evaluations",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

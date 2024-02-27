using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreApp.Migrations
{
    /// <inheritdoc />
    public partial class OneToOneRelationshipStudent_StudentDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("41b8d128-696d-41b3-951c-42a59e0bf638"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("c1137e8e-1a55-41a8-91a6-ecb7eacde840"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("cb004594-65d5-45a1-844e-0d7ea020373f"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("cc15dc21-9bee-4544-bd47-fe967b3d496e"));

            migrationBuilder.CreateTable(
                name: "StudentDetails",
                columns: table => new
                {
                    StudentDetailsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalInformation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentDetails", x => x.StudentDetailsId);
                    table.ForeignKey(
                        name: "FK_StudentDetails_Student_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "IsRegularStudent", "Name" },
                values: new object[,]
                {
                    { new Guid("0227457f-5744-4561-9ca3-6391d43f2433"), 30, false, "John Doe" },
                    { new Guid("2b08a39d-267c-4067-bfe4-fd08211eb0b9"), 29, false, "Mike Miles" },
                    { new Guid("e5bbe607-d0df-46a2-aa8c-67a1a3044498"), 100, false, "TEST Name" },
                    { new Guid("e707eb5e-d1b9-4916-a9bd-fa2a40295926"), 25, false, "John Depp" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentDetails_StudentID",
                table: "StudentDetails",
                column: "StudentID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentDetails");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("0227457f-5744-4561-9ca3-6391d43f2433"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("2b08a39d-267c-4067-bfe4-fd08211eb0b9"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("e5bbe607-d0df-46a2-aa8c-67a1a3044498"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("e707eb5e-d1b9-4916-a9bd-fa2a40295926"));

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "IsRegularStudent", "Name" },
                values: new object[,]
                {
                    { new Guid("41b8d128-696d-41b3-951c-42a59e0bf638"), 30, false, "John Doe" },
                    { new Guid("c1137e8e-1a55-41a8-91a6-ecb7eacde840"), 25, false, "John Depp" },
                    { new Guid("cb004594-65d5-45a1-844e-0d7ea020373f"), 100, false, "TEST Name" },
                    { new Guid("cc15dc21-9bee-4544-bd47-fe967b3d496e"), 29, false, "Mike Miles" }
                });
        }
    }
}

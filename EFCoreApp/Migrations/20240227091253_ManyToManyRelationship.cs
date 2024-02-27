using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreApp.Migrations
{
    /// <inheritdoc />
    public partial class ManyToManyRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("7bfeec47-76b7-4513-9987-86457633cf18"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("ab844c33-1a0e-49c3-889e-6c83a7cbaa2c"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("e7982eb2-94e9-448c-900f-220ef1eb5954"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("f6203b3a-997f-4edb-8043-2a63ac75bd96"));

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.SubjectId);
                });

            migrationBuilder.CreateTable(
                name: "StudentSubject",
                columns: table => new
                {
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSubject", x => new { x.StudentId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_StudentSubject_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentSubject_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubject_SubjectId",
                table: "StudentSubject",
                column: "SubjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentSubject");

            migrationBuilder.DropTable(
                name: "Subject");

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
                    { new Guid("7bfeec47-76b7-4513-9987-86457633cf18"), 25, false, "John Depp" },
                    { new Guid("ab844c33-1a0e-49c3-889e-6c83a7cbaa2c"), 100, false, "TEST Name" },
                    { new Guid("e7982eb2-94e9-448c-900f-220ef1eb5954"), 29, false, "Mike Miles" },
                    { new Guid("f6203b3a-997f-4edb-8043-2a63ac75bd96"), 30, false, "John Doe" }
                });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreApp.Migrations
{
    /// <inheritdoc />
    public partial class ManyToManyRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Evaluations",
                columns: table => new
                {
                    EvaluationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false),
                    AdditionalExplanation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluations", x => x.EvaluationId);
                    table.ForeignKey(
                        name: "FK_Evaluations_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "IsRegularStudent", "Name" },
                values: new object[,]
                {
                    { new Guid("9fa4e101-a097-439d-98da-c110f99be154"), 100, false, "TEST Name" },
                    { new Guid("ccf9406a-ce96-409b-beaf-42336739d9dc"), 29, false, "Mike Miles" },
                    { new Guid("d6040bcd-878e-4b87-9fea-3b4ea17d1111"), 30, false, "John Doe" },
                    { new Guid("e5070fdc-b76e-4139-9361-d177f0ac7a09"), 25, false, "John Depp" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Evaluations_StudentId",
                table: "Evaluations",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evaluations");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("9fa4e101-a097-439d-98da-c110f99be154"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("ccf9406a-ce96-409b-beaf-42336739d9dc"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("d6040bcd-878e-4b87-9fea-3b4ea17d1111"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("e5070fdc-b76e-4139-9361-d177f0ac7a09"));

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
        }
    }
}

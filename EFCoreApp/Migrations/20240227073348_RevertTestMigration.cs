using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreApp.Migrations
{
    /// <inheritdoc />
    public partial class RevertTestMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("4bb565d0-ff88-43b4-9570-1534459ee1f3"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("7d42c00f-b64f-4c55-87c8-3d691fce098f"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("f86605bf-4bb9-4ee3-bdda-9a27a07376c3"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "IsRegularStudent", "Name" },
                values: new object[,]
                {
                    { new Guid("4bb565d0-ff88-43b4-9570-1534459ee1f3"), 29, false, "Mike Miles" },
                    { new Guid("7d42c00f-b64f-4c55-87c8-3d691fce098f"), 30, false, "John Doe" },
                    { new Guid("f86605bf-4bb9-4ee3-bdda-9a27a07376c3"), 25, false, "John Depp" }
                });
        }
    }
}

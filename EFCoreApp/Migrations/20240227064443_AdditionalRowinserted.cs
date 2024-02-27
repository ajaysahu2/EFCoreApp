using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreApp.Migrations
{
    /// <inheritdoc />
    public partial class AdditionalRowinserted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("51dbc5a5-4cf3-4050-826f-1abff827636f"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("7ce31008-9cb4-4e8c-9355-80018ef09ad7"));

            migrationBuilder.AlterColumn<bool>(
                name: "IsRegularStudent",
                table: "Student",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<bool>(
                name: "IsRegularStudent",
                table: "Student",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[,]
                {
                    { new Guid("51dbc5a5-4cf3-4050-826f-1abff827636f"), 25, "John Depp" },
                    { new Guid("7ce31008-9cb4-4e8c-9355-80018ef09ad7"), 30, "John Doe" }
                });
        }
    }
}

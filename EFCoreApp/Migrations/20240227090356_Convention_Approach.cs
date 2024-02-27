using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreApp.Migrations
{
    /// <inheritdoc />
    public partial class Convention_Approach : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("7bfeec47-76b7-4513-9987-86457633cf18"), 25, false, "John Depp" },
                    { new Guid("ab844c33-1a0e-49c3-889e-6c83a7cbaa2c"), 100, false, "TEST Name" },
                    { new Guid("e7982eb2-94e9-448c-900f-220ef1eb5954"), 29, false, "Mike Miles" },
                    { new Guid("f6203b3a-997f-4edb-8043-2a63ac75bd96"), 30, false, "John Doe" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}

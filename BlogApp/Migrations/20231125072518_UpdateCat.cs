using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 25, 14, 25, 18, 254, DateTimeKind.Local).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 25, 14, 25, 18, 254, DateTimeKind.Local).AddTicks(7898));

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Name" },
                values: new object[,]
                {
                    { 2L, new DateTime(2023, 11, 25, 14, 25, 18, 254, DateTimeKind.Local).AddTicks(7909), null, "Thông báo 2" },
                    { 3L, new DateTime(2023, 11, 25, 14, 25, 18, 254, DateTimeKind.Local).AddTicks(7910), null, "Thông báo 3" },
                    { 4L, new DateTime(2023, 11, 25, 14, 25, 18, 254, DateTimeKind.Local).AddTicks(7911), null, "Thông báo 4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 18, 16, 0, 54, 591, DateTimeKind.Local).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 18, 16, 0, 54, 590, DateTimeKind.Local).AddTicks(9779));
        }
    }
}

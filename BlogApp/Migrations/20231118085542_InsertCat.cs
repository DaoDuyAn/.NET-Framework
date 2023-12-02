using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogApp.Migrations
{
    /// <inheritdoc />
    public partial class InsertCat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "Name" },
                values: new object[] { new DateTime(2023, 11, 18, 15, 55, 42, 32, DateTimeKind.Local).AddTicks(868), "Thông báo" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "Author", "Content", "DateCreated", "DateUpdated", "IdCategory", "Title" },
                values: new object[] { 1L, null, "Entity Framework Core is...", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1L, "Introduction to Entity Framework Core" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "Name" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Technology" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Name" },
                values: new object[] { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Science" });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "Author", "Content", "DateCreated", "DateUpdated", "IdCategory", "Title" },
                values: new object[] { 2L, null, "Artificial Intelligence is transforming...", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2L, "The wonders of AI" });
        }
    }
}

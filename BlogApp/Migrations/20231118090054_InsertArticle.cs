using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogApp.Migrations
{
    /// <inheritdoc />
    public partial class InsertArticle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "Author", "Content", "DateCreated", "DateUpdated", "IdCategory", "Title" },
                values: new object[] { 1L, null, "Nghỉ học nhé jeje", new DateTime(2023, 11, 18, 16, 0, 54, 591, DateTimeKind.Local).AddTicks(7), null, 1L, "Thông báo nghỉ lụt" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 18, 16, 0, 54, 590, DateTimeKind.Local).AddTicks(9779));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 18, 15, 55, 42, 32, DateTimeKind.Local).AddTicks(868));
        }
    }
}

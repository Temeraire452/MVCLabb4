using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVCLabb4.Migrations
{
    /// <inheritdoc />
    public partial class lånat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsReturned", "Title" },
                values: new object[] { false, "Lord of the Rings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsReturned", "Title" },
                values: new object[] { true, "Dead Until Dark" });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "Id", "BookId", "BorrowDate", "CustomerId", "ReturnDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 6, 8, 14, 31, 15, 448, DateTimeKind.Local).AddTicks(9467), 1, null },
                    { 2, 2, new DateTime(2024, 6, 8, 14, 31, 15, 448, DateTimeKind.Local).AddTicks(9500), 2, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsReturned", "Title" },
                values: new object[] { true, "Lord of the rings" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsReturned", "Title" },
                values: new object[] { false, "Dead until dark" });
        }
    }
}

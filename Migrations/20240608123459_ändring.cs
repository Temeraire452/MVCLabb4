using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCLabb4.Migrations
{
    /// <inheritdoc />
    public partial class ändring : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 1,
                column: "BorrowDate",
                value: new DateTime(2024, 6, 8, 14, 34, 59, 264, DateTimeKind.Local).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 2,
                column: "BorrowDate",
                value: new DateTime(2024, 6, 8, 14, 34, 59, 264, DateTimeKind.Local).AddTicks(7007));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 1,
                column: "BorrowDate",
                value: new DateTime(2024, 6, 8, 14, 31, 15, 448, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 2,
                column: "BorrowDate",
                value: new DateTime(2024, 6, 8, 14, 31, 15, 448, DateTimeKind.Local).AddTicks(9500));
        }
    }
}

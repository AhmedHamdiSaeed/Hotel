using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hotel_DAL.Migrations
{
    /// <inheritdoc />
    public partial class q3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AddColumn<DateTime>(
                name: "BookingDate",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookingDate",
                table: "Bookings");

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "BranchID", "CustomerID", "NumOfRooms", "TotalPrice", "checkInDate", "checkOutDate" },
                values: new object[,]
                {
                    { 1, 1, 1, 3, 0.0, new DateOnly(2024, 1, 1), new DateOnly(2024, 1, 10) },
                    { 2, 2, 2, 3, 0.0, new DateOnly(2024, 2, 10), new DateOnly(2024, 2, 20) }
                });
        }
    }
}

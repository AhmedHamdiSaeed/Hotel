using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hotel_DAL.Migrations
{
    /// <inheritdoc />
    public partial class a2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BookingRooms",
                columns: new[] { "BookingId", "RoomID", "BookingDate", "NumOfAdults", "NumOfChildren" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 4, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 5, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 6, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 7, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 8, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 9, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 10, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 11, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 12, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 13, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 14, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 15, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 16, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 17, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 18, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 19, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 20, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 21, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 22, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 23, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 24, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 25, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 26, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 27, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 28, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 29, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 30, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookingRooms",
                keyColumns: new[] { "BookingId", "RoomID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "BookingRooms",
                keyColumns: new[] { "BookingId", "RoomID" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "BookingRooms",
                keyColumns: new[] { "BookingId", "RoomID" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "BookingRooms",
                keyColumns: new[] { "BookingId", "RoomID" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "BookingRooms",
                keyColumns: new[] { "BookingId", "RoomID" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "BookingRooms",
                keyColumns: new[] { "BookingId", "RoomID" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "BookingRooms",
                keyColumns: new[] { "BookingId", "RoomID" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "BookingRooms",
                keyColumns: new[] { "BookingId", "RoomID" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "BookingRooms",
                keyColumns: new[] { "BookingId", "RoomID" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "BookingRooms",
                keyColumns: new[] { "BookingId", "RoomID" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "BookingRooms",
                keyColumns: new[] { "BookingId", "RoomID" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "BookingRooms",
                keyColumns: new[] { "BookingId", "RoomID" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "BookingRooms",
                keyColumns: new[] { "BookingId", "RoomID" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "BookingRooms",
                keyColumns: new[] { "BookingId", "RoomID" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "BookingRooms",
                keyColumns: new[] { "BookingId", "RoomID" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "BookingRooms",
                keyColumns: new[] { "BookingId", "RoomID" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "BookingRooms",
                keyColumns: new[] { "BookingId", "RoomID" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "BookingRooms",
                keyColumns: new[] { "BookingId", "RoomID" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "BookingRooms",
                keyColumns: new[] { "BookingId", "RoomID" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "BookingRooms",
                keyColumns: new[] { "BookingId", "RoomID" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "BookingRooms",
                keyColumns: new[] { "BookingId", "RoomID" },
                keyValues: new object[] { 21, 1 });

            migrationBuilder.DeleteData(
                table: "BookingRooms",
                keyColumns: new[] { "BookingId", "RoomID" },
                keyValues: new object[] { 22, 1 });

            migrationBuilder.DeleteData(
                table: "BookingRooms",
                keyColumns: new[] { "BookingId", "RoomID" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.DeleteData(
                table: "BookingRooms",
                keyColumns: new[] { "BookingId", "RoomID" },
                keyValues: new object[] { 24, 1 });

            migrationBuilder.DeleteData(
                table: "BookingRooms",
                keyColumns: new[] { "BookingId", "RoomID" },
                keyValues: new object[] { 25, 1 });

            migrationBuilder.DeleteData(
                table: "BookingRooms",
                keyColumns: new[] { "BookingId", "RoomID" },
                keyValues: new object[] { 26, 1 });

            migrationBuilder.DeleteData(
                table: "BookingRooms",
                keyColumns: new[] { "BookingId", "RoomID" },
                keyValues: new object[] { 27, 1 });

            migrationBuilder.DeleteData(
                table: "BookingRooms",
                keyColumns: new[] { "BookingId", "RoomID" },
                keyValues: new object[] { 28, 1 });

            migrationBuilder.DeleteData(
                table: "BookingRooms",
                keyColumns: new[] { "BookingId", "RoomID" },
                keyValues: new object[] { 29, 1 });

            migrationBuilder.DeleteData(
                table: "BookingRooms",
                keyColumns: new[] { "BookingId", "RoomID" },
                keyValues: new object[] { 30, 1 });
        }
    }
}

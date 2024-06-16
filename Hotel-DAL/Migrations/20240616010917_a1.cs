using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hotel_DAL.Migrations
{
    /// <inheritdoc />
    public partial class a1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxAdults = table.Column<int>(type: "int", nullable: false),
                    MaxChildren = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    BranchID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Rooms_Branches_BranchID",
                        column: x => x.BranchID,
                        principalTable: "Branches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Rooms_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    checkInDate = table.Column<DateOnly>(type: "date", nullable: false),
                    checkOutDate = table.Column<DateOnly>(type: "date", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    NumOfRooms = table.Column<int>(type: "int", nullable: false),
                    BranchID = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Branches_BranchID",
                        column: x => x.BranchID,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookingRooms",
                columns: table => new
                {
                    RoomID = table.Column<int>(type: "int", nullable: false),
                    BookingId = table.Column<int>(type: "int", nullable: false),
                    NumOfAdults = table.Column<int>(type: "int", nullable: false),
                    NumOfChildren = table.Column<int>(type: "int", nullable: false),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingRooms", x => new { x.RoomID, x.BookingId });
                    table.ForeignKey(
                        name: "FK_BookingRooms_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingRooms_Rooms_RoomID",
                        column: x => x.RoomID,
                        principalTable: "Rooms",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "ism" },
                    { 2, "cairo" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "MaxAdults", "MaxChildren", "RoomType" },
                values: new object[,]
                {
                    { 1, 1, 2, "Single" },
                    { 2, 2, 3, "Double" },
                    { 3, 3, 5, "Suite" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Name", "NationalID", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "ahmed", "123423", "01092925652" },
                    { 2, "ali", "34543", "010929343" }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "BranchID", "CustomerID", "NumOfRooms", "TotalPrice", "checkInDate", "checkOutDate" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 2000.0, new DateOnly(2024, 12, 1), new DateOnly(2024, 12, 5) },
                    { 2, 1, 1, 1, 2000.0, new DateOnly(2024, 12, 6), new DateOnly(2024, 12, 10) },
                    { 3, 1, 1, 1, 2000.0, new DateOnly(2024, 12, 11), new DateOnly(2024, 12, 15) },
                    { 4, 1, 1, 1, 2000.0, new DateOnly(2024, 12, 16), new DateOnly(2024, 12, 20) },
                    { 5, 1, 1, 1, 2000.0, new DateOnly(2024, 12, 21), new DateOnly(2024, 12, 25) },
                    { 6, 1, 1, 1, 2000.0, new DateOnly(2024, 12, 26), new DateOnly(2024, 12, 30) },
                    { 7, 1, 1, 1, 2000.0, new DateOnly(2024, 1, 1), new DateOnly(2024, 1, 5) },
                    { 8, 1, 1, 1, 2000.0, new DateOnly(2024, 1, 6), new DateOnly(2024, 1, 10) },
                    { 9, 1, 1, 1, 2000.0, new DateOnly(2024, 1, 11), new DateOnly(2024, 1, 15) },
                    { 10, 1, 1, 1, 2000.0, new DateOnly(2024, 1, 16), new DateOnly(2024, 1, 20) },
                    { 11, 1, 1, 1, 2000.0, new DateOnly(2024, 1, 21), new DateOnly(2024, 1, 25) },
                    { 12, 1, 1, 1, 2000.0, new DateOnly(2024, 1, 26), new DateOnly(2024, 1, 30) },
                    { 13, 1, 1, 1, 2000.0, new DateOnly(2024, 2, 1), new DateOnly(2024, 2, 5) },
                    { 14, 1, 1, 1, 2000.0, new DateOnly(2024, 2, 6), new DateOnly(2024, 2, 10) },
                    { 15, 1, 1, 1, 2000.0, new DateOnly(2024, 2, 11), new DateOnly(2024, 2, 15) },
                    { 16, 1, 1, 1, 2000.0, new DateOnly(2024, 2, 16), new DateOnly(2024, 2, 20) },
                    { 17, 1, 1, 1, 2000.0, new DateOnly(2024, 2, 21), new DateOnly(2024, 2, 25) },
                    { 18, 1, 1, 1, 2000.0, new DateOnly(2024, 2, 26), new DateOnly(2024, 2, 27) },
                    { 19, 1, 1, 1, 2000.0, new DateOnly(2024, 2, 28), new DateOnly(2024, 2, 29) },
                    { 20, 1, 1, 1, 2000.0, new DateOnly(2024, 3, 1), new DateOnly(2024, 3, 2) },
                    { 21, 1, 1, 1, 2000.0, new DateOnly(2024, 3, 3), new DateOnly(2024, 3, 5) },
                    { 22, 1, 1, 1, 2000.0, new DateOnly(2024, 3, 6), new DateOnly(2024, 3, 8) },
                    { 23, 1, 1, 1, 2000.0, new DateOnly(2024, 3, 9), new DateOnly(2024, 3, 11) },
                    { 24, 1, 1, 1, 2000.0, new DateOnly(2024, 3, 12), new DateOnly(2024, 3, 14) },
                    { 25, 1, 1, 1, 2000.0, new DateOnly(2024, 3, 15), new DateOnly(2024, 3, 19) },
                    { 26, 1, 1, 1, 2000.0, new DateOnly(2024, 3, 20), new DateOnly(2024, 3, 23) },
                    { 27, 1, 1, 1, 2000.0, new DateOnly(2024, 3, 24), new DateOnly(2024, 3, 26) },
                    { 28, 1, 1, 1, 2000.0, new DateOnly(2024, 3, 27), new DateOnly(2024, 3, 30) },
                    { 29, 1, 1, 1, 2000.0, new DateOnly(2024, 4, 1), new DateOnly(2024, 4, 5) },
                    { 30, 1, 1, 1, 2000.0, new DateOnly(2024, 4, 10), new DateOnly(2024, 4, 15) }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "BranchID", "CategoryID" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 1 },
                    { 3, 2, 2 },
                    { 4, 1, 1 },
                    { 5, 2, 3 },
                    { 6, 2, 2 },
                    { 7, 1, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookingRooms_BookingId",
                table: "BookingRooms",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_BranchID",
                table: "Bookings",
                column: "BranchID");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CustomerID",
                table: "Bookings",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_BranchID",
                table: "Rooms",
                column: "BranchID");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_CategoryID",
                table: "Rooms",
                column: "CategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingRooms");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

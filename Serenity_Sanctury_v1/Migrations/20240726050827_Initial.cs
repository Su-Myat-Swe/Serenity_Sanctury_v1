using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Serenity_Sanctury_v1.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Streetline = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Scent = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BurnTime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Size = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Container = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountedPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Admins_Addresses_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Birthday = table.Column<DateOnly>(type: "date", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    AddressID = table.Column<int>(type: "int", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Users_Addresses_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    AddressID = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_Addresses_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Users_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderTrackings",
                columns: table => new
                {
                    TrackingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    OrderEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    StatusUpdate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderTrackings", x => x.TrackingID);
                    table.ForeignKey(
                        name: "FK_OrderTrackings_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "ID", "City", "Country", "PostalCode", "State", "Streetline" },
                values: new object[] { 1, "Callaghan", "Australia", "2308", "NSW", "221 Ring Road" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "ID", "AddressID", "Email", "FirstName", "FullName", "LastName", "Password", "PhoneNo" },
                values: new object[] { 1, null, "administrator@example.com", "Admin", "Admin Istrator", "Istrator", "Pa$$w0rd", null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "BurnTime", "Category", "Container", "Description", "DiscountedPrice", "ImageUrl", "Price", "ProductName", "Quantity", "Scent", "Size" },
                values: new object[,]
                {
                    { 1, "48 hours", 0, "Black color Glass Jar", "A soothing candle for relaxation.", null, "~/Image/product2.jpeg", 10.00m, "Honeyed Harmony", 100, "Honey and Vanilla", "8 oz" },
                    { 2, "40 hours", 0, "Transparent Glass Jar", "A tranquil candle with a refreshing floral scent, perfect for creating a peaceful atmosphere.", null, "~/Image/product3.jpeg", 12.99m, "Serenity Blossom", 150, "Cherry Blossom", "10 oz" },
                    { 3, null, 1, "Black Glass Bottle", "Premium sandalwood essential oil for a calming and aromatic experience.", null, "~/Image/product4.jpeg", 9.99m, "Soothing Sandalwood Essence", 120, "Sandalwood", "30 ml" },
                    { 4, null, 1, "Black Glass Bottle", "Pure tea tree essential oil known for its refreshing and invigorating properties.", null, "~/Image/product4.jpeg", 9.99m, "Invigorating Tea Tree", 150, "Tea Tree", "30 ml" },
                    { 5, "50 hours", 0, "Black Glass Jar", "A soothing candle that brings a sense of calm and tranquility, perfect for your twilight hours.", null, "~/Image/product2.jpeg", 10.99m, "Tranquil Twilight", 100, "Lavender and Chamomile", "12 oz" },
                    { 6, "40 hours", 0, "Transparent Glass Jar", "A calming candle infused with the soothing scent of lavender, perfect for creating a relaxing ambiance.", null, "~/Image/product3.jpeg", 12.99m, "Lavender Dreams", 75, "Lavender", "8 oz" },
                    { 7, "45 hours", 0, "Transparent Glass Jar", "A luxurious candle with the delicate and romantic scent of rose petals, ideal for creating a serene atmosphere.", null, "~/Image/product3.jpeg", 12.99m, "Rose Petal Oasis", 80, "Rose Petals", "8 oz" },
                    { 8, "40 hours", 0, "Black Glass Jar", "A vibrant candle with an invigorating citrus scent that brightens up any room and lifts your spirits.", null, "~/Image/product2.jpeg", 10.99m, "Citrus Sunrise", 90, "Citrus Blend", "8 oz" },
                    { 9, null, 1, "Black Glass Bottle", "A refreshing essential oil with a zesty lemongrass scent, perfect for revitalizing your senses and uplifting your mood.", null, "~/Image/product4.jpeg", 12.99m, "Lemongrass Harmony", 100, "Lemongrass", "30 ml" },
                    { 10, "40 hours", 0, "Black Glass Jar", "A delightful candle that combines the sweet and tangy aromas of mixed berries, creating a blissful and uplifting atmosphere.", null, "~/Image/product2.jpeg", 12.99m, "Berry Bliss", 120, "Berry Blend", "8 oz" },
                    { 11, "45 hours", 0, "Transparent Glass Jar", "A luxurious candle that envelops you in the rich and creamy aroma of vanilla, creating a cozy and relaxing ambiance.", null, "~/Image/product3.jpeg", 10.99m, "Vanilla Velvet", 150, "Vanilla", "8 oz" },
                    { 12, null, 2, "Classic Ceramic", "Enhance your home with the Classic Design Aroma Diffuser.This stylish diffuser adds a calming touch to any room with soothing essential oil scents and a gentle mist.Ideal for creating a relaxing atmosphere and  a touch of elegance.", 49.99m, "~/Image/product5.jpeg", 79.99m, "Classic Design Aroma Diffuser", 50, null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "AddressID", "Birthday", "Email", "FirstName", "FullName", "Gender", "LastName", "Password", "PhoneNo", "Role" },
                values: new object[,]
                {
                    { 1, null, new DateOnly(1998, 12, 2), "customer@example.com", "Cus", "Cus Tomer", "Male", "Tomer", "Password1", null, "Customer" },
                    { 2, null, null, "employee@example.com", "Empl", "Empl Oyee", "Male", "Oyee", "Passw0rd", null, "Employee" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "AddressID", "CustomerID", "OrderDate", "OrderStatus", "TotalPrice" },
                values: new object[] { 1, 1, 1, new DateTime(2024, 7, 26, 13, 8, 26, 414, DateTimeKind.Local).AddTicks(6878), 0, 35.98m });

            migrationBuilder.InsertData(
                table: "OrderTrackings",
                columns: new[] { "TrackingID", "OrderEmail", "OrderID", "PostalCode", "StatusUpdate", "UpdateTime" },
                values: new object[] { 1, "customer@example.com", 1, "2308", "Order placed", new DateTime(2024, 7, 26, 5, 8, 26, 414, DateTimeKind.Utc).AddTicks(6920) });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_AddressID",
                table: "Admins",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AddressID",
                table: "Orders",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderTrackings_OrderID",
                table: "OrderTrackings",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AddressID",
                table: "Users",
                column: "AddressID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "OrderTrackings");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}

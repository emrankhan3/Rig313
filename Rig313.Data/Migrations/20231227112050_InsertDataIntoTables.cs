using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Rig313.Data.Migrations
{
    /// <inheritdoc />
    public partial class InsertDataIntoTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Description", "DisplayOrder", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "Laptop Description", 1, "SampleImageUrl", "Laptop" },
                    { 2, "Desktop Description", 2, "SampleImageUrl2", "Desktop" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "Phone", "UserRole", "Username" },
                values: new object[,]
                {
                    { 1, "admin@rig313.com", "amdin", "+880123456789", 1, "admin" },
                    { 89, "customer@rig313.com", "customer", "+880123456780", 2, "customer" }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Address", "Name", "UserId" },
                values: new object[] { 89, "Customer Address", "Customer 1", 89 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Laptop1 Description", 0.0, null, "Laptop 1", 60000.0 },
                    { 2, 1, "Laptop2 Description", 0.0, null, "Laptop 2", 63000.0 },
                    { 3, 2, "Desktop1 Description", 0.050000000000000003, null, "Desktop 1", 48000.0 },
                    { 4, 2, "Desktop2 Description", 0.0, null, "Desktop 2", 50000.0 }
                });

            migrationBuilder.InsertData(
                table: "UserPermissions",
                columns: new[] { "Id", "CategoryManager", "Customer", "CustomerManager", "InventoryManager", "ProductManager", "SuperAdmin", "UserId" },
                values: new object[,]
                {
                    { 1, true, false, true, true, true, true, 1 },
                    { 89, false, true, false, false, false, false, 89 }
                });

            migrationBuilder.InsertData(
                table: "Inventory",
                columns: new[] { "Id", "Delivered", "OnPending", "OnShipped", "ProductId", "StockAvailable" },
                values: new object[,]
                {
                    { 1, 0, 0, 0, 1, 30 },
                    { 2, 0, 0, 0, 2, 20 },
                    { 3, 0, 0, 0, 3, 45 },
                    { 4, 0, 0, 0, 4, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}

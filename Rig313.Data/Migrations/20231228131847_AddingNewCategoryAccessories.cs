using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rig313.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingNewCategoryAccessories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Description", "DisplayOrder", "ImageUrl", "Name" },
                values: new object[] { 3, "Accessories", 3, "SampleImageUrl3", "Accessories" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

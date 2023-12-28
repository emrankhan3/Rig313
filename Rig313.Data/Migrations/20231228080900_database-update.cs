using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rig313.Data.Migrations
{
    /// <inheritdoc />
    public partial class databaseupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/rig313.appspot.com/o/product01.png?alt=media&token=f6ab9d5e-2916-4bd9-9905-9ec8e9c37cf3");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/rig313.appspot.com/o/product03.png?alt=media&token=0d819674-53bf-41d0-8068-9b840799475e");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/rig313.appspot.com/o/product06.png?alt=media&token=94a3f820-5f16-4aa3-91ba-2c35ae221f69");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://firebasestorage.googleapis.com/v0/b/rig313.appspot.com/o/product08.png?alt=media&token=0b023b8b-533a-4b65-8f24-9183803a9e42");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: null);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineGroceryHub.Infrastructure.Migrations
{
    public partial class SeedUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://www.ebag.bg/en/products/images/133238/200/webp");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://i0.wp.com/packagingoftheworld.com/wp-content/uploads/2023/12/02_LIVITY_3.jpg?fit=1181%2C1181&ssl=1");
        }
    }
}

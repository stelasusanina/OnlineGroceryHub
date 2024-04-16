using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineGroceryHub.Infrastructure.Migrations
{
    public partial class asd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shoppingcarts",
                columns: new[] { "Id", "ApplicationUserId", "Total" },
                values: new object[] { "00359143-b644-4d40-ad75-b35df9341f0b", "00359143-b644-4d40-ad75-b35df9341f0b", 0m });

            migrationBuilder.InsertData(
                table: "Wishlists",
                columns: new[] { "Id", "ApplicationUserId" },
                values: new object[] { "00359143-b644-4d40-ad75-b35df9341f0b", "00359143-b644-4d40-ad75-b35df9341f0b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shoppingcarts",
                keyColumn: "Id",
                keyValue: "00359143-b644-4d40-ad75-b35df9341f0b");

            migrationBuilder.DeleteData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: "00359143-b644-4d40-ad75-b35df9341f0b");
        }
    }
}

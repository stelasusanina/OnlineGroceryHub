using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineGroceryHub.Infrastructure.Migrations
{
    public partial class applicationUserChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Wishlists");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Wishlists",
                type: "nvarchar(450)",
                nullable: false,
                comment: "Wishlist user identifier",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Wishlists",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldComment: "Wishlist user identifier");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Wishlists",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "Wishlist user identifier");
        }
    }
}

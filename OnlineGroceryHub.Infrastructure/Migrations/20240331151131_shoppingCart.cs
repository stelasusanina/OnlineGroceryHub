using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineGroceryHub.Infrastructure.Migrations
{
    public partial class shoppingCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShoppingcartId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Shoppingcarts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Shopping cart identifier"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Shopping cart user identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shoppingcarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shoppingcarts_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "User shopping cart");

            migrationBuilder.CreateTable(
                name: "ShoppingcartsProducts",
                columns: table => new
                {
                    ShoppingcartId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Shopping cart identifier"),
                    ProductId = table.Column<int>(type: "int", nullable: false, comment: "Product identifier"),
                    ProductAmount = table.Column<int>(type: "int", nullable: false, comment: "Amount of certain product")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingcartsProducts", x => new { x.ShoppingcartId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ShoppingcartsProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingcartsProducts_Shoppingcarts_ShoppingcartId",
                        column: x => x.ShoppingcartId,
                        principalTable: "Shoppingcarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Mapping table of Shopping cart and Product");

            migrationBuilder.CreateIndex(
                name: "IX_Shoppingcarts_ApplicationUserId",
                table: "Shoppingcarts",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingcartsProducts_ProductId",
                table: "ShoppingcartsProducts",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingcartsProducts");

            migrationBuilder.DropTable(
                name: "Shoppingcarts");

            migrationBuilder.DropColumn(
                name: "ShoppingcartId",
                table: "AspNetUsers");
        }
    }
}

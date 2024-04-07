using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineGroceryHub.Infrastructure.Migrations
{
    public partial class orders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductsOrders",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false, comment: "Product identifier"),
                    OrderId = table.Column<int>(type: "int", nullable: false, comment: "Order identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsOrders", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductsOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsOrders_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Mapping table of Product and Order");

            migrationBuilder.CreateTable(
                name: "UsersOrders",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User identifier"),
                    OrderId = table.Column<int>(type: "int", nullable: false, comment: "Order identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersOrders", x => new { x.OrderId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UsersOrders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Mapping table of User and Order");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsOrders_ProductId",
                table: "ProductsOrders",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersOrders_UserId",
                table: "UsersOrders",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductsOrders");

            migrationBuilder.DropTable(
                name: "UsersOrders");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}

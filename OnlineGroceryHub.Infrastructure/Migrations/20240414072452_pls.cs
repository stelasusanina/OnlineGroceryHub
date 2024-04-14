using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineGroceryHub.Infrastructure.Migrations
{
    public partial class pls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00359143-b644-4d40-ad75-b35df9341f0b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a2f0ce7-97a9-4806-a706-5e239efd4dd2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShoppingcartId", "TwoFactorEnabled", "UserName", "WishListId" },
                values: new object[] { "00359143-b644-4d40-ad75-b35df9341f0b", 0, "93504a04-5fba-47e1-bec8-eebb308ef287", "stela1234@abv.bg", false, "Stela", "Susanina", false, null, null, null, "AQAAAAEAACcQAAAAEDYw/5MBkaXi8Tp8fYf7u0qvr2ANqUYJTrt7m8Hzksv5FVAKHCNDgmArJEkcjBdIsg==", null, false, "e9eac395-08a1-4164-8a46-980328c6345e", "00359143-b644-4d40-ad75-b35df9341f0b", false, "stela1234@abv.bg", "00359143-b644-4d40-ad75-b35df9341f0b" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShoppingcartId", "TwoFactorEnabled", "UserName", "WishListId" },
                values: new object[] { "9a2f0ce7-97a9-4806-a706-5e239efd4dd2", 0, "7c3233a1-cfce-4597-8657-0e8625833f38", "admin@admin.com", false, "Admin", "Admin", false, null, null, null, "AQAAAAEAACcQAAAAEKs541IFqSYbZ8Ao+Y4ZQWD+EmnKj/E1vtNDOGfKIl/b20QEJvzCEkb9yuLNNcQwEg==", null, false, "34c00147-9e79-4323-81c5-237e239483bb", null, false, "admin@admin.com", null });
        }
    }
}

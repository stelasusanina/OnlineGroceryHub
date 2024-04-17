using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineGroceryHub.Infrastructure.Migrations
{
    public partial class SeedPhotosUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "https://m.ebag.bg/products/images/119203/800");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "https://m.ebag.bg/en/products/images/88241/800");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "https://cdncloudcart.com/16372/products/images/74170/rois-premium-mix-adki-miks-150-g-image_63bc1eb232b77_1920x1920.jpeg?1673273025");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcTmge-RhucLiDFCDVFhnUyopGD6zMyhAhJx-Bmf4AmEdJXtYiB-");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcRQiXgr6jKo3FyZ9d3K9oJil1gaQvC7ocdKpO79C1vdLE1UQzjT");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQEVfKkNqwuq73bx1IDhsJldNqSlb0vOMSvzsNqj6y_NQi6s3Ro");
        }
    }
}

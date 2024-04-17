using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineGroceryHub.Infrastructure.Migrations
{
    public partial class newSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "SubCategoryId",
                value: 6);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Discount", "ExpirationDate", "ImageUrl", "Name", "Origin", "Price", "Quantity", "SubCategoryId" },
                values: new object[,]
                {
                    { 11, "Ingredients: Blueberries 100%", null, new DateTime(2026, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcTmge-RhucLiDFCDVFhnUyopGD6zMyhAhJx-Bmf4AmEdJXtYiB-", "Blueberries Pinguin", "Belgium", 19.99m, 1.0, 4 },
                    { 12, "Mix Magre Green Energy for Smoothie Frozen 400 g", 15, new DateTime(2026, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcRQiXgr6jKo3FyZ9d3K9oJil1gaQvC7ocdKpO79C1vdLE1UQzjT", "Mix Magre Green Energy for Smoothie Frozen", "EU", 4.99m, 0.40000000000000002, 4 }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 8, 7, "Nuts" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Discount", "ExpirationDate", "ImageUrl", "Name", "Origin", "Price", "Quantity", "SubCategoryId" },
                values: new object[] { 13, "Nuts Rois Premium Mix Roasted", 12, new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQEVfKkNqwuq73bx1IDhsJldNqSlb0vOMSvzsNqj6y_NQi6s3Ro", "Nuts Rois Premium Mix Roasted", "Bulgaria", 7.99m, 0.14999999999999999, 8 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "SubCategoryId",
                value: 4);
        }
    }
}

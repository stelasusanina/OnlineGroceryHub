using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineGroceryHub.Infrastructure.Migrations
{
    public partial class NewPhotosForProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2024, 3, 17, 19, 2, 54, 620, DateTimeKind.Local).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CommentDate",
                value: new DateTime(2024, 3, 17, 19, 2, 54, 620, DateTimeKind.Local).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://m.ebag.bg/en/products/images/133238/800");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://www.nescafe.com/bg/sites/default/files/2023-08/11_3.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://m.ebag.bg/en/products/images/85639/800");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://m.ebag.bg/en/products/images/111780/800");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://m.ebag.bg/en/products/images/125683/800");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2024, 3, 15, 13, 23, 42, 560, DateTimeKind.Local).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CommentDate",
                value: new DateTime(2024, 3, 15, 13, 23, 42, 560, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://www.ebag.bg/en/products/images/133238/200/webp");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcRDmVUgwXGAkU8D7V6kBnl4NvDI9FUcY63hNZdP3J0s_H2cqcPN");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcRPlEr7YWqKnhB4KfPQvFyhWSjALQkLtyYd_6ehdG3F6AVzQoQB");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR7aiWvHuLvvN50dBQ_0L6X5WHKVaXTYjKN0tNjvF2LbnJkTfgW");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://www.ebag.bg/en/products/images/137845/200/webp");
        }
    }
}

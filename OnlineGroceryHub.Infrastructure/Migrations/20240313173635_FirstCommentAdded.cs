using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineGroceryHub.Infrastructure.Migrations
{
    public partial class FirstCommentAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2024, 3, 13, 19, 36, 35, 382, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ArticleId", "Author", "CommentDate", "Content" },
                values: new object[] { 1, null, "Eva Selhub", new DateTime(2024, 3, 13, 19, 36, 35, 382, DateTimeKind.Local).AddTicks(5686), "Great article! Learned a lot from it!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2024, 3, 13, 19, 28, 27, 408, DateTimeKind.Local).AddTicks(9376));
        }
    }
}

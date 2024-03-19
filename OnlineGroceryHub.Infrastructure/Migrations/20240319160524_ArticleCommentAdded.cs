using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineGroceryHub.Infrastructure.Migrations
{
    public partial class ArticleCommentAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2024, 3, 19, 18, 5, 23, 803, DateTimeKind.Local).AddTicks(6145));

            migrationBuilder.InsertData(
                table: "ArticlesComments",
                columns: new[] { "ArticleId", "CommentId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CommentDate",
                value: new DateTime(2024, 3, 19, 18, 5, 23, 803, DateTimeKind.Local).AddTicks(6243));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArticlesComments",
                keyColumns: new[] { "ArticleId", "CommentId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2024, 3, 19, 18, 0, 5, 767, DateTimeKind.Local).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CommentDate",
                value: new DateTime(2024, 3, 19, 18, 0, 5, 767, DateTimeKind.Local).AddTicks(3412));
        }
    }
}

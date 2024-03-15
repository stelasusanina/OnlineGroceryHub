using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineGroceryHub.Infrastructure.Migrations
{
    public partial class FirstArticleCommentAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2024, 3, 15, 13, 23, 42, 560, DateTimeKind.Local).AddTicks(556));

            migrationBuilder.InsertData(
                table: "ArticlesComments",
                columns: new[] { "ArticleId", "CommentId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CommentDate",
                value: new DateTime(2024, 3, 15, 13, 23, 42, 560, DateTimeKind.Local).AddTicks(624));
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
                value: new DateTime(2024, 3, 13, 19, 36, 35, 382, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CommentDate",
                value: new DateTime(2024, 3, 13, 19, 36, 35, 382, DateTimeKind.Local).AddTicks(5686));
        }
    }
}

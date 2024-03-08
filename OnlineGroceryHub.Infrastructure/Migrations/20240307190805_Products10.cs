using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineGroceryHub.Infrastructure.Migrations
{
    public partial class Products10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Discount", "ExpirationDate", "ImageUrl", "Name", "Origin", "Price", "Quantity", "SubCategoryId" },
                values: new object[,]
                {
                    { 4, "Prepare it with natural fresh whole milk and without taking away any ingredients. The cheese thus acquires a specific taste. The traditional Bulgarian cultures of Lactobacilus bulgaricus and Streptococcus thermophilus are used for the starter, and this also adds probiotic properties. The cheese contains huge amounts of protein, also the very useful fatty acids that are characteristic of the milk of the pasture cows.", null, new DateTime(2024, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://production.balevbiomarket-contents.com/p/020022/sirene-ot-krave-mlqko-zoom.jpeg", "Organic Cow Cheese Harmonica", "Bulgaria", 12.99m, 0.40000000000000002, 3 },
                    { 5, "Maretti are crispy and delicious oven baked bite-size chips offered in variety of rich flavors with Mediterranean twist. Our Bruschette style chips are oven baked in small batches and are made in traditional Bruschette style with two sides of taste – Both good. Only one side seasoned – that gives you a choice how to eat it – spices down for more intensive taste and spices up for delicate taste.", 5, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.superbagplovdiv.bg/media/99/27815.png", "Bruschette Maretti Cream & Onion", "Bulgaria", 1.49m, 0.070000000000000007, 7 },
                    { 6, "Apples Gala", null, null, "https://i5.walmartimages.com/asr/c16b1c2d-6fc9-42c3-865f-575b2dcacb05.b3094ff47e723cb532823dbf849c95a7.jpeg?odnHeight=768&odnWidth=768&odnBg=FFFFFF", "Apples Gala", "Bulgaria", 3.29m, 1.0, 1 },
                    { 7, "Nescafe Classic Crema   It has a strong taste and aroma combined with seductive cream for even more pleasant awakening! Prepare easily and quickly with only hot water.", 10, new DateTime(2025, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcRDmVUgwXGAkU8D7V6kBnl4NvDI9FUcY63hNZdP3J0s_H2cqcPN", "Coffee Nescafe Classic Crema Instant", "France", 8.99m, 0.095000000000000001, 5 },
                    { 8, "Chicken Roso Chilled about 1.700 kg. The price for one piece.", null, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcRPlEr7YWqKnhB4KfPQvFyhWSjALQkLtyYd_6ehdG3F6AVzQoQB", "Chicken Roso Chilled", "Bulgaria", 21.80m, 1.7, 4 },
                    { 9, "Hand-made chickens with a balanced, natural taste that brings the authentic taste of home-made brine! Each ingredient is precisely chosen, paying special attention to quality and usefulness!", null, new DateTime(2024, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR7aiWvHuLvvN50dBQ_0L6X5WHKVaXTYjKN0tNjvF2LbnJkTfgW", "Salted Sticks Scala", "Bulgaria", 3.49m, 0.10000000000000001, 7 },
                    { 10, "Cucumbers from Greece", null, null, "https://www.ebag.bg/en/products/images/137845/200/webp", "Cucumbers", "Greece", 5.49m, 1.0, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}

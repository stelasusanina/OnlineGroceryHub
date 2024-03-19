using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineGroceryHub.Infrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Article idntifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, comment: "Article title"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Article image"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Article content"),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Article publish date")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                },
                comment: "Article model");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Category identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Category name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                },
                comment: "Product category");

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Comment identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Author = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Comment author"),
                    Content = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "Comment content"),
                    CommentDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Comment date")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                },
                comment: "Article comment");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Subcategory identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Subcategory name"),
                    CategoryId = table.Column<int>(type: "int", nullable: false, comment: "Product category")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Product subcategory");

            migrationBuilder.CreateTable(
                name: "ArticlesComments",
                columns: table => new
                {
                    ArticleId = table.Column<int>(type: "int", nullable: false, comment: "Article identifier"),
                    CommentId = table.Column<int>(type: "int", nullable: false, comment: "Comment identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticlesComments", x => new { x.ArticleId, x.CommentId });
                    table.ForeignKey(
                        name: "FK_ArticlesComments_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticlesComments_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Mapping table for Article and Comment");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Product identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, comment: "Product name"),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "Product description"),
                    Quantity = table.Column<double>(type: "float", nullable: false, comment: "Product quantity"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "Product price"),
                    Discount = table.Column<int>(type: "int", nullable: true, comment: "Product discount"),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Product expiration date"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Product image"),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Product origin"),
                    SubCategoryId = table.Column<int>(type: "int", nullable: false, comment: "Product subcategory")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Product model");

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Content", "ImageUrl", "PublishDate", "Title" },
                values: new object[] { 1, "Think about it. Your brain is always \"on.\" It takes care of your thoughts and movements, your breathing and heartbeat, your senses — it works hard 24/7, even while you're asleep. This means your brain requires a constant supply of fuel. That \"fuel\" comes from the foods you eat — and what's in that fuel makes all the difference. Put simply, what you eat directly affects the structure and function of your brain and, ultimately, your mood.\r\n\r\nLike an expensive car, your brain functions best when it gets only premium fuel. Eating high-quality foods that contain lots of vitamins, minerals, and antioxidants nourishes the brain and protects it from oxidative stress — the \"waste\" (free radicals) produced when the body uses oxygen, which can damage cells.\r\n\r\nUnfortunately, just like an expensive car, your brain can be damaged if you ingest anything other than premium fuel. If substances from \"low-premium\" fuel (such as what you get from processed or refined foods) get to the brain, it has little ability to get rid of them. Diets high in refined sugars, for example, are harmful to the brain. In addition to worsening your body's regulation of insulin, they also promote inflammation and oxidative stress. Multiple studies have found a correlation between a diet high in refined sugars and impaired brain function — and even a worsening of symptoms of mood disorders, such as depression.\r\n\r\nIt makes sense. If your brain is deprived of good-quality nutrition, or if free radicals or damaging inflammatory cells are circulating within the brain's enclosed space, further contributing to brain tissue injury, consequences are to be expected. What's interesting is that for many years, the medical field did not fully acknowledge the connection between mood and food.\r\n\r\nToday, fortunately, the burgeoning field of nutritional psychiatry is finding there are many consequences and correlations between not only what you eat, how you feel, and how you ultimately behave, but also the kinds of bacteria that live in your gut.\r\n\r\nHow the foods you eat affect your mental health\r\nSerotonin is a neurotransmitter that helps regulate sleep and appetite, mediate moods, and inhibit pain. Since about 95% of your serotonin is produced in your gastrointestinal tract, and your gastrointestinal tract is lined with a hundred million nerve cells, or neurons, it makes sense that the inner workings of your digestive system don't just help you digest food, but also guide your emotions. What's more, the function of these neurons — and the production of neurotransmitters like serotonin — is highly influenced by the billions of \"good\" bacteria that make up your intestinal microbiome. These bacteria play an essential role in your health. They protect the lining of your intestines and ensure they provide a strong barrier against toxins and \"bad\" bacteria; they limit inflammation; they improve how well you absorb nutrients from your food; and they activate neural pathways that travel directly between the gut and the brain.\r\n\r\nStudies have compared \"traditional\" diets, like the Mediterranean diet and the traditional Japanese diet, to a typical \"Western\" diet and have shown that the risk of depression is 25% to 35% lower in those who eat a traditional diet. Scientists account for this difference because these traditional diets tend to be high in vegetables, fruits, unprocessed grains, and fish and seafood, and to contain only modest amounts of lean meats and dairy. They are also void of processed and refined foods and sugars, which are staples of the \"Western\" dietary pattern. In addition, many of these unprocessed foods are fermented, and therefore act as natural probiotics.\r\n\r\nThis may sound implausible to you, but the notion that good bacteria not only influence what your gut digests and absorbs, but that they also affect the degree of inflammation throughout your body, as well as your mood and energy level, is gaining traction among researchers.\r\n\r\nNutritional psychiatry: What does it mean for you?\r\nStart paying attention to how eating different foods makes you feel — not just in the moment, but the next day. Try eating a \"clean\" diet for two to three weeks — that means cutting out all processed foods and sugar. See how you feel. Then slowly introduce foods back into your diet, one by one, and see how you feel.\r\n\r\nWhen some people \"go clean,\" they cannot believe how much better they feel both physically and emotionally, and how much worse they then feel when they reintroduce the foods that are known to enhance inflammation.", "https://d2jx2rerrg6sh3.cloudfront.net/images/Article_Images/ImageForArticle_21990_16425136005131910.jpg", new DateTime(2024, 3, 19, 18, 0, 5, 767, DateTimeKind.Local).AddTicks(3345), "Nutritional psychiatry: Your brain on food" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Fruits" },
                    { 2, "Vegetables" },
                    { 3, "Dairy" },
                    { 4, "Frozen" },
                    { 5, "Drinks" },
                    { 6, "Meat and Fish" },
                    { 7, "Packaged Foods" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Author", "CommentDate", "Content" },
                values: new object[] { 1, "Eva Selhub", new DateTime(2024, 3, 19, 18, 0, 5, 767, DateTimeKind.Local).AddTicks(3412), "Great article! Learned a lot from it!" });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Apples" },
                    { 2, 2, "Cucumbers" },
                    { 3, 3, "Cheese" },
                    { 4, 4, "Frozen Meat" },
                    { 5, 5, "Coffee" },
                    { 6, 6, "Chicken" },
                    { 7, 7, "Snacks" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Discount", "ExpirationDate", "ImageUrl", "Name", "Origin", "Price", "Quantity", "SubCategoryId" },
                values: new object[,]
                {
                    { 1, "\"Dimitar Madjarov\" cheeses are traditional Bulgarian products, produced from 100% cow, sheep, goat and buffalo milk and Bulgarian sourdough, with a characteristic pale yellow color, well-expressed aroma and mild taste.", null, new DateTime(2024, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://cdncloudcart.com/16398/products/images/39837/kaskaval-ot-krave-mlako-madzarov-bds-420-g-image_5ea2d3e81638e_1280x1280.png?1587732297", "Yellow Cheese Madjarov BDS from Cow Milk", "Bulgaria", 12.99m, 0.38, 3 },
                    { 2, "Ingredients: 60% Robusta and 40% Arabica; Intensity: 8/10", null, new DateTime(2025, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://i0.wp.com/avanti-bg.com/wp-content/uploads/2020/09/%D0%9A%D0%90%D0%A4%D0%95-%D0%9B%D0%90%D0%92%D0%90%D0%A6%D0%90-%D0%9A%D0%A0%D0%95%D0%9C%D0%90-%D0%90%D0%A0%D0%9E%D0%9C%D0%90-1%D0%9A%D0%93.jpg?fit=1500%2C1500&ssl=1", "Coffee Lavazza Crema e Aroma Grains", "Poland", 30.99m, 1.0, 5 },
                    { 3, "In the development of our recipe, we were inspired by a unique taste profile born back 800 years ago in the small Cheddar village in the UK. Right there, in the caves, close to nature, an exclusive taste palette was born – rich, mellow and slightly salty. It conquered the world.", 15, new DateTime(2025, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://m.ebag.bg/en/products/images/133238/800", "Rice Chips Livity Cheddar", "Bulgaria", 1.99m, 0.059999999999999998, 7 },
                    { 4, "Prepare it with natural fresh whole milk and without taking away any ingredients. The cheese thus acquires a specific taste. The traditional Bulgarian cultures of Lactobacilus bulgaricus and Streptococcus thermophilus are used for the starter, and this also adds probiotic properties. The cheese contains huge amounts of protein, also the very useful fatty acids that are characteristic of the milk of the pasture cows.", null, new DateTime(2024, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://production.balevbiomarket-contents.com/p/020022/sirene-ot-krave-mlqko-zoom.jpeg", "Organic Cow Cheese Harmonica", "Bulgaria", 12.99m, 0.40000000000000002, 3 },
                    { 5, "Maretti are crispy and delicious oven baked bite-size chips offered in variety of rich flavors with Mediterranean twist. Our Bruschette style chips are oven baked in small batches and are made in traditional Bruschette style with two sides of taste – Both good. Only one side seasoned – that gives you a choice how to eat it – spices down for more intensive taste and spices up for delicate taste.", 5, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.superbagplovdiv.bg/media/99/27815.png", "Bruschette Maretti Cream & Onion", "Bulgaria", 1.49m, 0.070000000000000007, 7 },
                    { 6, "Apples Gala", null, null, "https://i5.walmartimages.com/asr/c16b1c2d-6fc9-42c3-865f-575b2dcacb05.b3094ff47e723cb532823dbf849c95a7.jpeg?odnHeight=768&odnWidth=768&odnBg=FFFFFF", "Apples Gala", "Bulgaria", 3.29m, 1.0, 1 },
                    { 7, "Nescafe Classic Crema   It has a strong taste and aroma combined with seductive cream for even more pleasant awakening! Prepare easily and quickly with only hot water.", 10, new DateTime(2025, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.nescafe.com/bg/sites/default/files/2023-08/11_3.png", "Coffee Nescafe Classic Crema Instant", "France", 8.99m, 0.095000000000000001, 5 },
                    { 8, "Chicken Roso Chilled about 1.700 kg. The price for one piece.", null, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://m.ebag.bg/en/products/images/85639/800", "Chicken Roso Chilled", "Bulgaria", 21.80m, 1.7, 4 },
                    { 9, "Hand-made chickens with a balanced, natural taste that brings the authentic taste of home-made brine! Each ingredient is precisely chosen, paying special attention to quality and usefulness!", null, new DateTime(2024, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://m.ebag.bg/en/products/images/111780/800", "Salted Sticks Scala", "Bulgaria", 3.49m, 0.10000000000000001, 7 },
                    { 10, "Cucumbers from Greece", null, null, "https://m.ebag.bg/en/products/images/125683/800", "Cucumbers", "Greece", 5.49m, 1.0, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticlesComments_CommentId",
                table: "ArticlesComments",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubCategoryId",
                table: "Products",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticlesComments");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineGroceryHub.Data;

#nullable disable

namespace OnlineGroceryHub.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240319160006_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("OnlineGroceryHub.Infrastructure.Data.Models.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Article idntifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Article content");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Article image");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2")
                        .HasComment("Article publish date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasComment("Article title");

                    b.HasKey("Id");

                    b.ToTable("Articles");

                    b.HasComment("Article model");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Think about it. Your brain is always \"on.\" It takes care of your thoughts and movements, your breathing and heartbeat, your senses — it works hard 24/7, even while you're asleep. This means your brain requires a constant supply of fuel. That \"fuel\" comes from the foods you eat — and what's in that fuel makes all the difference. Put simply, what you eat directly affects the structure and function of your brain and, ultimately, your mood.\r\n\r\nLike an expensive car, your brain functions best when it gets only premium fuel. Eating high-quality foods that contain lots of vitamins, minerals, and antioxidants nourishes the brain and protects it from oxidative stress — the \"waste\" (free radicals) produced when the body uses oxygen, which can damage cells.\r\n\r\nUnfortunately, just like an expensive car, your brain can be damaged if you ingest anything other than premium fuel. If substances from \"low-premium\" fuel (such as what you get from processed or refined foods) get to the brain, it has little ability to get rid of them. Diets high in refined sugars, for example, are harmful to the brain. In addition to worsening your body's regulation of insulin, they also promote inflammation and oxidative stress. Multiple studies have found a correlation between a diet high in refined sugars and impaired brain function — and even a worsening of symptoms of mood disorders, such as depression.\r\n\r\nIt makes sense. If your brain is deprived of good-quality nutrition, or if free radicals or damaging inflammatory cells are circulating within the brain's enclosed space, further contributing to brain tissue injury, consequences are to be expected. What's interesting is that for many years, the medical field did not fully acknowledge the connection between mood and food.\r\n\r\nToday, fortunately, the burgeoning field of nutritional psychiatry is finding there are many consequences and correlations between not only what you eat, how you feel, and how you ultimately behave, but also the kinds of bacteria that live in your gut.\r\n\r\nHow the foods you eat affect your mental health\r\nSerotonin is a neurotransmitter that helps regulate sleep and appetite, mediate moods, and inhibit pain. Since about 95% of your serotonin is produced in your gastrointestinal tract, and your gastrointestinal tract is lined with a hundred million nerve cells, or neurons, it makes sense that the inner workings of your digestive system don't just help you digest food, but also guide your emotions. What's more, the function of these neurons — and the production of neurotransmitters like serotonin — is highly influenced by the billions of \"good\" bacteria that make up your intestinal microbiome. These bacteria play an essential role in your health. They protect the lining of your intestines and ensure they provide a strong barrier against toxins and \"bad\" bacteria; they limit inflammation; they improve how well you absorb nutrients from your food; and they activate neural pathways that travel directly between the gut and the brain.\r\n\r\nStudies have compared \"traditional\" diets, like the Mediterranean diet and the traditional Japanese diet, to a typical \"Western\" diet and have shown that the risk of depression is 25% to 35% lower in those who eat a traditional diet. Scientists account for this difference because these traditional diets tend to be high in vegetables, fruits, unprocessed grains, and fish and seafood, and to contain only modest amounts of lean meats and dairy. They are also void of processed and refined foods and sugars, which are staples of the \"Western\" dietary pattern. In addition, many of these unprocessed foods are fermented, and therefore act as natural probiotics.\r\n\r\nThis may sound implausible to you, but the notion that good bacteria not only influence what your gut digests and absorbs, but that they also affect the degree of inflammation throughout your body, as well as your mood and energy level, is gaining traction among researchers.\r\n\r\nNutritional psychiatry: What does it mean for you?\r\nStart paying attention to how eating different foods makes you feel — not just in the moment, but the next day. Try eating a \"clean\" diet for two to three weeks — that means cutting out all processed foods and sugar. See how you feel. Then slowly introduce foods back into your diet, one by one, and see how you feel.\r\n\r\nWhen some people \"go clean,\" they cannot believe how much better they feel both physically and emotionally, and how much worse they then feel when they reintroduce the foods that are known to enhance inflammation.",
                            ImageUrl = "https://d2jx2rerrg6sh3.cloudfront.net/images/Article_Images/ImageForArticle_21990_16425136005131910.jpg",
                            PublishDate = new DateTime(2024, 3, 19, 18, 0, 5, 767, DateTimeKind.Local).AddTicks(3345),
                            Title = "Nutritional psychiatry: Your brain on food"
                        });
                });

            modelBuilder.Entity("OnlineGroceryHub.Infrastructure.Data.Models.ArticleComment", b =>
                {
                    b.Property<int>("ArticleId")
                        .HasColumnType("int")
                        .HasComment("Article identifier");

                    b.Property<int>("CommentId")
                        .HasColumnType("int")
                        .HasComment("Comment identifier");

                    b.HasKey("ArticleId", "CommentId");

                    b.HasIndex("CommentId");

                    b.ToTable("ArticlesComments");

                    b.HasComment("Mapping table for Article and Comment");
                });

            modelBuilder.Entity("OnlineGroceryHub.Infrastructure.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Category identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Category name");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasComment("Product category");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            Name = "Dairy"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Frozen"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Vegetables"
                        },
                        new
                        {
                            Id = 1,
                            Name = "Fruits"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Drinks"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Packaged Foods"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Meat and Fish"
                        });
                });

            modelBuilder.Entity("OnlineGroceryHub.Infrastructure.Data.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Comment identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Comment author");

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("datetime2")
                        .HasComment("Comment date");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasComment("Comment content");

                    b.HasKey("Id");

                    b.ToTable("Comments");

                    b.HasComment("Article comment");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Eva Selhub",
                            CommentDate = new DateTime(2024, 3, 19, 18, 0, 5, 767, DateTimeKind.Local).AddTicks(3412),
                            Content = "Great article! Learned a lot from it!"
                        });
                });

            modelBuilder.Entity("OnlineGroceryHub.Infrastructure.Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Product identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasComment("Product description");

                    b.Property<int?>("Discount")
                        .HasColumnType("int")
                        .HasComment("Product discount");

                    b.Property<DateTime?>("ExpirationDate")
                        .HasColumnType("datetime2")
                        .HasComment("Product expiration date");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Product image");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasComment("Product name");

                    b.Property<string>("Origin")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Product origin");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Product price");

                    b.Property<double>("Quantity")
                        .HasColumnType("float")
                        .HasComment("Product quantity");

                    b.Property<int>("SubCategoryId")
                        .HasColumnType("int")
                        .HasComment("Product subcategory");

                    b.HasKey("Id");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("Products");

                    b.HasComment("Product model");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            Description = "In the development of our recipe, we were inspired by a unique taste profile born back 800 years ago in the small Cheddar village in the UK. Right there, in the caves, close to nature, an exclusive taste palette was born – rich, mellow and slightly salty. It conquered the world.",
                            Discount = 15,
                            ExpirationDate = new DateTime(2025, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "https://m.ebag.bg/en/products/images/133238/800",
                            Name = "Rice Chips Livity Cheddar",
                            Origin = "Bulgaria",
                            Price = 1.99m,
                            Quantity = 0.059999999999999998,
                            SubCategoryId = 7
                        },
                        new
                        {
                            Id = 2,
                            Description = "Ingredients: 60% Robusta and 40% Arabica; Intensity: 8/10",
                            ExpirationDate = new DateTime(2025, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "https://i0.wp.com/avanti-bg.com/wp-content/uploads/2020/09/%D0%9A%D0%90%D0%A4%D0%95-%D0%9B%D0%90%D0%92%D0%90%D0%A6%D0%90-%D0%9A%D0%A0%D0%95%D0%9C%D0%90-%D0%90%D0%A0%D0%9E%D0%9C%D0%90-1%D0%9A%D0%93.jpg?fit=1500%2C1500&ssl=1",
                            Name = "Coffee Lavazza Crema e Aroma Grains",
                            Origin = "Poland",
                            Price = 30.99m,
                            Quantity = 1.0,
                            SubCategoryId = 5
                        },
                        new
                        {
                            Id = 1,
                            Description = "\"Dimitar Madjarov\" cheeses are traditional Bulgarian products, produced from 100% cow, sheep, goat and buffalo milk and Bulgarian sourdough, with a characteristic pale yellow color, well-expressed aroma and mild taste.",
                            ExpirationDate = new DateTime(2024, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "https://cdncloudcart.com/16398/products/images/39837/kaskaval-ot-krave-mlako-madzarov-bds-420-g-image_5ea2d3e81638e_1280x1280.png?1587732297",
                            Name = "Yellow Cheese Madjarov BDS from Cow Milk",
                            Origin = "Bulgaria",
                            Price = 12.99m,
                            Quantity = 0.38,
                            SubCategoryId = 3
                        },
                        new
                        {
                            Id = 6,
                            Description = "Apples Gala",
                            ImageUrl = "https://i5.walmartimages.com/asr/c16b1c2d-6fc9-42c3-865f-575b2dcacb05.b3094ff47e723cb532823dbf849c95a7.jpeg?odnHeight=768&odnWidth=768&odnBg=FFFFFF",
                            Name = "Apples Gala",
                            Origin = "Bulgaria",
                            Price = 3.29m,
                            Quantity = 1.0,
                            SubCategoryId = 1
                        },
                        new
                        {
                            Id = 5,
                            Description = "Maretti are crispy and delicious oven baked bite-size chips offered in variety of rich flavors with Mediterranean twist. Our Bruschette style chips are oven baked in small batches and are made in traditional Bruschette style with two sides of taste – Both good. Only one side seasoned – that gives you a choice how to eat it – spices down for more intensive taste and spices up for delicate taste.",
                            Discount = 5,
                            ExpirationDate = new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "https://www.superbagplovdiv.bg/media/99/27815.png",
                            Name = "Bruschette Maretti Cream & Onion",
                            Origin = "Bulgaria",
                            Price = 1.49m,
                            Quantity = 0.070000000000000007,
                            SubCategoryId = 7
                        },
                        new
                        {
                            Id = 4,
                            Description = "Prepare it with natural fresh whole milk and without taking away any ingredients. The cheese thus acquires a specific taste. The traditional Bulgarian cultures of Lactobacilus bulgaricus and Streptococcus thermophilus are used for the starter, and this also adds probiotic properties. The cheese contains huge amounts of protein, also the very useful fatty acids that are characteristic of the milk of the pasture cows.",
                            ExpirationDate = new DateTime(2024, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "https://production.balevbiomarket-contents.com/p/020022/sirene-ot-krave-mlqko-zoom.jpeg",
                            Name = "Organic Cow Cheese Harmonica",
                            Origin = "Bulgaria",
                            Price = 12.99m,
                            Quantity = 0.40000000000000002,
                            SubCategoryId = 3
                        },
                        new
                        {
                            Id = 8,
                            Description = "Chicken Roso Chilled about 1.700 kg. The price for one piece.",
                            ExpirationDate = new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "https://m.ebag.bg/en/products/images/85639/800",
                            Name = "Chicken Roso Chilled",
                            Origin = "Bulgaria",
                            Price = 21.80m,
                            Quantity = 1.7,
                            SubCategoryId = 4
                        },
                        new
                        {
                            Id = 7,
                            Description = "Nescafe Classic Crema   It has a strong taste and aroma combined with seductive cream for even more pleasant awakening! Prepare easily and quickly with only hot water.",
                            Discount = 10,
                            ExpirationDate = new DateTime(2025, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "https://www.nescafe.com/bg/sites/default/files/2023-08/11_3.png",
                            Name = "Coffee Nescafe Classic Crema Instant",
                            Origin = "France",
                            Price = 8.99m,
                            Quantity = 0.095000000000000001,
                            SubCategoryId = 5
                        },
                        new
                        {
                            Id = 10,
                            Description = "Cucumbers from Greece",
                            ImageUrl = "https://m.ebag.bg/en/products/images/125683/800",
                            Name = "Cucumbers",
                            Origin = "Greece",
                            Price = 5.49m,
                            Quantity = 1.0,
                            SubCategoryId = 2
                        },
                        new
                        {
                            Id = 9,
                            Description = "Hand-made chickens with a balanced, natural taste that brings the authentic taste of home-made brine! Each ingredient is precisely chosen, paying special attention to quality and usefulness!",
                            ExpirationDate = new DateTime(2024, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "https://m.ebag.bg/en/products/images/111780/800",
                            Name = "Salted Sticks Scala",
                            Origin = "Bulgaria",
                            Price = 3.49m,
                            Quantity = 0.10000000000000001,
                            SubCategoryId = 7
                        });
                });

            modelBuilder.Entity("OnlineGroceryHub.Infrastructure.Data.Models.SubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Subcategory identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasComment("Product category");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Subcategory name");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategories");

                    b.HasComment("Product subcategory");

                    b.HasData(
                        new
                        {
                            Id = 5,
                            CategoryId = 5,
                            Name = "Coffee"
                        },
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Name = "Apples"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 6,
                            Name = "Chicken"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Name = "Cheese"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 7,
                            Name = "Snacks"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 4,
                            Name = "Frozen Meat"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Name = "Cucumbers"
                        });
                });

            modelBuilder.Entity("OnlineGroceryHub.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("OnlineGroceryHub.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("OnlineGroceryHub.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineGroceryHub.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("OnlineGroceryHub.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineGroceryHub.Infrastructure.Data.Models.ArticleComment", b =>
                {
                    b.HasOne("OnlineGroceryHub.Infrastructure.Data.Models.Article", "Article")
                        .WithMany("ArticleComments")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineGroceryHub.Infrastructure.Data.Models.Comment", "Comment")
                        .WithMany("ArticleComments")
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("Comment");
                });

            modelBuilder.Entity("OnlineGroceryHub.Infrastructure.Data.Models.Product", b =>
                {
                    b.HasOne("OnlineGroceryHub.Infrastructure.Data.Models.SubCategory", "SubCategory")
                        .WithMany("Products")
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("OnlineGroceryHub.Infrastructure.Data.Models.SubCategory", b =>
                {
                    b.HasOne("OnlineGroceryHub.Infrastructure.Data.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("OnlineGroceryHub.Infrastructure.Data.Models.Article", b =>
                {
                    b.Navigation("ArticleComments");
                });

            modelBuilder.Entity("OnlineGroceryHub.Infrastructure.Data.Models.Comment", b =>
                {
                    b.Navigation("ArticleComments");
                });

            modelBuilder.Entity("OnlineGroceryHub.Infrastructure.Data.Models.SubCategory", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}

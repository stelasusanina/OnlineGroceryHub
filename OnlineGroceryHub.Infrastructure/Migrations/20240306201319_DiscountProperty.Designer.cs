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
    [Migration("20240306201319_DiscountProperty")]
    partial class DiscountProperty
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
                            ImageUrl = "https://www.ebag.bg/en/products/images/133238/200/webp",
                            Name = "Rice Chips Livity Cheddar with Tomato Chutney Sauce",
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

            modelBuilder.Entity("OnlineGroceryHub.Infrastructure.Data.Models.SubCategory", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}

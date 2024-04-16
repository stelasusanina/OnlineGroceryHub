using AutoMapper;
using Moq;
using OnlineGroceryHub.Data;
using OnlineGroceryHub.Infrastructure.Data.Models;
using OnlineGroceryHub.Models;
using OnlineGroceryHub.Tests.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Tests.UnitTests
{
	public class UnitTestsBase
	{
		protected ApplicationDbContext context;

		[OneTimeSetUp]
		public void SetUpBase()
		{
			context = DatabaseMock.Instance;
			SeedDatabase();
		}

		[OneTimeTearDown]
		public void TearDownBase()
		{
			context.Dispose();
		}

		public ApplicationUser Admin {  get; set; }
		public ApplicationUser User { get; set; }
		public Wishlist Wishlist { get; set; }
		public Shoppingcart Shoppingcart { get; set; }
		public Category VegetablesCategory {  get; set; }
		public Category FruitsCategory {  get; set; }
		public SubCategory Apples {  get; set; }
		public Product CheeseMadzharov { get; set; }
		public Article NutritionalPsychiatry {  get; set; }

		private void SeedDatabase()
		{
			Admin = new ApplicationUser()
			{
				Id = "9a2f0ce7-97a9-4806-a706-5e239efd4dd2",
				FirstName = "Admin",
				LastName = "Admin",
				Email = "admin@admin.com",
				UserName = "admin@admin.com",
			};
			context.Users.Add(Admin);

			User = new ApplicationUser()
			{
				Id = "00359143-b644-4d40-ad75-b35df9341f0b",
				FirstName = "Stela",
				LastName = "Susanina",
				Email = "stela1234@abv.bg",
				UserName = "stela1234@abv.bg",
			};
			context.Users.Add(User);

			Shoppingcart = new Shoppingcart()
			{
				Id = "00359143-b644-4d40-ad75-b35df9341f0b",
				ApplicationUserId = "00359143-b644-4d40-ad75-b35df9341f0b"
			};
			context.Shoppingcarts.Add(Shoppingcart);

			Wishlist = new Wishlist()
			{
				Id = "00359143-b644-4d40-ad75-b35df9341f0b",
				ApplicationUserId = "00359143-b644-4d40-ad75-b35df9341f0b"
			};
			context.Wishlists.Add(Wishlist);

			FruitsCategory = new Category()
			{
				Id = 1,
				Name = "Fruits"
			};
			context.Categories.Add(FruitsCategory);

			VegetablesCategory = new Category()
			{
				Id = 2,
				Name = "Vegetables"
			};
			context.Categories.Add(VegetablesCategory);

			Apples = new SubCategory()
			{
				Id = 1,
				Name = "Apples",
				CategoryId = 1
			};
			context.SubCategories.Add(Apples);

			CheeseMadzharov = new Product()
			{
				Id = 1,
				Name = "Yellow Cheese Madjarov BDS from Cow Milk",
				Description = "\"Dimitar Madjarov\" cheeses are traditional Bulgarian products, produced from 100% cow, sheep, goat and buffalo milk and Bulgarian sourdough, with a characteristic pale yellow color, well-expressed aroma and mild taste.",
				Quantity = 0.380,
				Price = 12.99M,
				ImageUrl = "https://cdncloudcart.com/16398/products/images/39837/kaskaval-ot-krave-mlako-madzarov-bds-420-g-image_5ea2d3e81638e_1280x1280.png?1587732297",
				Origin = "Bulgaria",
				SubCategoryId = 3
			};
			context.Products.Add(CheeseMadzharov);

			NutritionalPsychiatry = new Article()
			{
				Id = 1,
				Title = "Nutritional psychiatry: Your brain on food",
				ImageUrl = "https://d2jx2rerrg6sh3.cloudfront.net/images/Article_Images/ImageForArticle_21990_16425136005131910.jpg",
				PublishDate = new DateTime(2023, 12, 01)
			};
			context.Articles.Add(NutritionalPsychiatry);
			context.SaveChanges();
		}
	}
}

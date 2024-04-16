using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using OnlineGroceryHub.Core.Contracts;
using OnlineGroceryHub.Core.Models.Product;
using OnlineGroceryHub.Core.Models.Shop;
using OnlineGroceryHub.Core.Services;
using OnlineGroceryHub.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryHub.UnitTests
{
	[TestFixture]
	public class ShopServiceTests
	{
		private Mock<IShopService> shopServiceMock;

		[SetUp]
		public void Setup()
		{
			shopServiceMock = new Mock<IShopService>();
		}

		[Test]
		public async Task Test_GetAllProducts_ReturnsCorrectNumberOfProducts()
		{
			var products = new List<Product>
			{
				new Product { Id = 1, Name = "Product 1", Price = 10.0m },
				new Product { Id = 2, Name = "Product 2", Price = 20.0m }
			};
			var productsAndCount = new ProductsAndCount
			{
				Products = products.Select(p => new ExtendedProductDTO
				{
					Id = p.Id,
					Name = p.Name,
					Price = p.Price
				}).ToList(),
				TotalProductsCount = products.Count
			};
			shopServiceMock.Setup(s => s.GetAllProducts(It.IsAny<string>(), It.IsAny<List<string>>(), It.IsAny<ProductSorting>(), It.IsAny<int>(), It.IsAny<int>())).ReturnsAsync(productsAndCount);

			var result = await shopServiceMock.Object.GetAllProducts("", new List<string>(), ProductSorting.AscendingByName, 1, 10);

			Assert.NotNull(result);
			Assert.AreEqual(2, result.TotalProductsCount);
			Assert.AreEqual(2, result.Products.Count());
		}

		[Test]
		public async Task Test_GetAllSubCategories_ReturnsListOfSubCategories()
		{
			var subCategories = new List<string> { "SubCategory 1", "SubCategory 2" };
			shopServiceMock.Setup(s => s.GetAllSubCategories()).ReturnsAsync(subCategories);

			var result = await shopServiceMock.Object.GetAllSubCategories();

			Assert.NotNull(result);
			Assert.AreEqual(2, result.Count());
			Assert.Contains("SubCategory 1", result.ToList());
			Assert.Contains("SubCategory 2", result.ToList());
		}

		[TearDown]
		public void TearDown()
		{
			shopServiceMock = null;
		}
	}
}

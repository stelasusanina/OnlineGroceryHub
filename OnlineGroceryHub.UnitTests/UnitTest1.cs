using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using OnlineGroceryHub.Core.Contracts;
using OnlineGroceryHub.Core.Services;
using OnlineGroceryHub.Data;
using OnlineGroceryHub.Infrastructure.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryHub.UnitTests
{
	[TestFixture]
	public class ShopServiceTests
	{
		private IShopService shopService;
		private ApplicationDbContext context;
		private Mock<ApplicationDbContext> dbContextMock;

		[SetUp]
		public void Setup()
		{
			// Initialize dbContextMock
			dbContextMock = new Mock<ApplicationDbContext>();

			// Initialize shopService with the mock implementation
			shopService = new ShopService(dbContextMock.Object);
		}

		[Test]
		public async Task Test_GetAllProducts_ReturnsCorrectNumberOfProducts()
		{
			// Arrange
			var products = new List<Product>
			{
				new Product { Id = 1, Name = "Product 1", Description = "Description 1", ImageUrl = "image1.jpg", Price = 10.0m },
				new Product { Id = 2, Name = "Product 2", Description = "Description 2", ImageUrl = "image2.jpg", Price = 20.0m }
			}.AsQueryable();

			// Setup mock DbSet for Products
			var mockDbSetProducts = new Mock<DbSet<Product>>();
			mockDbSetProducts.As<IQueryable<Product>>().Setup(m => m.Provider).Returns(products.Provider);
			mockDbSetProducts.As<IQueryable<Product>>().Setup(m => m.Expression).Returns(products.Expression);
			mockDbSetProducts.As<IQueryable<Product>>().Setup(m => m.ElementType).Returns(products.ElementType);
			mockDbSetProducts.As<IQueryable<Product>>().Setup(m => m.GetEnumerator()).Returns(() => products.GetEnumerator());

			// Setup Products property of dbContextMock to return the mock DbSet
			dbContextMock.Setup(c => c.Products).Returns(mockDbSetProducts.Object);

			// Act
			var result = await shopService.GetAllProducts("", new List<string>(), ProductSorting.AscendingByName, 1, 10);

			// Assert
			Assert.NotNull(result);
			Assert.AreEqual(2, result.TotalProductsCount);
			Assert.AreEqual(2, result.Products.Count());
		}

		[TearDown]
		public void TearDown()
		{
			// Clean up
			dbContextMock = null;
			context = null;
			shopService = null;
		}
	}
}

using Moq;
using OnlineGroceryHub.Core.Contracts;
using OnlineGroceryHub.Core.Services;
using OnlineGroceryHub.Data;
using OnlineGroceryHub.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Tests.UnitTests
{
	[TestFixture]
	public class ShopServiceTests:UnitTestsBase
	{
		private IShopService shopService;

		[OneTimeSetUp]
		public void SetUp()
		{
			var dbContextMock = new Mock<ApplicationDbContext>();

			shopService = new ShopService(dbContextMock.Object);
		}

		[Test]
		public async Task GetAllProducts_WithSearchTermAndSorting_ReturnsCorrectProducts()
		{
			// Arrange
			string searchTerm = "Cheese";
			List<string> subCategory = new List<string>(); // You can add subcategory names here if needed
			ProductSorting sorting = ProductSorting.AscendingByName;
			int currentPage = 1;
			int productsPerPage = 10;

			// Act
			var result = await shopService.GetAllProducts(searchTerm, subCategory, sorting, currentPage, productsPerPage);

			// Assert
			Assert.IsNotNull(result);
			Assert.IsTrue(result.Products.Any());
			Assert.AreEqual(1, result.Products.Count);
		}
	}
}

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineGroceryHub.Core.Contracts;
using OnlineGroceryHub.Core.Models.Shop;
using OnlineGroceryHub.Infrastructure.Data.Models;
using OnlineGroceryHub.Models;

namespace OnlineGroceryHub.Controllers
{
	public class ShopController : BaseController
	{
		private const int productsPerPage = 8;
		private readonly IShopService shopService;
		public ShopController(
			IShopService shopService)
		{
			this.shopService = shopService;
		}
		public async Task<IActionResult> GetAllProducts(
			[FromQuery] string searchTerm = "",
			[FromQuery] int currentPage = 1,
			[FromQuery] ProductSorting sorting = ProductSorting.AscendingByName,
			[FromQuery] List<string> subCategory = null)
		{

			var subCategories = await shopService.GetAllSubCategories();
			var productsAndCount = await shopService.GetAllProducts(searchTerm, subCategory, sorting, currentPage, productsPerPage);
			var viewModel = new ProductsViewModel(productsAndCount.Products, productsAndCount.TotalProductsCount)
			{
				SearchTerm = searchTerm,
				Sorting = sorting,
				SubCategory = subCategory,
				SubCategories = subCategories,
				CurrentPage = currentPage
			};
			return View(viewModel);
		}
	}
}

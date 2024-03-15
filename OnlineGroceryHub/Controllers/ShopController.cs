using Microsoft.AspNetCore.Mvc;
using OnlineGroceryHub.Core.Contracts;
using OnlineGroceryHub.Core.Models.Shop;
using OnlineGroceryHub.Infrastructure.Data.Models;

namespace OnlineGroceryHub.Controllers
{
	public class ShopController : BaseController
	{
		private readonly IShopService shopService;
		private const int productsPerPage = 8;
		public ShopController(IShopService _shopService)
		{
			shopService = _shopService;
		}
		public async Task<IActionResult> GetAllProducts(
			[FromQuery] string searchTerm = "",
			[FromQuery] string subCategory = "",
			[FromQuery] int currentPage = 1,
			[FromQuery] ProductSorting sorting = ProductSorting.AscendingByPrice)
		{

			var subCategories = await shopService.GetAllSubCategories();
			var productsAndCount = await shopService.GetAllProducts(searchTerm, subCategory, sorting, currentPage, productsPerPage);
			var viewModel = new ProductsViewModel(productsAndCount.Products, productsAndCount.TotalProductsCount)
			{
				SearchTerm = searchTerm,
				Sorting = sorting,
				SubCategories = subCategories,
				CurrentPage = currentPage
			};
			return View(viewModel);
		}

	}
}

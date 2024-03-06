using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineGroceryHub.Core.Contracts;
using OnlineGroceryHub.Core.Models;
using OnlineGroceryHub.Core.Services;

namespace OnlineGroceryHub.Controllers
{
    public class ShopController : BaseController
    {
        private readonly IShopService shopService;

        public ShopController(IShopService _shopService)
        {
            shopService = _shopService;
        }
        public async Task<IActionResult> GetAllProducts([FromQuery] string searchTerm)
        {
            var products = await shopService.GetAllProducts(searchTerm);
            var viewModel = new ProductsViewModel(products)
            {
                SearchTerm = searchTerm
            };
            return View(viewModel);
        }
    }
}

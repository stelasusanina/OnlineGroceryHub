using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineGroceryHub.Core.Contracts;
using OnlineGroceryHub.Core.Models;
using OnlineGroceryHub.Core.Services;

namespace OnlineGroceryHub.Controllers
{
    public class ShopController : BaseController
    {
        private readonly IProductService productService;

        public ShopController(IProductService _productService)
        {
            productService = _productService;
        }
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await productService.GetAllProducts();
            var viewModel = new ProductsViewModel(products);
            return View(viewModel);
        }
    }
}

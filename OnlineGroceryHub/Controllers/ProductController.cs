using Microsoft.AspNetCore.Mvc;
using OnlineGroceryHub.Core.Contracts;

namespace OnlineGroceryHub.Controllers
{
	public class ProductController : BaseController
	{
		private readonly IProductService productService;
		public ProductController(IProductService _productService)
		{
			productService = _productService;
		}
		public async Task<IActionResult> ProductInfo(int id)
		{
			var product = await productService.SingleProductInfo(id);
			return View(product);
		}
	}
}

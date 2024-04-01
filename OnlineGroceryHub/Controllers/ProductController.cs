using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineGroceryHub.Core.Contracts;
using OnlineGroceryHub.Models;

namespace OnlineGroceryHub.Controllers
{
	public class ProductController : BaseController
	{
		private readonly IProductService productService;
		public ProductController(
			IProductService productService)
		{
			this.productService = productService;
		}
		public async Task<IActionResult> ProductInfo(int id)
		{
			var product = await productService.SingleProductInfo(id);
			return View(product);
		}
	}
}

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineGroceryHub.Core.Contracts;
using OnlineGroceryHub.Models;

namespace OnlineGroceryHub.Controllers
{
	public class ProductController : BaseController
	{
		private readonly IProductService productService;
		private readonly UserManager<ApplicationUser> _userManager;
		public ProductController(IProductService _productService, UserManager<ApplicationUser> userManager)
		{
			productService = _productService;
			_userManager = userManager;
		}
		public async Task<IActionResult> ProductInfo(int id)
		{
			var product = await productService.SingleProductInfo(id);
			return View(product);
		}
	}
}

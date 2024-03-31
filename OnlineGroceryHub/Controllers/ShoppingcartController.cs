using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineGroceryHub.Core.Contracts;
using OnlineGroceryHub.Core.Models.Blog;
using OnlineGroceryHub.Core.Models.Shoppingcart;
using OnlineGroceryHub.Core.Models.Wishlist;
using OnlineGroceryHub.Core.Services;
using OnlineGroceryHub.Models;

namespace OnlineGroceryHub.Controllers
{
	public class ShoppingcartController : BaseController
	{
		private readonly IShoppingcartService shoppingcartService;
		private readonly UserManager<ApplicationUser> userManager;

		public ShoppingcartController(IShoppingcartService shoppingcartService, UserManager<ApplicationUser> userManager)
		{
			this.shoppingcartService = shoppingcartService;
			this.userManager = userManager;
		}

		public async Task<IActionResult> GetAll()
		{
			var user = await userManager.GetUserAsync(User);

			var products = await shoppingcartService.GetAll(user.ShoppingcartId, user.Id);

			var viewModel = new ShoppingcartViewModel
			{
				ApplicationUser = user,
				Products = products
			};

			return View(viewModel);
		}

		[HttpPost]
		public async Task<IActionResult> AddToShoppingcart(int productId, int amount)
		{
			var user = await userManager.GetUserAsync(User);

			await shoppingcartService.AddToShoppingcart(productId, user.ShoppingcartId, amount);

			return RedirectToAction("ProductInfo", "Product", new { Id = productId });
		}
	}
}

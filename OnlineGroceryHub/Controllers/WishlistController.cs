using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineGroceryHub.Core.Contracts;
using OnlineGroceryHub.Core.Models.Wishlist;
using OnlineGroceryHub.Models;
using System.Security.Claims;

namespace OnlineGroceryHub.Controllers
{
	public class WishlistController : BaseController
	{
		private readonly IWishlistService wishlistService;
		private readonly UserManager<ApplicationUser> userManager;

		public WishlistController(IWishlistService wishlistService, UserManager<ApplicationUser> userManager)
		{
			this.wishlistService = wishlistService;
			this.userManager = userManager;
		}

		public async Task<IActionResult> GetAll()
		{
			var user = await userManager.GetUserAsync(User);
			var userId = user.Id;

			var wishlistId = user.WishListId;
			var products = await wishlistService.GetAll(wishlistId, userId);

            var viewModel = new WishlistViewModel
            {
                ApplicationUser = user,
                Products = products
            };

            return View(viewModel);
		}

		[HttpPost]
		public async Task<IActionResult> Remove(int productId, string wishlistId)
		{
			await wishlistService.RemoveProduct(productId, wishlistId);

			return RedirectToAction("GetAll", "Wishlist");
		}
	}
}

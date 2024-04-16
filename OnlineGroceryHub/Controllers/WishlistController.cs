using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineGroceryHub.Core.Contracts;
using OnlineGroceryHub.Core.Models.Wishlist;
using OnlineGroceryHub.Core.Services;
using OnlineGroceryHub.Models;
using System.Security.Claims;

namespace OnlineGroceryHub.Controllers
{
	public class WishlistController : BaseController
	{
		private readonly IWishlistService wishlistService;
		private readonly UserManager<ApplicationUser> userManager;

		public WishlistController(
			UserManager<ApplicationUser> userManager,
			IWishlistService wishlistService)
		{
			this.userManager = userManager;
			this.wishlistService = wishlistService;
		}

		public async Task<IActionResult> GetAllFromWishlist()
		{
			var user = await userManager.GetUserAsync(User);

			var wishlistId = user.WishListId;
			var products = await wishlistService.GetAllFromWishlist(wishlistId, user.Id);

            var viewModel = new WishlistViewModel
            {
                ApplicationUser = user,
                Products = products
            };

            return View(viewModel);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Remove(int productId, string wishlistId)
		{
			await wishlistService.RemoveProduct(productId, wishlistId);

			return RedirectToAction("GetAllFromWishlist", "Wishlist");
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> AddToWishlist(int productId)
		{
			var user = await userManager.GetUserAsync(User);

			await wishlistService.AddToWishlist(productId, user.WishListId);

			return RedirectToAction("GetAllProducts", "Shop");
		}
	}
}

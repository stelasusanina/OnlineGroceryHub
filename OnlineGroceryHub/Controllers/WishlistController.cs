using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineGroceryHub.Core.Contracts;
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

			return View(products);
		}
	}
}

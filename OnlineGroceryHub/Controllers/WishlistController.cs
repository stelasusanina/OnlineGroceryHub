using Microsoft.AspNetCore.Mvc;
using OnlineGroceryHub.Core.Contracts;
using System.Security.Claims;

namespace OnlineGroceryHub.Controllers
{
	public class WishlistController : BaseController
	{
		private readonly IWishlistService wishlistService;

		public WishlistController(IWishlistService wishlistService)
		{
			this.wishlistService = wishlistService;
		}

		public async Task<IActionResult> GetAll(string wishlistId)
		{
			var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			wishlistId = userId;
			var products = await wishlistService.GetAll(wishlistId, userId);
			return View(products);
		}
	}
}

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

		public async Task<IActionResult> GetAll(int wishlistId)
		{
			var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			var products = await wishlistService.GetAll(wishlistId, userId);
			return View(products);
		}
	}
}

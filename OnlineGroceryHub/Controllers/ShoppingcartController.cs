﻿using Microsoft.AspNetCore.Identity;
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

		public ShoppingcartController(
			IShoppingcartService shoppingcartService,
			UserManager<ApplicationUser> userManager)
		{
			this.shoppingcartService = shoppingcartService;
			this.userManager = userManager;
		}

		public async Task<IActionResult> GetAllFromShoppingcart()
		{
			var user = await userManager.GetUserAsync(User);

			if(user == null)
			{
				return BadRequest();
			}

			var viewModel = await shoppingcartService.GetAllFromShoppingcart(user.Id, user.Id);
			viewModel.ApplicationUser = user;

			if(viewModel.Products == null)
			{
				return BadRequest();
			}

			return View(viewModel);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> AddToShoppingcart(int productId, int amount)
		{
			var user = await userManager.GetUserAsync(User);

			await shoppingcartService.AddToShoppingcart(productId, user.Id, amount);

			return RedirectToAction("GetAllProducts", "Shop");
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> RemoveFromShoppingcart(int productId, string shoppingcartId)
		{
			await shoppingcartService.RemoveFromShoppingcart(productId, shoppingcartId);

			return RedirectToAction("GetAllFromShoppingcart", "Shoppingcart");
		}
	}
}

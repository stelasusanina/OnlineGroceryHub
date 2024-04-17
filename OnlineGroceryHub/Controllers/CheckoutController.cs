using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OnlineGroceryHub.Core.Contracts;
using OnlineGroceryHub.Core.Models.Checkout;
using OnlineGroceryHub.Core.Services;
using OnlineGroceryHub.Models;

namespace OnlineGroceryHub.Controllers
{
    public class CheckoutController:BaseController
    {
		private readonly ICheckoutService checkoutService;
        private UserManager<ApplicationUser> userManager;
        public CheckoutController(ICheckoutService checkoutService, UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
            this.checkoutService = checkoutService;
        }
		public async Task<IActionResult> Index()
		{
			var user = await userManager.GetUserAsync(User);

			var shoppingCartViewModel = await checkoutService.Index(user.Id);
			var checkoutFormModel = new CheckoutFormModel();

			return View(checkoutFormModel);
		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> ProcessCheckout(CheckoutFormModel checkoutFormModel)
		{
			var user = await userManager.GetUserAsync(User);
            var shoppingCartViewModel = await checkoutService.Index(user.Id);

            if (!ModelState.IsValid)
			{
				return View("Index", checkoutFormModel);
            }

			await checkoutService.ProcessCheckout(user.Id, checkoutFormModel);

			return RedirectToAction("OrderDone");
		}

		public async Task<IActionResult> OrderDone()
		{
			var user = await userManager.GetUserAsync(User);

			checkoutService.OrderDone(user.Id);
			return View();
		}
	}
}

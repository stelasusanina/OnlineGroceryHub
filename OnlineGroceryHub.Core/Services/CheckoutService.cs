using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineGroceryHub.Core.Contracts;
using OnlineGroceryHub.Core.Models.Checkout;
using OnlineGroceryHub.Core.Models.Shoppingcart;
using OnlineGroceryHub.Data;
using OnlineGroceryHub.Infrastructure.Data.Models;
using OnlineGroceryHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Core.Services
{
	public class CheckoutService : ICheckoutService
	{
		private readonly ApplicationDbContext context;
		private readonly UserManager<ApplicationUser> userManager;

		public CheckoutService(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
		{
			this.context = context;
			this.userManager = userManager;
		}

		public async Task<ShoppingcartViewModel> Index(string shoppingcartId)
		{
			var total = context.ShoppingcartsProducts
				.Where(sp => sp.ShoppingcartId == shoppingcartId)
				.Sum(sp => sp.Product.Price * sp.ProductAmount);

			var viewModel = new ShoppingcartViewModel
			{
				Total = total
			};

			return viewModel;
		}

		public async Task ProcessCheckout(string shoppingcartId, CheckoutFormModel checkoutFormModel)
		{
			var user = await userManager.FindByIdAsync(shoppingcartId);

			var orderId = Guid.NewGuid();

			var order = new Order()
			{
				Id = orderId.ToString(),
				FirstName = checkoutFormModel.FirstName,
				LastName = checkoutFormModel.LastName,
				Email = checkoutFormModel.Email,
				Phone = checkoutFormModel.Phone,
				City = checkoutFormModel.City,
				Postcode = checkoutFormModel.Postcode,
				AdditionalInfo = checkoutFormModel.AdditionalInfo,
				StreetAddress = checkoutFormModel.StreetAddress,
				UserId = user.Id
			};

			var shoppingcartProducts = context.ShoppingcartsProducts.Where(scp => scp.ShoppingcartId == shoppingcartId);

			foreach (var scp in shoppingcartProducts)
			{
				var productOrder = new ProductOrder()
				{
					Amount = scp.ProductAmount,
					Order = order,
					ProductId = scp.ProductId,
				};
				await context.ProductsOrders.AddAsync(productOrder);
			}

			await context.Orders.AddAsync(order);

			var userOrder = new UserOrder()
			{
				OrderId = orderId.ToString(),
				UserId = user.Id,
			};


			await context.UsersOrders.AddAsync(userOrder);
			await context.SaveChangesAsync();
		}

		public void OrderDone(string shoppingcartId)
		{
			var shoppingCartItems = context.ShoppingcartsProducts.Include(scp => scp.Shoppingcart).Include(scp => scp.Product)
				.Where(sp => sp.ShoppingcartId == shoppingcartId);

			context.ShoppingcartsProducts.RemoveRange(shoppingCartItems);
			context.SaveChangesAsync();
		}
	}
}

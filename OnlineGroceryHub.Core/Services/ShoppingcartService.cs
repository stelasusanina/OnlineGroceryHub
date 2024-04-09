using Microsoft.EntityFrameworkCore;
using OnlineGroceryHub.Core.Contracts;
using OnlineGroceryHub.Core.Models.Product;
using OnlineGroceryHub.Data;
using OnlineGroceryHub.Infrastructure.Data.Models;

namespace OnlineGroceryHub.Core.Services
{
	public class ShoppingcartService : IShoppingcartService
	{
		private readonly ApplicationDbContext context;

		public ShoppingcartService(ApplicationDbContext context)
		{
			this.context = context;
		}
		public async Task<IEnumerable<ExtendedProductDTO>> GetAllFromShoppingcart(string shoppingcartId, string userId)
		{
			var products = await context.ShoppingcartsProducts
				.Where(scp => scp.Shoppingcart.Id == shoppingcartId)
				.Select(sc => new ExtendedProductDTO
				{
					Id = sc.Product.Id,
					ImageUrl = sc.Product.ImageUrl,
					Name = sc.Product.Name,
					Price = sc.Product.Price,
					Discount = sc.Product.Discount,
					Amount = sc.ProductAmount
				}).ToListAsync();

			return products;
		}

		public async Task<ShoppingcartProduct> AddToShoppingcart(int productId, string shoppingcartId, int amount)
		{
			var product = await context.Products.FindAsync(productId);
			var shoppingcart = await context.Shoppingcarts.FindAsync(shoppingcartId);

			var alreadyInShoppingcart = await context.ShoppingcartsProducts
				.FirstOrDefaultAsync(scp => scp.Product.Id == productId && scp.Shoppingcart.Id == shoppingcartId);

			if (alreadyInShoppingcart == null)
			{
				var shoppingcartProduct = new ShoppingcartProduct
				{
					Product = product,
					ProductId = productId,
					ShoppingcartId = shoppingcartId,
					Shoppingcart = shoppingcart,
					ProductAmount = amount
				};

				context.ShoppingcartsProducts.Add(shoppingcartProduct);
				await context.SaveChangesAsync();
				return shoppingcartProduct;
			}
			else
			{
				alreadyInShoppingcart.ProductAmount += amount;

				await context.SaveChangesAsync();
				return alreadyInShoppingcart;
			}
		}

		public async Task RemoveFromShoppingcart(int productId, string shoppingcartId)
		{
			var shoppingcartProduct = await context.ShoppingcartsProducts
				.FirstOrDefaultAsync(scp => scp.Product.Id == productId && scp.Shoppingcart.Id == shoppingcartId);

			context.ShoppingcartsProducts.Remove(shoppingcartProduct);
			await context.SaveChangesAsync();
		}
	}
}

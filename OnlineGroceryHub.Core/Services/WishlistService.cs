using Microsoft.EntityFrameworkCore;
using OnlineGroceryHub.Core.Contracts;
using OnlineGroceryHub.Core.Models.Shop;
using OnlineGroceryHub.Data;
using OnlineGroceryHub.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Core.Services
{
	public class WishlistService : IWishlistService
	{
		private readonly ApplicationDbContext context;

		public WishlistService(ApplicationDbContext context)
		{
			this.context = context;
		}
		public async Task<IEnumerable<ShortProductDTO>> GetAllFromWishlist(string wishlistId, string userId)
		{
			var products = await context.WishlistsProducts
				.Where(wp => wp.Wishlist.Id == wishlistId)
				.Select(wp => new ShortProductDTO
				{
					Id = wp.Product.Id,
					ImageUrl = wp.Product.ImageUrl,
					Name = wp.Product.Name,
					Price = wp.Product.Price,
					Discount = wp.Product.Discount
				}).ToListAsync();

			return products;
		}

		public async Task RemoveProduct(int productId, string wishlistId)
		{
			var wishlistProduct = await context.WishlistsProducts
				.FirstOrDefaultAsync(wp => wp.Product.Id == productId && wp.Wishlist.Id == wishlistId);

			context.WishlistsProducts.Remove(wishlistProduct);
			await context.SaveChangesAsync();
		}

		 public async Task<WishlistProduct> AddToWishlist(int productId, string wishlistId)
         {
            var product = await context.Products.FindAsync(productId);
            var wishlist = await context.Wishlists.FindAsync(wishlistId);

            var wishlistProduct = new WishlistProduct
            {
                Product = product,
                ProductId = productId,
                Wishlist = wishlist,
                WishlistId = wishlistId
            };

            if (await context.WishlistsProducts
				.FirstOrDefaultAsync(wp => wp.Product.Id == productId && wp.Wishlist.Id == wishlistId) == null)
            {
                context.WishlistsProducts.Add(wishlistProduct);
                await context.SaveChangesAsync();
            }

            return wishlistProduct;
         }
	}
}

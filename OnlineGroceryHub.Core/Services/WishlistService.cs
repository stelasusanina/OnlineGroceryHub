using Microsoft.EntityFrameworkCore;
using OnlineGroceryHub.Core.Contracts;
using OnlineGroceryHub.Core.Models.Shop;
using OnlineGroceryHub.Data;
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
		public async Task<IEnumerable<ShortProductDTO>> GetAll(string wishlistId, string userId)
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
	}
}

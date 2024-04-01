using OnlineGroceryHub.Core.Models.Shop;
using OnlineGroceryHub.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Core.Contracts
{
	public interface IWishlistService
	{
		Task<IEnumerable<ShortProductDTO>> GetAllFromWishlist(string wishlistId, string userId);

		Task RemoveProduct(int productId, string wishlistId);

		Task<WishlistProduct> AddToWishlist(int productId, string wishlistId);
	}
}

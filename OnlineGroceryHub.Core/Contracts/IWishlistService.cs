using OnlineGroceryHub.Core.Models.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Core.Contracts
{
	public interface IWishlistService
	{
		Task<IEnumerable<ShortProductDTO>> GetAll(string wishlistId, string userId);

		Task RemoveProduct(int productId, string wishlistId);
	}
}

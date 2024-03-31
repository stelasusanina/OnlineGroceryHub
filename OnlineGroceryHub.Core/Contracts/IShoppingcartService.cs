using OnlineGroceryHub.Core.Models.Product;
using OnlineGroceryHub.Core.Models.Shop;
using OnlineGroceryHub.Core.Models.Shoppingcart;
using OnlineGroceryHub.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Core.Contracts
{
	public interface IShoppingcartService
	{
		Task<IEnumerable<ExtendedProductDTO>> GetAll(string shoppingCartId, string userId);
		Task<ShoppingcartProduct> AddToShoppingcart(int productId, string shoppingcartId, int amount);
	}
}

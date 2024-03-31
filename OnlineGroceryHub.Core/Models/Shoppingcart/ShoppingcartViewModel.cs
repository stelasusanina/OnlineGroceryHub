using OnlineGroceryHub.Core.Models.Product;
using OnlineGroceryHub.Core.Models.Shop;
using OnlineGroceryHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Core.Models.Shoppingcart
{
	public class ShoppingcartViewModel
	{
		public IEnumerable<ExtendedProductDTO> Products { get; set; } = new List<ExtendedProductDTO>();
		public ApplicationUser ApplicationUser { get; set; } = new ApplicationUser();
    }
}

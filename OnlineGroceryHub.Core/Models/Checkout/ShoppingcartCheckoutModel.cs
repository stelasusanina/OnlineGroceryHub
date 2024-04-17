using OnlineGroceryHub.Core.Models.Shoppingcart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Core.Models.Checkout
{
	public class ShoppingcartCheckoutModel
	{
		public ShoppingcartViewModel ShoppingcartViewModel { get; set; }
		public CheckoutFormModel CheckoutFormModel { get; set; }
	} 
}

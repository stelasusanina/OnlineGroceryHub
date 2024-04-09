using OnlineGroceryHub.Core.Models.Checkout;
using OnlineGroceryHub.Core.Models.Shoppingcart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Core.Contracts
{
    public interface ICheckoutService
    {
		Task<ShoppingcartViewModel> Index(string shoppingcartId);
		Task ProcessCheckout(string shoppingcartId, CheckoutFormModel checkoutFormModel);
		void OrderDone(string shoppingcartId);
	}
}

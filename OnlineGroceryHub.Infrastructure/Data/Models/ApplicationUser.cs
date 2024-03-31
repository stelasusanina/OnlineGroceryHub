using Microsoft.AspNetCore.Identity;
using OnlineGroceryHub.Infrastructure.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineGroceryHub.Models
{
	public class ApplicationUser : IdentityUser
	{
		[ForeignKey(nameof(WishListId))]
		public string WishListId { get; set; } = null!;
		public Wishlist Wishlist { get; set; } = null!;

		[ForeignKey(nameof(ShoppingcartId))]
		public string ShoppingcartId { get; set; } = null!;
		public Shoppingcart Shoppingcart { get; set; } = null!;
	}
}

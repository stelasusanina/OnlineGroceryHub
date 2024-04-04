using Microsoft.AspNetCore.Identity;
using OnlineGroceryHub.Infrastructure.Data.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static OnlineGroceryHub.Infrastructure.Constants.DataConstants.ApplicationUserConsts;

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

		[Required]
		[MaxLength(FirstNameMaxLength)]
		public string FirstName { get; set; } = null!;
		[Required]
		[MaxLength(LastNameMaxLength)]
		public string LastName { get; set; } = null!;
	}
}

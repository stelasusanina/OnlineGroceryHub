using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineGroceryHub.Models;

namespace OnlineGroceryHub.Infrastructure.Data.Models
{

	[Comment("User shopping cart")]
	public class Shoppingcart
	{
		[Key]
		[Comment("Shopping cart identifier")]
		public string Id { get; set; } = null!;

		[Comment("Shopping cart user identifier")]
		[ForeignKey(nameof(ApplicationUserId))]
		public string? ApplicationUserId { get; set; } = null!;
		public ApplicationUser ApplicationUser { get; set; } = null!;

		[Comment("Shopping cart total")]
		public decimal Total {  get; set; }

		[Comment("List of the mapping table ShoppingcartProduct")]
		public ICollection<ShoppingcartProduct> ShoppingcartProducts { get; set; } = new List<ShoppingcartProduct>();
	}
}

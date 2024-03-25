using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Infrastructure.Data.Models
{
	[Comment("Wishlist of user's favourite products")]
	public class Wishlist
	{
		[Key]
		[Comment("Wishlist identifier")]
		public int Id { get; set; }

		[Comment("List of the mapping table WishlistProduct")]
		public ICollection<WishlistProduct> WishlistProducts { get; set; } = new List<WishlistProduct>();
	}
}

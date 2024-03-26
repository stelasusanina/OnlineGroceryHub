using Microsoft.EntityFrameworkCore;
using OnlineGroceryHub.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
		public string Id { get; set; }

		[Comment("Wishlist user identifier")]
		[ForeignKey(nameof(ApplicationUserId))]
        public string ApplicationUserId { get; set; } = null!;
		public ApplicationUser ApplicationUser { get; set; } = null!;

        [Comment("List of the mapping table WishlistProduct")]
		public ICollection<WishlistProduct> WishlistProducts { get; set; } = new List<WishlistProduct>();
	}
}

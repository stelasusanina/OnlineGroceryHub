using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineGroceryHub.Infrastructure.Data.Models
{
	[Comment("Mapping table of Wishlist and Product")]
	public class WishlistProduct
	{
		[ForeignKey(nameof(WishlistId))]
		[Comment("Wishlist identifier")]
		public string WishlistId { get; set; } = null!;
		public Wishlist Wishlist { get; set; } = null!;

		[ForeignKey(nameof(ProductId))]
		[Comment("Product identifier")]
		public int ProductId { get; set; }
		public Product Product { get; set; } = null!;
	}
}
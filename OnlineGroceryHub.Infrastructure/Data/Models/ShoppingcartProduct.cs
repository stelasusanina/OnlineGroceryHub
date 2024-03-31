using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineGroceryHub.Infrastructure.Data.Models
{
	[Comment("Mapping table of Shopping cart and Product")]
	public class ShoppingcartProduct
	{
		[ForeignKey(nameof(ShoppingcartId))]
		[Comment("Shopping cart identifier")]
		public string ShoppingcartId { get; set; } = null!;
		public Shoppingcart Shoppingcart { get; set; } = null!;

		[ForeignKey(nameof(ProductId))]
		[Comment("Product identifier")]
		public int ProductId { get; set; }
		public Product Product { get; set; } = null!;

		[Comment("Amount of certain product")]
        public int ProductAmount { get; set; }
    }
}
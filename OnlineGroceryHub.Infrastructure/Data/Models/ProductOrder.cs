using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineGroceryHub.Infrastructure.Data.Models
{
	[Comment("Mapping table of Product and Order")]
	public class ProductOrder
	{
		[ForeignKey(nameof(ProductId))]
		[Comment("Product identifier")]
		public int ProductId { get; set; } 
		public Product Product { get; set; } = null!;

		[Comment("Product amount")]
		public int Amount { get; set; }

        [ForeignKey(nameof(OrderId))]
		[Comment("Order identifier")]
		public string OrderId { get; set; }
		public Order Order { get; set; } = null!;
	}
}
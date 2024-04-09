using Microsoft.EntityFrameworkCore;
using OnlineGroceryHub.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineGroceryHub.Infrastructure.Data.Models
{
	[Comment("Mapping table of User and Order")]
	public class UserOrder
	{
		[ForeignKey(nameof(UserId))]
		[Comment("User identifier")]
		public string UserId { get; set; } = null!;
		public ApplicationUser ApplicationUser { get; set; } = null!;

		[ForeignKey(nameof(OrderId))]
		[Comment("Order identifier")]
		public string OrderId { get; set; }
		public Order Order { get; set; } = null!;
	}
}
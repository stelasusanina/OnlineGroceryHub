using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Infrastructure.Data.Models
{
	public class Order
	{
		public string Id { get; set; } = null!;
		public string FirstName { get; set; } = null!;
		public string LastName { get; set; } = null!;
		public string StreetAddress { get; set; } = null!;
		public string? AdditionalInfo { get; set; }
		public string City { get; set; } = null!;
		public string Postcode { get; set; } = null!;
		public string Phone { get; set; } = null!;
		public string Email { get; set; } = null!;
		public IEnumerable<ProductOrder> ProductsOrders { get; set; } = new List<ProductOrder>();
		public IEnumerable<UserOrder> UsersOrders { get; set; } = new List<UserOrder>();
	}
}

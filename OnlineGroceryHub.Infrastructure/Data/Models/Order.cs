using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Infrastructure.Data.Models
{
	public class Order
	{
		public int Id { get; set; }
		public IEnumerable<ProductOrder> ProductsOrders { get; set; } = new List<ProductOrder>();
		public IEnumerable<UserOrder> UsersOrders { get; set; } = new List<UserOrder>();
	}
}

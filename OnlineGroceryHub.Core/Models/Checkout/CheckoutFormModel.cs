using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Core.Models.Checkout
{
	public class CheckoutFormModel
	{
		public int OrderId { get; set; }
		public string FirstName { get; set; } = null!;
		public string LastName { get; set; } = null!;
		public string StreetAddress { get; set; } = null!;
        public string? AdditionalInfo { get; set; }
        public string City { get; set; } = null!;
        public string Postcode { get; set; } = null!;
		public string Phone { get; set; } = null!;
		public string Email { get; set; } = null!;
    }
}

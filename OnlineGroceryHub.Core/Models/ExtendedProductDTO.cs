using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Core.Models
{
	public class ExtendedProductDTO
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public double Quantity { get; set; }
		public decimal Price { get; set; }
		public string ImageUrl { get; set; } = null!;
		public int? Discount { get; set; }
		public string? ExpirationDate { get; set; }
		public string Origin { get; set; } = null!;
		public string Description { get; set; } = null!;
	}
}

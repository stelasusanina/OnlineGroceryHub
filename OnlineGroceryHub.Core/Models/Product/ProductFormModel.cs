using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OnlineGroceryHub.Infrastructure.Constants.DataConstants.ProductConsts;

namespace OnlineGroceryHub.Core.Models.Product
{
	public class ProductFormModel
	{
		[Required]
		[StringLength(NameMaxLength, MinimumLength = NameMinLength)]
		public string Name { get; set; } = null!;

		[Required]
		[Range(0.001, 3, ErrorMessage ="{0} must be between {2} and {1}.")]
		public double Quantity { get; set; }

		[Required]
		[StringLength(DescriptionMaxLength, MinimumLength =DescriptionMinLength)]
		public string Description { get; set; } = null!;

		[Required]
		[Range(0.1, 100, ErrorMessage = "{0} must be between {2} and {1}.")]
		public decimal Price { get; set; }

		public int? Discount { get; set; }

		[Display(Name = "Expiration Date")]
		public DateTime? ExpirationDate { get; set; }

		[Required]
		[Display(Name = "Image URL")]
		public string ImageUrl { get; set; } = null!;

		public string? Origin { get; set; }

		[Required]
        [Display(Name = "Subcategory")]
        public int SubCategoryId { get; set; }

		public IEnumerable<ProductSubCategoryViewModel> SubCategories { get; set; } 
			= new List<ProductSubCategoryViewModel>();
	}
}

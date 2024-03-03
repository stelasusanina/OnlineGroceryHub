using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static OnlineGroceryHub.Infrastructure.Constants.DataConstants.Product;

namespace OnlineGroceryHub.Infrastructure.Data.Models
{
    [Comment("Product model")]
    public class Product
    {
        [Key]
        [Comment("Product identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Product name")]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        [Comment("Product description")]
        public string Description { get; set; } = null!;

        [Required]
        [Comment("Product quantity")]
        public double Quantity { get; set; }

        [Required]
        [Comment("Product price")]
        public decimal Price { get; set; }

        [Comment("Product expiration date")]
        public DateTime? ExpirationDate { get; set; }

        [Required]
        [Comment("Product image")]
        public string ImageUrl { get; set; } = null!;

        [Comment("Product origin")]
        public string? Origin { get; set; }

        [Required]
        [ForeignKey(nameof(SubCategoryId))]
        [Comment("Product subcategory")]
        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; } = null!;
    }
}

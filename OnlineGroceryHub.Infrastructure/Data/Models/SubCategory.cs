using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Infrastructure.Data.Models
{
    [Comment("Product subcategory")]
    public class SubCategory
    {
        [Key]
        [Comment("Subcategory identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(Constants.DataConstants.SubCategory.NameMaxLength)]
        [Comment("Subcategory name")]
        public string Name { get; set; } = null!;

        [Required]
        [Comment("Product category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        [Comment("List of all the products in the category")]
        public IEnumerable<Product> Products { get; set; } = new List<Product>();
    }
}

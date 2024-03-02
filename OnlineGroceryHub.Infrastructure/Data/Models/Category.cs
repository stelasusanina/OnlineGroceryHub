using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace OnlineGroceryHub.Infrastructure.Data.Models
{
    [Comment("Product category")]
    public class Category
    {
        [Key]
        [Comment("Product identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(Constants.DataConstants.Category.NameMaxLength)]
        [Comment("Category name")]
        public string Name { get; set; } = null!;

        [Comment("List of all the products in the category")]
        public IEnumerable<Product> Products { get; set;} = new List<Product>();
    }
}

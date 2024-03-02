using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace OnlineGroceryHub.Infrastructure.Data.Models
{
    [Comment("Product category")]
    public class Category
    {
        [Key]
        [Comment("Category identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(Constants.DataConstants.Category.NameMaxLength)]
        [Comment("Category name")]
        public string Name { get; set; } = null!;
    }
}

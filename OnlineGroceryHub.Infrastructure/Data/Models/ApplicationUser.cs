using Microsoft.AspNetCore.Identity;
using OnlineGroceryHub.Infrastructure.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineGroceryHub.Models
{
    public class ApplicationUser : IdentityUser
    {
        [ForeignKey(nameof(WishlistId))]
        public int WishlistId { get; set; }
        public Wishlist Wishlist { get; set; }
    }
}

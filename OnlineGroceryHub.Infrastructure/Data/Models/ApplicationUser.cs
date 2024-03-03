using Microsoft.AspNetCore.Identity;

namespace OnlineGroceryHub.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = null!;
    }
}

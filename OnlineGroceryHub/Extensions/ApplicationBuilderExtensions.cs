using Microsoft.AspNetCore.Identity;
using OnlineGroceryHub.Models;

namespace OnlineGroceryHub.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static async Task CreateAdminRoleAsync(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            if (userManager != null && roleManager != null)
            {
                var adminRole = new IdentityRole("Admin");
                var userRole = new IdentityRole("User");

                await roleManager.CreateAsync(adminRole);
                await roleManager.CreateAsync(userRole);

                if(userManager.FindByEmailAsync("stela1234@abv.bg") == null)
                {
                    var User = new ApplicationUser()
                    {
                        Id = "00359143-b644-4d40-ad75-b35df9341f0b",
                        FirstName = "Stela",
                        LastName = "Susanina",
                        Email = "stela1234@abv.bg",
                        ShoppingcartId = "00359143-b644-4d40-ad75-b35df9341f0b",
                        WishListId = "00359143-b644-4d40-ad75-b35df9341f0b",
                        UserName = "stela1234@abv.bg",
                    };

                    await userManager.CreateAsync(User, "s123456789S");
                    await userManager.AddToRoleAsync(User, userRole.Name);
                }

                if (userManager.FindByEmailAsync("admin@admin.com") == null)
                {
                    var Admin = new ApplicationUser()
                    {
                        Id = "9a2f0ce7-97a9-4806-a706-5e239efd4dd2",
                        FirstName = "Admin",
                        LastName = "Admin",
                        Email = "admin@admin.com",
                        UserName = "admin@admin.com",
                    };

                    await userManager.CreateAsync(Admin, "a123456789A");
                    await userManager.AddToRoleAsync(Admin, adminRole.Name);
                }
            }
        }
    }
}

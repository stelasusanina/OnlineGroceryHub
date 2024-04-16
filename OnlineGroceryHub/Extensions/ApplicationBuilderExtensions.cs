using Microsoft.AspNetCore.Identity;
using OnlineGroceryHub.Data;
using OnlineGroceryHub.Infrastructure.Data.Models;
using OnlineGroceryHub.Models;
using System.Drawing.Text;

namespace OnlineGroceryHub.Extensions
{
	public static class ApplicationBuilderExtensions
	{
		public static async Task CreateAdminRoleAsync(this IApplicationBuilder app)
		{
			using var scope = app.ApplicationServices.CreateScope();
			var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
			var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
			var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

			if(dbContext.Users.FirstOrDefault(u => u.Email == "stela1234@abv.bg") == null 
				&& dbContext.Users.FirstOrDefault(u => u.Email == "admin@admin.com") == null) 
			{
				await SeedUsersAsync(userManager);
				await SeedShoppingcartAsync(dbContext);
				await SeedWishlistAsync(dbContext);
			}

			if (userManager != null && roleManager != null)
			{
				var adminRole = new IdentityRole("Admin");
				var userRole = new IdentityRole("User");

				await roleManager.CreateAsync(adminRole);
				await roleManager.CreateAsync(userRole);

				var user = await userManager.FindByEmailAsync("stela1234@abv.bg");

				if (user != null)
				{
					await userManager.AddToRoleAsync(user, userRole.Name);
				}

				var admin = await userManager.FindByEmailAsync("admin@admin.com");

				if (admin != null)
				{
					await userManager.AddToRoleAsync(admin, adminRole.Name);
				}
			}
		}
		private async static Task SeedWishlistAsync(ApplicationDbContext dbContext)
		{
			var userWishlist = new Wishlist()
			{
				Id = "00359143-b644-4d40-ad75-b35df9341f0b",
				ApplicationUserId = "00359143-b644-4d40-ad75-b35df9341f0b"
			};

			await dbContext.Wishlists.AddAsync(userWishlist);
			await dbContext.SaveChangesAsync();
		}

		private async static Task SeedShoppingcartAsync(ApplicationDbContext dbContext)
		{
			var userShoppingcart = new Shoppingcart()
			{
				Id = "00359143-b644-4d40-ad75-b35df9341f0b",
				ApplicationUserId = "00359143-b644-4d40-ad75-b35df9341f0b"
			};

			await dbContext.Shoppingcarts.AddAsync(userShoppingcart);
			await dbContext.SaveChangesAsync();
		}

		private async static Task SeedUsersAsync(UserManager<ApplicationUser> userManager)
		{
			var user = new ApplicationUser()
			{
				Id = "00359143-b644-4d40-ad75-b35df9341f0b",
				FirstName = "Stela",
				LastName = "Susanina",
				Email = "stela1234@abv.bg",
				UserName = "stela1234@abv.bg",
			};

			var admin = new ApplicationUser()
			{
				Id = "9a2f0ce7-97a9-4806-a706-5e239efd4dd2",
				FirstName = "Admin",
				LastName = "Admin",
				Email = "admin@admin.com",
				UserName = "admin@admin.com",
			};

			await userManager.CreateAsync(user, "s123456789S");
			await userManager.CreateAsync(admin, "a123456789A");
		}
	}
}

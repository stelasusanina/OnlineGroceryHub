using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineGroceryHub.Core.Contracts;
using OnlineGroceryHub.Core.Services;
using OnlineGroceryHub.Data;
using OnlineGroceryHub.Extensions;
using OnlineGroceryHub.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
	options.UseSqlServer(connectionString);
}, ServiceLifetime.Transient);

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IShopService, ShopService>();
builder.Services.AddScoped<IBlogService, BlogService>();
builder.Services.AddScoped<IArticleService, ArticleService>();
builder.Services.AddScoped<IWishlistService, WishlistService>();
builder.Services.AddScoped<IShoppingcartService, ShoppingcartService>();
builder.Services.AddScoped<ICheckoutService, CheckoutService>();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
{
	options.SignIn.RequireConfirmedAccount = false;
	options.Password.RequireNonAlphanumeric = false;
	options.Password.RequiredLength = 10;
})
.AddRoles<IdentityRole>()
.AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

await app.CreateAdminRoleAsync();

app.Run();

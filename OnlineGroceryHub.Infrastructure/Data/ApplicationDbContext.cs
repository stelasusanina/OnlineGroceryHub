using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineGroceryHub.Infrastructure.Data.Models;
using OnlineGroceryHub.Infrastructure.Data.SeedDb;
using OnlineGroceryHub.Models;
using System.Reflection.Emit;

namespace OnlineGroceryHub.Data
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<SubCategory> SubCategories { get; set; }
		public DbSet<Article> Articles { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public DbSet<ArticleComment> ArticlesComments { get; set; }
		public DbSet<Wishlist> Wishlists { get; set; }
		public DbSet<WishlistProduct> WishlistsProducts { get; set; }
		public DbSet<Shoppingcart> Shoppingcarts { get; set; }
		public DbSet<ShoppingcartProduct> ShoppingcartsProducts { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<UserOrder> UsersOrders { get; set; }
		public DbSet<ProductOrder> ProductsOrders { get; set; }
		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfiguration(new CategoryConfiguration());
			builder.ApplyConfiguration(new SubCategoryConfiguration());
			builder.ApplyConfiguration(new ProductConfiguration());
			builder.ApplyConfiguration(new ArticleConfiguration());
			builder.ApplyConfiguration(new CommentConfiguration());
			builder.ApplyConfiguration(new ArticleCommentConfiguration());

			builder.Entity<Product>()
				.Property(p => p.Price)
				.HasPrecision(18, 2);

			builder.Entity<ArticleComment>()
				.HasKey(ac => new
				{
					ac.ArticleId,
					ac.CommentId
				});

			builder.Entity<ArticleComment>()
			.HasOne(ac => ac.Article)
			.WithMany(a => a.ArticleComments)
			.HasForeignKey(ac => ac.ArticleId);

			builder.Entity<ArticleComment>()
				.HasOne(ac => ac.Comment)
				.WithMany(c => c.ArticleComments)
				.HasForeignKey(ac => ac.CommentId);

			builder.Entity<WishlistProduct>()
				.HasKey(wp => new
				{
					wp.WishlistId,
					wp.ProductId
				});

			builder.Entity<WishlistProduct>()
				.HasOne(wp => wp.Wishlist)
				.WithMany(w => w.WishlistProducts)
				.HasForeignKey(wp => wp.WishlistId);

			builder.Entity<WishlistProduct>()
				.HasOne(wp => wp.Product)
				.WithMany()
				.HasForeignKey(p => p.ProductId);

			builder.Entity<ApplicationUser>()
			  .HasOne(u => u.Wishlist)
			  .WithOne(w => w.ApplicationUser)
			  .HasForeignKey<Wishlist>(w => w.ApplicationUserId)
			  .IsRequired()
			  .OnDelete(DeleteBehavior.Cascade);

			builder.Entity<ShoppingcartProduct>()
				.HasKey(scp => new
				{
					scp.ShoppingcartId,
					scp.ProductId
				});

			builder.Entity<ShoppingcartProduct>()
				.HasOne(scp => scp.Shoppingcart)
				.WithMany(sc => sc.ShoppingcartProducts)
				.HasForeignKey(scp => scp.ShoppingcartId);

			builder.Entity<ShoppingcartProduct>()
				.HasOne(scp => scp.Product)
				.WithMany()
				.HasForeignKey(p => p.ProductId);

			builder.Entity<ApplicationUser>()
				.HasOne(u => u.Shoppingcart)
				.WithOne(sc => sc.ApplicationUser)
				.HasForeignKey<Shoppingcart>(sc => sc.ApplicationUserId)
				.IsRequired()
				.OnDelete(DeleteBehavior.Cascade);

			builder.Entity<ProductOrder>()
				.HasKey(po => new
				{
					po.OrderId, 
					po.ProductId
				});

			builder.Entity<ProductOrder>()
				.HasOne(po => po.Product)
				.WithMany()
				.HasForeignKey(po => po.ProductId);

			builder.Entity<ProductOrder>()
				.HasOne(po => po.Order)
				.WithMany(o => o.ProductsOrders)
				.HasForeignKey(po => po.OrderId);

			builder.Entity<UserOrder>()
				.HasKey(uo => new
				{
					uo.OrderId, 
					uo.UserId
				});

			builder.Entity<UserOrder>()
				.HasOne(uo => uo.ApplicationUser)
				.WithMany()
				.HasForeignKey(uo => uo.UserId);

			builder.Entity<UserOrder>()
				.HasOne(uo => uo.Order)
				.WithMany(o => o.UsersOrders)
				.HasForeignKey(uo => uo.OrderId);

			base.OnModelCreating(builder);
		}
	}
}

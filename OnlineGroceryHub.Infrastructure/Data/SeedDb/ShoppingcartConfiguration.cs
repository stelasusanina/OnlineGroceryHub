using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OnlineGroceryHub.Infrastructure.Data.Models;
using OnlineGroceryHub.Infrastructure.SeedDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Infrastructure.Data.SeedDb
{
	public class ShoppingcartConfiguration : IEntityTypeConfiguration<Shoppingcart>
	{
		public void Configure(EntityTypeBuilder<Shoppingcart> builder)
		{
			var data = new SeedData();

			builder.HasData(new Shoppingcart[]
			{
				data.UserShoppingcart
			});
		}
	}
}

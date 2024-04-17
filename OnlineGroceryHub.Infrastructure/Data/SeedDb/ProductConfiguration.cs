using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineGroceryHub.Infrastructure.Data.Models;
using OnlineGroceryHub.Infrastructure.SeedDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Infrastructure.Data.SeedDb
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            var data = new SeedData();

            builder.HasData(new Product[] 
            { 
                data.RiceChips, 
                data.CoffeeLavazza, 
                data.CheeseMadzharov ,
                data.ApplesGala,
                data.Bruschette,
                data.CheeseHarmonica,
                data.ChickenRoso,
                data.CoffeeNescafe,
                data.CucumbersGr,
                data.SticksScala,
                data.RoastedNuts,
                data.BluberiesFrozen,
                data.SmoothieMix,
            });
        }
    }
}

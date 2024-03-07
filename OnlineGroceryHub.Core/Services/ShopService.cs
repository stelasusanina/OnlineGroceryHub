using Microsoft.EntityFrameworkCore;
using OnlineGroceryHub.Core.Contracts;
using OnlineGroceryHub.Core.Models;
using OnlineGroceryHub.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Core.Services
{
    public class ShopService:IShopService
    {
        private readonly ApplicationDbContext context;

        public ShopService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<ShortProductDTO>> GetAllProducts(string searchTerm = "")
        {
            var products = await context.Products.ToListAsync();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                return products
                    .Where(product => product.Name.ToLower().Contains(searchTerm.ToLower()))
                    .Select(product => new ShortProductDTO
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Price = product.Price,
                        Quantity = product.Quantity,
                        ImageUrl = product.ImageUrl,
                        Discount = product.Discount
                    })
                    .ToList();
            }

            return products.Select(product => new ShortProductDTO
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity,
                ImageUrl = product.ImageUrl,
                Discount = product.Discount
            })
            .ToList();
        }

        public async Task<IEnumerable<string>> GetAllSubCategories()
        {
            return await context.SubCategories
                .Select(sc => sc.Name)
                .ToListAsync();
        }
    }
}

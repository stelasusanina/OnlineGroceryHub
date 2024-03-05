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

        public async Task<List<ShortProductDTO>> GetAllProducts()
        {
            var products = await context.Products
                .Select(p => new ShortProductDTO
                {
                    Id = p.Id,
                    Name = p.Name,
                    ImageUrl = p.ImageUrl,
                    Price = p.Price,
                    Quantity = p.Quantity,
                })
                .ToListAsync();

            return products;
        }

        public async Task<IEnumerable<string>> GetAllSubCategories()
        {
            return await context.SubCategories
                .Select(sc => sc.Name)
                .ToListAsync();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using OnlineGroceryHub.Core.Contracts;
using OnlineGroceryHub.Core.Models;
using OnlineGroceryHub.Data;
using OnlineGroceryHub.Infrastructure.Data.Models;
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

        public async Task<List<ShortProductDTO>> GetAllProducts(string searchTerm = "",
            ProductSorting sorting = ProductSorting.AscendingByPrice,
            int currentPage = 1,
            int productsPerPage = 6)
        {
            var productsQuery = await context.Products.ToListAsync();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                return productsQuery
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

            productsQuery = sorting switch
            {
                ProductSorting.AscendingByPrice => productsQuery
                    .OrderBy(p => p.Price).ToList(),
                ProductSorting.DescendingByPrice => productsQuery
                    .OrderByDescending(p => p.Price).ToList(),
                ProductSorting.AscendingByName => productsQuery
                    .OrderBy(p => p.Name).ToList(),
                ProductSorting.DescendingByName => productsQuery
                    .OrderByDescending(p => p.Name).ToList()
            };

            var products = productsQuery
                .Skip((currentPage - 1) * productsPerPage)
                .Take(productsPerPage)
                .Select(product => new ShortProductDTO
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Quantity = product.Quantity,
                    ImageUrl = product.ImageUrl,
                    Discount = product.Discount
                }).ToList();

            var totalProducts = productsQuery.Count();

            return productsQuery.Select(product => new ShortProductDTO
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

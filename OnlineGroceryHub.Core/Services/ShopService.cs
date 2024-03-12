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

		public async Task<ProductsAndCount> GetAllProducts(string searchTerm,
			string subCategory,
			ProductSorting sorting,
			int currentPage,
			int productsPerPage)
		{
			var productsQuery = context.Products.AsQueryable();

			if (!string.IsNullOrWhiteSpace(searchTerm))
			{
				productsQuery = context.Products
					.Where(product => product.Name.ToLower().Contains(searchTerm.ToLower()));
			}

			if (!string.IsNullOrWhiteSpace(subCategory))
			{
				productsQuery = context.Products
					.Where(product => product.SubCategory.Name == subCategory);
			}

			switch (sorting)
			{
				case ProductSorting.AscendingByPrice:
					productsQuery = productsQuery.OrderBy(p => p.Price);
					break;
				case ProductSorting.DescendingByPrice:
					productsQuery = productsQuery.OrderByDescending(p => p.Price);
					break;
				case ProductSorting.AscendingByName:
					productsQuery = productsQuery.OrderBy(p => p.Name);
					break;
				case ProductSorting.DescendingByName:
					productsQuery = productsQuery.OrderByDescending(p => p.Name);
					break;
			}

			var products = await productsQuery
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
				})
				.ToListAsync();

			var totalProductsCount = await productsQuery.CountAsync();

			return new ProductsAndCount
			{
				Products = products,
				TotalProductsCount = totalProductsCount
			};
		}


		public async Task<IEnumerable<string>> GetAllSubCategories()
        {
            return await context.SubCategories
                .Select(sc => sc.Name)
                .ToListAsync();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using OnlineGroceryHub.Core.Contracts;
using OnlineGroceryHub.Core.Models.Shop;
using OnlineGroceryHub.Data;
using OnlineGroceryHub.Infrastructure.Data.Models;

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
			List<string> subCategory,
			ProductSorting sorting,
			int currentPage,
			int productsPerPage)
		{
			var productsQuery = context.Products.AsQueryable();

			if (!string.IsNullOrWhiteSpace(searchTerm))
			{
				productsQuery = productsQuery
					.Where(product => product.Name.ToLower().Contains(searchTerm.ToLower()));
			}

			if (subCategory.Count > 0)
			{
				productsQuery = productsQuery
					.Where(product => subCategory.Contains(product.SubCategory.Name));
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

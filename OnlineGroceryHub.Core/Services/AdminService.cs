using Microsoft.EntityFrameworkCore;
using OnlineGroceryHub.Core.Contracts;
using OnlineGroceryHub.Core.Models.Product;
using OnlineGroceryHub.Data;
using OnlineGroceryHub.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Core.Services
{
	public class AdminService : IAdminService
	{
		private readonly ApplicationDbContext context;

		public AdminService(ApplicationDbContext context)
		{
			this.context = context;
		}

		public async Task<Product> AddNewProduct(string name, double quantity, decimal price, string imageUrl,
			int discount, string expirationdate, string origin, string description, int subCategoryId)
		{
			DateTime expDate = DateTime.MinValue;
			if (!string.IsNullOrEmpty(expirationdate))
			{
				expDate = DateTime.Parse(expirationdate);
			}

			var product = new Product
			{
				Name = name,
				Quantity = quantity,
				Price = price,
				ImageUrl = imageUrl,
				Discount = discount,
				ExpirationDate = expDate,
				Origin = origin,
				Description = description,
				SubCategoryId = subCategoryId
			};

			await context.Products.AddAsync(product);
			await context.SaveChangesAsync();

			return product;
		}


		public async Task<IEnumerable<ProductSubCategoryViewModel>> GetAllSubCategories()
		{
			return await context.SubCategories
				.Select(sc => new ProductSubCategoryViewModel
				{
					Id = sc.Id,
					Name = sc.Name
				}).ToListAsync();
		}
	}
}

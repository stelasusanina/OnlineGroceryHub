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

		public async Task<Article> AddNewArticle(string title, string imageUrl, string content)
		{
			var article = new Article
			{
				Title = title,
				ImageUrl = imageUrl,
				Content = content,
				PublishDate = DateTime.Now
			};

			await context.Articles.AddAsync(article);
			await context.SaveChangesAsync();

			return article;
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

		public async Task<Article> GetArticleById(int id)
		{
			var article = await context.Articles.FirstOrDefaultAsync(a => a.Id == id);	

			if(article == null)
			{
				return null;
			}

			return article;
		}

		public async Task<Product> GetProductById(int id)
		{
			var product = await context.Products.FirstOrDefaultAsync(p => p.Id == id);

			if (product == null)
			{
				return null;
			}

			return product;
		}

		public async Task ModifyArticle(int id, string title, string imageUrl, string content)
		{
			var article = await GetArticleById(id);

			if (article == null)
			{
				return;
			}

			article.Title = title;
			article.ImageUrl = imageUrl;
			article.Content = content;	
			
			await context.SaveChangesAsync();
		}

		public async Task ModifyProduct(int id, string name, double quantity, decimal price, string imageUrl, int discount,
			string expirationdate, string origin, string description, int subCategoryId)
		{
			var product = await GetProductById(id);

            if (product == null)
            {
                return;
            }

            DateTime expDate = DateTime.MinValue;
            if (!string.IsNullOrEmpty(expirationdate))
            {
                expDate = DateTime.Parse(expirationdate);
            }

            product.Name = name;
			product.Quantity = quantity;
			product.Price = price;
			product.ImageUrl = imageUrl;
			product.Discount = discount;
			product.ExpirationDate = expDate;
			product.Origin = origin;
			product.Description = description;
			product.SubCategoryId = subCategoryId;

            await context.SaveChangesAsync();
        }
	}
}

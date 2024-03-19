using Microsoft.EntityFrameworkCore;
using OnlineGroceryHub.Core.Contracts;
using OnlineGroceryHub.Core.Models.Blog;
using OnlineGroceryHub.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Core.Services
{
	public class BlogService:IBlogService
	{
		private readonly ApplicationDbContext context;

		public BlogService(ApplicationDbContext context)
		{
			this.context = context;
		}

		public async Task<List<ShortArticleDTO>> GetAllArticles(string searchTerm)
		{
			var articlesQuery = context.Articles.AsQueryable();

			if (!string.IsNullOrWhiteSpace(searchTerm))
			{
				articlesQuery = articlesQuery
					.Where(a => a.Title.ToLower().Contains(searchTerm.ToLower()));
			}

			return await articlesQuery.Select(a => new ShortArticleDTO
				{
					Id = a.Id,
					Title = a.Title,
					ImageUrl = a.ImageUrl,
					PublishDate = a.PublishDate,
					Content = a.Content,
					Comments = a.Comments.ToList()
				})
				.ToListAsync();
		}
	}
}

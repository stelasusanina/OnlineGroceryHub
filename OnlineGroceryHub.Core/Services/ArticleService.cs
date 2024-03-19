using Microsoft.EntityFrameworkCore;
using OnlineGroceryHub.Core.Contracts;
using OnlineGroceryHub.Core.Models.Blog;
using OnlineGroceryHub.Data;

namespace OnlineGroceryHub.Core.Services
{
	public class ArticleService : IArticleService
	{
		private readonly ApplicationDbContext context;

		public ArticleService(ApplicationDbContext context)
		{
			this.context = context;
		}

		public async Task<ShortArticleDTO> GetArticleContent(int id)
		{
			var article = await context.Articles
				.Include(a => a.ArticleComments)
				.ThenInclude(ac => ac.Comment)
				.FirstOrDefaultAsync(a => a.Id == id);

			if (article == null)
			{
				return null;
			}

			var articleDto = new ShortArticleDTO
			{
				Id = article.Id,
				ImageUrl = article.ImageUrl,
				Content = article.Content,
				PublishDate = article.PublishDate.ToString("MM/dd/yyyy"),
				Title = article.Title,
				Comments = article.ArticleComments.Select(ac => ac.Comment).ToList()
			};

			return articleDto;
		}
	}
}

using Microsoft.EntityFrameworkCore;
using OnlineGroceryHub.Core.Contracts;
using OnlineGroceryHub.Core.Models.Blog;
using OnlineGroceryHub.Data;
using OnlineGroceryHub.Infrastructure.Data.Models;
using System.Globalization;

namespace OnlineGroceryHub.Core.Services
{
	public class ArticleService : IArticleService
	{
		private readonly ApplicationDbContext context;

		public ArticleService(ApplicationDbContext context)
		{
			this.context = context;
		}

		public async Task<ArticleDTO> AddComment(CommentFormModel commentFormModel)
		{
			var article = await context.Articles
				.FindAsync(commentFormModel.ArticleId);

			if (article == null)
			{
				return null;
			}

			var comment = new Comment()
			{
				Author = commentFormModel.Author,
				Content = commentFormModel.Message,
				CommentDate = DateTime.Now,
			};

			context.Comments.Add(comment);

			var articleComment = new ArticleComment()
			{
				Article = article,
				Comment = comment
			};

			await context.ArticlesComments.AddAsync(articleComment);
			await context.SaveChangesAsync();

			var articleDto = new ArticleDTO
			{
				Id = article.Id,
				ImageUrl = article.ImageUrl,
				Content = article.Content,
				PublishDate = article.PublishDate.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture),
				Title = article.Title,
				Comments = article.ArticleComments.Select(ac => ac.Comment).ToList()
			};

			return articleDto;
		}

		public async Task<ArticleDTO> GetArticleContent(int id)
		{
			var article = await context.Articles
				.Include(a => a.ArticleComments)
				.ThenInclude(ac => ac.Comment)
				.FirstOrDefaultAsync(a => a.Id == id);

			if (article == null)
			{
				return null;
			}

			var articleDto = new ArticleDTO
			{
				Id = article.Id,
				ImageUrl = article.ImageUrl,
				Content = article.Content,
				PublishDate = article.PublishDate.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture),
				Title = article.Title,
				Comments = article.ArticleComments.Select(ac => ac.Comment).ToList()
			};

			return articleDto;
		}
	}
}

using OnlineGroceryHub.Core.Contracts;
using OnlineGroceryHub.Core.Models.Blog;
using OnlineGroceryHub.Core.Models.Product;
using OnlineGroceryHub.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Core.Services
{
    public class ArticleService:IArticleService
    {
        private readonly ApplicationDbContext context;

        public ArticleService(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<ShortArticleDTO> GetArticleContent(int id)
        {
            var article = await context.Articles.FindAsync(id);
            if (article == null)
            {
                return null;
            }

            var articleDto = new ShortArticleDTO
            {
                Id = id,
                ImageUrl = article.ImageUrl,
                Content = article.Content,
                PublishDate = article.PublishDate,
                Title = article.Title,
                Comments = article.Comments.ToList(),
            };

            return articleDto;
        }
    }
}

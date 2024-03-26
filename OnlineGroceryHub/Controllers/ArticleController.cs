using Microsoft.AspNetCore.Mvc;
using OnlineGroceryHub.Core.Contracts;
using OnlineGroceryHub.Core.Models.Blog;

namespace OnlineGroceryHub.Controllers
{
    public class ArticleController : BaseController
    {
        private readonly IArticleService articleService;
        public ArticleController(IArticleService _articleService)
        {
            articleService = _articleService;
        }
        public async Task<IActionResult> GetArticleContent(int id)
        {
            var article = await articleService.GetArticleContent(id);
            return View(article);
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(CommentFormModel commentFormModel)
        {
            await articleService.AddComment(commentFormModel);

            return RedirectToAction("GetArticleContent", "Article", new {Id = commentFormModel.ArticleId});
        }
    }
}

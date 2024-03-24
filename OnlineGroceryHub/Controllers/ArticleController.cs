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
            var product = await articleService.GetArticleContent(id);
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(CommentFormModel commentFormModel)
        {
            var usrId = this.User;

            fawait articleService.AddComment(commentFormModel);

            return RedirectToAction("GetArticleContent", "Article", new {Id = commentFormModel.ArticleId});
        }
    }
}

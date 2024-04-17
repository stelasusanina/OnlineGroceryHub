using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineGroceryHub.Core.Contracts;
using OnlineGroceryHub.Core.Models.Blog;
using OnlineGroceryHub.Models;

namespace OnlineGroceryHub.Controllers
{
    public class ArticleController : BaseController
    {
		private readonly IArticleService articleService;

		public ArticleController(
			IArticleService _articleService)
		{
			articleService = _articleService;
		}
		public async Task<IActionResult> GetArticleContent(int id)
        {
            if(await articleService.GetArticleContent(id) == null)
            {
                return BadRequest();
            }

            var article = await articleService.GetArticleContent(id);
            var commentFormModel = new CommentFormModel()
            {
                ArticleId = article.Id
            };
            return View(commentFormModel);
        }

        [HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> AddComment(CommentFormModel commentFormModel)
        {
            if(!ModelState.IsValid)
            {
                return View("GetArticleContent", commentFormModel);
            }

            await articleService.AddComment(commentFormModel);

            return RedirectToAction("GetArticleContent", "Article", new {Id = commentFormModel.ArticleId});
        }
    }
}

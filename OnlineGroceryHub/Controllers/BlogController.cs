using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineGroceryHub.Core.Contracts;
using OnlineGroceryHub.Core.Models.Blog;
using OnlineGroceryHub.Models;

namespace OnlineGroceryHub.Controllers
{
	public class BlogController : BaseController
	{
		private readonly IBlogService blogService;

		public BlogController(
			IBlogService blogService)
		{
			this.blogService = blogService;
		}
		public async Task<IActionResult> GetAllArticles([FromQuery] string searchTerm = "")
		{
			var articles = await blogService.GetAllArticles(searchTerm);
			var viewModel = new ArticlesViewModel(articles)
			{
				SearchTerm = searchTerm
			};
			return View(viewModel);
		}
	}
}

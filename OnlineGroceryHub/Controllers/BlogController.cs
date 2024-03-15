using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineGroceryHub.Core.Contracts;

namespace OnlineGroceryHub.Controllers
{
	public class BlogController : BaseController
	{
		private readonly IBlogService blogService;

		public BlogController(IBlogService _blogService)
		{
			blogService = _blogService;
		}
		public async Task<IActionResult> GetAllArticles()
		{
			var viewModel = await blogService.GetAllArticles();
			return View(viewModel);
		}
	}
}

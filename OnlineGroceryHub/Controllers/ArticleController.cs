﻿using Microsoft.AspNetCore.Mvc;
using OnlineGroceryHub.Core.Contracts;

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
    }
}
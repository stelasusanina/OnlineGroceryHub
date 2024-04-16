using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineGroceryHub.Core.Contracts;
using OnlineGroceryHub.Core.Models.Blog;
using OnlineGroceryHub.Core.Models.Product;
using OnlineGroceryHub.Data;
using OnlineGroceryHub.Extensions;

namespace OnlineGroceryHub.Controllers
{
	public class AdminController : BaseController
	{
		private readonly IAdminService adminService;

		public AdminController(
			IAdminService adminService)
		{
			this.adminService = adminService;
		}

		[HttpPost]
		public async Task<IActionResult> AddNewArticle(ArticleFormModel articleFormModel)
		{
			if (!User.IsAdmin())
			{
				return Unauthorized();
			}

			if (!ModelState.IsValid)
			{
				return View();
			}

			var newArticle = await adminService.AddNewArticle(articleFormModel.Title, articleFormModel.ImageUrl, articleFormModel.Content);

			return RedirectToAction("GetArticleContent", "Article", new { newArticle.Id });
		}

		[HttpGet]
		public IActionResult AddNewArticle()
		{
			if (!User.IsAdmin())
			{
				return Unauthorized();
			}

			var viewModel = new ArticleFormModel();

			return View(viewModel);
		}

		[HttpPost]
		public async Task<IActionResult> ModifyArticle(int id, ArticleFormModel articleFormModel)
		{
			if (!User.IsAdmin())
			{
				return Unauthorized();
			}

			if (!ModelState.IsValid)
			{
				return BadRequest();
			}

			await adminService.ModifyArticle(id, articleFormModel.Title, articleFormModel.ImageUrl, articleFormModel.Content);

			return RedirectToAction("GetArticleContent", "Article", new { id });
		}

		[HttpGet]
		public async Task<IActionResult> ModifyArticle(int id)
		{
			if (!User.IsAdmin())
			{
				return Unauthorized();
			}

			var existingArticle = await adminService.GetArticleById(id);

			if (existingArticle == null)
			{
				return BadRequest();
			}

			var viewModel = new ArticleFormModel
			{
				Title = existingArticle.Title,
				ImageUrl = existingArticle.ImageUrl,
				Content = existingArticle.Content
			};

			return View(viewModel);
		}

        [HttpPost]
        public async Task<IActionResult> ModifyProduct(int id, ProductFormModel productFormModel)
        {
            if (!User.IsAdmin())
            {
                return Unauthorized();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            await adminService.ModifyProduct(id, productFormModel.Name, productFormModel.Quantity, productFormModel.Price,
				productFormModel.ImageUrl, productFormModel.Discount ?? 0, productFormModel.ExpirationDate.ToString(),
				productFormModel.Origin, productFormModel.Description, productFormModel.SubCategoryId);

            return RedirectToAction("ProductInfo", "Product", new { id });
        }

        [HttpGet]
        public async Task<IActionResult> ModifyProduct(int id)
        {
            if (!User.IsAdmin())
            {
                return Unauthorized();
            }

            var product = await adminService.GetProductById(id);

            if (product == null)
            {
                return BadRequest();
            }

			var subCategories = await adminService.GetAllSubCategories();

            var viewModel = new ProductFormModel
            {
                Name = product.Name,
				Quantity = product.Quantity,
				Price = product.Price,
				ImageUrl = product.ImageUrl,
				Discount = product.Discount,
				ExpirationDate = product.ExpirationDate,
				Origin = product.Origin,
				Description = product.Description,
				SubCategoryId = product.SubCategoryId,
				SubCategories = subCategories
            };

            return View(viewModel);
        }

        [HttpPost]
		public async Task<IActionResult> AddNewProduct(ProductFormModel productFormModel)
		{
			if (!User.IsAdmin())
			{
				return Unauthorized();
			}

			if(!ModelState.IsValid)
			{
				productFormModel.SubCategories = await adminService.GetAllSubCategories();

				return View(productFormModel);
			}

			int discount = productFormModel.Discount ?? 0;

			var newProduct = await adminService.AddNewProduct(productFormModel.Name, productFormModel.Quantity, 
				productFormModel.Price, productFormModel.ImageUrl, discount, 
				productFormModel.ExpirationDate.ToString()!, productFormModel.Origin!,
				productFormModel.Description, productFormModel.SubCategoryId);

			return RedirectToAction("ProductInfo", "Product", new { newProduct.Id });
		}

		[HttpGet]
		public async Task<IActionResult> AddNewProduct()
		{
			if(!User.IsAdmin())
			{
				return Unauthorized();
			}

			var categories = await adminService.GetAllSubCategories();
			var viewModel = new ProductFormModel()
			{
				SubCategories = categories
			};

			return View(viewModel);
		}
	}
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineGroceryHub.Core.Contracts;
using OnlineGroceryHub.Core.Models.Blog;
using OnlineGroceryHub.Core.Models.Product;
using OnlineGroceryHub.Data;
using OnlineGroceryHub.Extensions;

namespace OnlineGroceryHub.Controllers
{
	//[Authorize(Roles = "Admin")]
	public class AdminController : BaseController
	{
		private readonly IAdminService adminService;

		public AdminController(
			IAdminService adminService)
		{
			this.adminService = adminService;
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

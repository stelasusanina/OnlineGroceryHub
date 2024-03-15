using Microsoft.EntityFrameworkCore;
using OnlineGroceryHub.Core.Contracts;
using OnlineGroceryHub.Core.Models.Product;
using OnlineGroceryHub.Data;
using System.Globalization;

namespace OnlineGroceryHub.Core.Services
{
    public class ProductService : IProductService
	{
		private readonly ApplicationDbContext context;

		public ProductService(ApplicationDbContext context)
		{
			this.context = context;
		}
		public async Task<ExtendedProductDTO> SingleProductInfo(int id)
		{
			var product = await context.Products.FirstOrDefaultAsync(x => x.Id == id);
			if(product == null)
			{
				return null;
			}

			string? expirationDate = null;
			if (product.ExpirationDate.HasValue)
			{
				expirationDate = product.ExpirationDate.Value.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
			}

			var productDto = new ExtendedProductDTO
			{
				Id = product.Id,
				Name = product.Name,
				Discount = product.Discount,
				ExpirationDate = expirationDate,
				ImageUrl = product.ImageUrl,
				Origin = product.Origin,
				Price = product.Price,
				Quantity = product.Quantity,
				Description = product.Description
			};

			return productDto;
		}
	}
}

using OnlineGroceryHub.Core.Models.Product;
using OnlineGroceryHub.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Core.Contracts
{
	public interface IAdminService
	{
		Task<Product> AddNewProduct(string name, double quantity, decimal price, string imageUrl,
			int discount, string expirationdate, string origin, string description, int subCategoryId);

		Task<IEnumerable<ProductSubCategoryViewModel>> GetAllSubCategories();
	}
}

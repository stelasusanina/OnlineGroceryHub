using OnlineGroceryHub.Core.Models;
using OnlineGroceryHub.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Core.Contracts
{
    public interface IShopService
    {
        Task<ProductsAndCount> GetAllProducts(string searchTerm,
            string subCategory,
            ProductSorting sorting,
            int currentPage,
            int productsPerPage);
        Task<IEnumerable<string>> GetAllSubCategories();
    }
}

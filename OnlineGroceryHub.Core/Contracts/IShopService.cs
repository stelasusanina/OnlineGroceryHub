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
        Task<List<ShortProductDTO>> GetAllProducts(string searchTerm, ProductSorting sorting = ProductSorting.AscendingByPrice);
        Task<IEnumerable<string>> GetAllSubCategories();
    }
}

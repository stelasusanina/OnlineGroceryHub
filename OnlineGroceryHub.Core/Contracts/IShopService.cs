using OnlineGroceryHub.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Core.Contracts
{
    public interface IShopService
    {
        Task<List<ShortProductDTO>> GetAllProducts(string searchTerm);
        Task<IEnumerable<string>> GetAllSubCategories();
    }
}

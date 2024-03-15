using OnlineGroceryHub.Core.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Core.Contracts
{
    public interface IProductService
    { 
        Task<ExtendedProductDTO> SingleProductInfo(int id);
    }
}

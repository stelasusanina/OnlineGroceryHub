using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Core.Models.Shop
{
    public class ProductsAndCount
    {
        public List<ShortProductDTO> Products { get; set; }
        public int TotalProductsCount { get; set; }

    }
}

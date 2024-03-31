using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineGroceryHub.Infrastructure.Data.Models;
using OnlineGroceryHub.Models;

namespace OnlineGroceryHub.Core.Models.Shop
{
    public class ProductsViewModel
    {
        private const int DEFAULT_PAGE = 1;
        private const int DEFAULT_PRODUCTS_COUNT = 1;
        private const int DEFAULT_PRODUCTS_PER_PAGE = 6;

        public ProductsViewModel(List<ShortProductDTO> products,
            int totalProductsCount)
        {
            Products = products;
            TotalProductsCount = totalProductsCount;
            CurrentPage = DEFAULT_PAGE;
            ProductsPerPage = DEFAULT_PRODUCTS_PER_PAGE;
        }

        public List<ShortProductDTO> Products { get; set; }
        public string SearchTerm { get; set; }
        public List<string> SubCategory { get; set; } = null!;
        public IEnumerable<string> SubCategories { get; set; } = new List<string>();
        public ProductSorting Sorting { get; set; }
        public int TotalProductsCount { get; set; }
        public int ProductsPerPage { get; set; }
        public int CurrentPage { get; set; }
    }
}

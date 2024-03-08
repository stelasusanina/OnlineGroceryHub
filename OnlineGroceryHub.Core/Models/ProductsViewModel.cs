using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineGroceryHub.Infrastructure.Data.Models;

namespace OnlineGroceryHub.Core.Models
{
    public class ProductsViewModel
    {
        public ProductsViewModel(List<ShortProductDTO> products)
        {
            this.Products = products;
        }

        public List<ShortProductDTO> Products  { get; set; }
        public string SearchTerm { get; set; }
        public ProductSorting Sorting { get; set; }
        public int TotalProductsCount { get; set; }

        public const int ProductsPerPage = 6;

        public int CurrentPage = 1;
    }
}

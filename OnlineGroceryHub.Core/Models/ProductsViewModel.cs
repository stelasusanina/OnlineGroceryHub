using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Core.Models
{
    public class ProductsViewModel
    {
        public ProductsViewModel(List<ProductDTO> products)
        {
            this.Products = products;
        }

        public List<ProductDTO> Products  { get; set; }
    }
}

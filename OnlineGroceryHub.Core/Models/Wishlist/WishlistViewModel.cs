using OnlineGroceryHub.Core.Models.Shop;
using OnlineGroceryHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Core.Models.Wishlist
{
    public class WishlistViewModel
    {
        public IEnumerable<ShortProductDTO> Products { get; set; } = new List<ShortProductDTO>();
        public ApplicationUser ApplicationUser { get; set; } = new ApplicationUser();
    }
}

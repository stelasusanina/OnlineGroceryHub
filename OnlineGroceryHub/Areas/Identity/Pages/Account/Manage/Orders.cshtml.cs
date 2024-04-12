using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OnlineGroceryHub.Data;
using OnlineGroceryHub.Infrastructure.Data.Models;
using OnlineGroceryHub.Models;

namespace OnlineGroceryHub.Areas.Identity.Pages.Account.Manage
{
    public class OrdersModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public OrdersModel(
            UserManager<ApplicationUser> userManager,
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;

        }

        public List<Order> Orders { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);

            var usersOrders = _context.UsersOrders
                .Where(uo => uo.UserId == user.Id)
                .Include(uo => uo.Order)
                .ThenInclude(o => o.ProductsOrders)
                .ThenInclude(po => po.Product)
                .ToList(); 

            Orders = usersOrders.Select(uo => uo.Order).ToList();

            return Page();
        }

    }
}

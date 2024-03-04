using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OnlineGroceryHub.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
       
    }
}

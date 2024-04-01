using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineGroceryHub.Core.Contracts;
using OnlineGroceryHub.Models;

namespace OnlineGroceryHub.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {

	}
}

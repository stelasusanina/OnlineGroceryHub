using Microsoft.AspNetCore.Identity;
using OnlineGroceryHub.Infrastructure.Data.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static OnlineGroceryHub.Infrastructure.Constants.DataConstants.ApplicationUserConsts;

namespace OnlineGroceryHub.Models
{
	public class ApplicationUser : IdentityUser
	{
		[Required]
		[MaxLength(FirstNameMaxLength)]
		public string FirstName { get; set; } = null!;
		[Required]
		[MaxLength(LastNameMaxLength)]
		public string LastName { get; set; } = null!;
	}
}

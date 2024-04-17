using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OnlineGroceryHub.Infrastructure.Constants.DataConstants.CommentConsts;

namespace OnlineGroceryHub.Core.Models.Blog
{
	public class CommentFormModel
	{
		public int ArticleId { get; set; }

		[Required(ErrorMessage = "Author is required")]
		[StringLength(AuthorMaxLength, MinimumLength = AuthorMinLength, 
			ErrorMessage = "The field {0} must be between {2} and {1} characters long.")]
		public string Author { get; set; } = null!;

		[Required(ErrorMessage = "Comment message is required")]
		[StringLength(ContentMaxLength, MinimumLength = ContentMinLength,
			ErrorMessage = "The field {0} must be between {2} and {1} characters long.")]
		public string Message { get; set; } = null!;
	}
}

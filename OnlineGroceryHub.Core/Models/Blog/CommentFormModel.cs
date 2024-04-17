using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Core.Models.Blog
{
	public class CommentFormModel
	{
		public int ArticleId { get; set; }

		[Required(ErrorMessage = "Author is required")]
		public string Author { get; set; } = null!;

		[Required(ErrorMessage = "Comment message is required")]
		public string Message { get; set; } = null!;
	}
}

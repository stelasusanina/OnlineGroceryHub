using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Core.Models.Blog
{
	public class CommentFormModel
	{
		public int ArticleId { get; set; }
		public string Author { get; set; } = null!;
		public string Message { get; set; } = null!;
	}
}

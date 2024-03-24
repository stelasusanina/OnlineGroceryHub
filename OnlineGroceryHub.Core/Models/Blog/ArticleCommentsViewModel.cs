using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Core.Models.Blog
{
	public class ArticleCommentsViewModel
	{
		public CommentFormModel CommentFormModel { get; set; } = new CommentFormModel();
		public ArticleDTO ShortArticleDTO { get; set; }
	}
}

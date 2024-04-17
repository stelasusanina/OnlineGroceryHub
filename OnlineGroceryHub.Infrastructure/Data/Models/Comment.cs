using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OnlineGroceryHub.Infrastructure.Constants.DataConstants.CommentConsts;


namespace OnlineGroceryHub.Infrastructure.Data.Models
{
	[Comment("Article comment")]
	public class Comment
	{
		[Key]
		[Comment("Comment identifier")]
		public int Id { get; set; }

		[Required]
		[MaxLength(AuthorMaxLength)]
		[Comment("Comment author")]
		public string Author { get; set; } = null!;

		[Required]
		[MaxLength(ContentMaxLength)]
		[Comment("Comment content")]
		public string Content { get; set; } = null!;

		[Required]
		[Comment("Comment date")]
		public DateTime CommentDate { get; set; }

		public ICollection<ArticleComment> ArticleComments { get; set; } = new List<ArticleComment>();
	}
}

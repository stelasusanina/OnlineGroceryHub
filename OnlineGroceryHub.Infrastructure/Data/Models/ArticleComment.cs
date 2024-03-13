using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Infrastructure.Data.Models
{
	[Comment("Mapping table for Article and Comment")]
	public class ArticleComment
	{
		[ForeignKey(nameof(ArticleId))]
		[Comment("Article identifier")]
		public int ArticleId { get; set; }
		public Article Article { get; set; } = null!;

		[ForeignKey(nameof(CommentId))]
		[Comment("Comment identifier")]
		public int CommentId { get; set; }
		public Comment Comment { get; set; } = null!;
	}
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OnlineGroceryHub.Infrastructure.Constants.DataConstants.Article;

namespace OnlineGroceryHub.Infrastructure.Data.Models
{
	[Comment("Article model")]
	public class Article
	{
		[Key]
		[Comment("Article idntifier")]
		public int Id { get; set; }

		[Required]
		[MaxLength(TitleMaxLength)]
		[Comment("Article title")]
		public string Title { get; set; } = null!;

		[Required]
		[Comment("Article image")]
		public string ImageUrl { get; set; } = null!;

		[Required]
		[Comment("Article content")]
		public string Content { get; set; } = null!;

		[Required]
		[Comment("Article publish date")]
		public DateTime PublishDate { get; set; }

		public ICollection<ArticleComment> ArticleComments { get; set; } = new List<ArticleComment>();
	}
}

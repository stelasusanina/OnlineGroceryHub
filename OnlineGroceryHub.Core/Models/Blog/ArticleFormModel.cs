using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OnlineGroceryHub.Infrastructure.Constants.DataConstants.ArticleConsts;


namespace OnlineGroceryHub.Core.Models.Blog
{
	public class ArticleFormModel
	{
		[Required]
		[StringLength(TitleMaxLength, MinimumLength = TitleMinLength,
			ErrorMessage = "The field {0} must be between {2} and {1} characters long.")]
		public string Title { get; set; } = null!;

		[Required]
		[Display(Name= "Image URL")]
		public string ImageUrl { get; set; } = null!;

		[Required]
		[MinLength(ContentMinLength, ErrorMessage = "{0} must be at least {1} characters long.")]
		public string Content { get; set; } = null!;

		[Required]
		public DateTime PublishDate { get; set; }
	}
}

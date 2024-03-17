using Microsoft.EntityFrameworkCore;
using OnlineGroceryHub.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Core.Models.Blog
{
	public class ShortArticleDTO
	{
		public int Id { get; set; }
		public string Title { get; set; } = null!;
		public string ImageUrl { get; set; } = null!;
		public string Content { get; set; } = null!;
		public DateTime PublishDate { get; set; }
		public IEnumerable<Comment> Comments { get; set; } = new List<Comment>();
	}
}

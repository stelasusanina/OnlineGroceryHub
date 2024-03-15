using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineGroceryHub.Infrastructure.Data.Models;
using OnlineGroceryHub.Infrastructure.SeedDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Infrastructure.Data.SeedDb
{
	public class ArticleCommentConfiguration : IEntityTypeConfiguration<ArticleComment>
	{
		public void Configure(EntityTypeBuilder<ArticleComment> builder)
		{
			var data = new SeedData();

			builder.HasData(new ArticleComment[]
			{
				data.FirstArticleComment
			});
		}
	}
}

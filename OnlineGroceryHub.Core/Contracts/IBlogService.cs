using OnlineGroceryHub.Core.Models.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Core.Contracts
{
	public interface IBlogService
	{
		Task<IEnumerable<ShortArticleDTO>> GetAllArticles();
	}
}

using OnlineGroceryHub.Core.Models.Shop;
using OnlineGroceryHub.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Core.Models.Blog
{
    public class ArticlesViewModel
    {
        public ArticlesViewModel(List<ArticleDTO> articles)
        {
            Articles = articles;
        }

        public List<ArticleDTO> Articles { get; set; }
        public string SearchTerm { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Infrastructure.Constants
{
    public class DataConstants
    {
        public static class Category
        {
            public const int NameMaxLength = 50;
        }
         
        
        public static class ProductConsts
        {
            public const int NameMaxLength = 150;
            public const int NameMinLength = 10;
            public const int DescriptionMinLength = 10;
			public const int DescriptionMaxLength = 500;
        }

        public static class SubCategory
        {
            public const int NameMaxLength = 50;

        }

        public static class ArticleConsts
        {
            public const int TitleMaxLength = 150;
            public const int TitleMinLength = 10;
            public const int ContentMinLength = 200;
        }

		public static class Comment
		{
			public const int AuthorMaxLength = 50;
            public const int ContentMaxLength = 500;
		}

        public static class ApplicationUserConsts
        {
            public const int FirstNameMaxLength = 100;
			public const int LastNameMaxLength = 100;
		}
	}
}

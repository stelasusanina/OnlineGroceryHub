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

		public static class CommentConsts
		{
			public const int AuthorMaxLength = 50;
            public const int AuthorMinLength = 5;
            public const int ContentMaxLength = 500;
            public const int ContentMinLength = 10;
		}

        public static class ApplicationUserConsts
        {
            public const int FirstNameMaxLength = 100;
			public const int LastNameMaxLength = 100;
		}

        public static class CheckoutFormConsts
        {
			public const int FirstNameMaxLength = 50;
            public const int FirstNameMinLength = 2;

			public const int LastNameMaxLength = 50;
			public const int LastNameMinLength = 1;

            public const int StreetAddressMaxLength = 200;
            public const int StreetAddressMinLength = 5;

            public const int CityMaxLength = 50;
            public const int CityMinLength = 3;

            public const int PostCodeMaxLength = 4;
            public const int PostCodeMinLength = 4;

			public const int PhoneCodeMaxLength = 10;
			public const int PhoneCodeMinLength = 10;

            public const int EmailMinLength = 10;
            public const int EmailMaxLength = 150;
		}
	}
}

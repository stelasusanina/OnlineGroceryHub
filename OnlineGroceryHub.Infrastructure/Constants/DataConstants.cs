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
         
        
        public static class Product
        {
            public const int NameMaxLength = 150;
            public const int DescriptionMaxLength = 500;
        }

        public static class SubCategory
        {
            public const int NameMaxLength = 50;

        }
    }
}

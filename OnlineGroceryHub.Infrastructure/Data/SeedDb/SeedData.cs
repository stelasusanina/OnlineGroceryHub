using OnlineGroceryHub.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryHub.Infrastructure.SeedDb
{
    public class SeedData
    {
        public Category FruitsCategory { get; set; }
        public Category VegetablesCategory { get; set; }
        public Category DairyCategory { get; set; }
        public Category FrozenCategory { get; set; }
        public Category DrinksCategory { get; set; }
        public Category MeatAndFishCategory { get; set; }
        public Category PackagedFoodsCategory { get; set; }

        public SubCategory Apples {  get; set; }
        public SubCategory Cucumbers { get; set; }
        public SubCategory Cheese { get; set; }
        public SubCategory FrozenMeat { get; set; }
        public SubCategory Coffee { get; set; }
        public SubCategory Chicken { get; set; }
        public SubCategory Snacks { get; set; }

        public Product CheeseMadzharov {  get; set; }
        public Product CoffeeLavazza { get; set; }
        public Product RiceChips { get; set; }

        public SeedData()
        {
            SeedCategories();
            SeedSubCategories();
            SeedProducts();
        }

        private void SeedCategories()
        {
            FruitsCategory = new Category()
            {
                Id = 1,
                Name = "Fruits"
            };

            VegetablesCategory = new Category()
            {
                Id = 2,
                Name = "Vegetables"
            };

            DairyCategory = new Category()
            {
                Id = 3,
                Name = "Dairy"
            };

            FrozenCategory = new Category()
            {
                Id = 4,
                Name = "Frozen"
            };

            DrinksCategory = new Category()
            {
                Id = 5,
                Name = "Drinks"
            };

            MeatAndFishCategory = new Category()
            {
                Id = 6,
                Name = "Meat and Fish"
            };

            PackagedFoodsCategory = new Category()
            {
                Id = 7,
                Name = "Packaged Foods"
            };
        }

        private void SeedSubCategories()
        {
            Apples = new SubCategory()
            {
                Id = 1,
                Name = "Apples",
                CategoryId = 1
            };

            Cucumbers = new SubCategory()
            {
                Id = 2,
                Name = "Cucumbers",
                CategoryId = 2
            };

            Cheese = new SubCategory()
            {
                Id = 3,
                Name = "Cheese",
                CategoryId = 3
            };

            FrozenMeat = new SubCategory()
            {
                Id = 4,
                Name = "Frozen Meat",
                CategoryId = 4
            };

            Coffee = new SubCategory()
            {
                Id = 5,
                Name = "Coffee",
                CategoryId = 5
            };

            Chicken = new SubCategory()
            {
                Id = 6,
                Name = "Chicken",
                CategoryId = 6
            };

            Snacks = new SubCategory()
            {
                Id = 7,
                Name = "Snacks",
                CategoryId = 7
            };
        }

        private void SeedProducts()
        {
            DateTime expirationDate1 = new DateTime(2024, 08, 29);
            DateTime expirationDate2 = new DateTime(2025, 08, 30);
            DateTime expirationDate3 = new DateTime(2025, 02, 08);

            CheeseMadzharov = new Product()
            {
                Id = 1,
                Name = "Yellow Cheese Madjarov BDS from Cow Milk",
                Description = "\"Dimitar Madjarov\" cheeses are traditional Bulgarian products, produced from 100% cow, sheep, goat and buffalo milk and Bulgarian sourdough, with a characteristic pale yellow color, well-expressed aroma and mild taste.",
                Quantity = 0.380,
                Price = 12.99M,
                ExpirationDate = expirationDate1,
                ImageUrl = "https://cdncloudcart.com/16398/products/images/39837/kaskaval-ot-krave-mlako-madzarov-bds-420-g-image_5ea2d3e81638e_1280x1280.png?1587732297",
                Origin = "Bulgaria",
                SubCategoryId = 3
            };

            CoffeeLavazza = new Product()
            {
                Id = 2,
                Name = "Coffee Lavazza Crema e Aroma Grains",
                Description = "Ingredients: 60% Robusta and 40% Arabica; Intensity: 8/10",
                Quantity = 1,
                Price = 30.99M,
                ExpirationDate = expirationDate2,
                ImageUrl = "https://i0.wp.com/avanti-bg.com/wp-content/uploads/2020/09/%D0%9A%D0%90%D0%A4%D0%95-%D0%9B%D0%90%D0%92%D0%90%D0%A6%D0%90-%D0%9A%D0%A0%D0%95%D0%9C%D0%90-%D0%90%D0%A0%D0%9E%D0%9C%D0%90-1%D0%9A%D0%93.jpg?fit=1500%2C1500&ssl=1",
                Origin = "Poland",
                SubCategoryId = 5
            };

            RiceChips = new Product()
            {
                Id = 3,
                Name = "Rice Chips Livity Cheddar",
                Description = "In the development of our recipe, we were inspired by a unique taste profile born back 800 years ago in the small Cheddar village in the UK. Right there, in the caves, close to nature, an exclusive taste palette was born – rich, mellow and slightly salty. It conquered the world.",
                Quantity = 0.06,
                Price = 1.99M,
                ExpirationDate = expirationDate3,
                Discount = 15,
                ImageUrl = "https://www.ebag.bg/en/products/images/133238/200/webp",
                Origin = "Bulgaria",
                SubCategoryId = 7
            };
        }
    }
}

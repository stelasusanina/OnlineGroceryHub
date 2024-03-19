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
        public Product CheeseHarmonica { get; set; }
        public Product Bruschette { get; set; }
        public Product ApplesGala {  get; set; }
        public Product CoffeeNescafe {  get; set; }
        public Product ChickenRoso { get; set; }
        public Product SticksScala {  get; set; }
        public Product CucumbersGr { get; set; }

        public Article NutritionalPsychiatry { get; set; }
        public Comment FirstComment { get; set; }
        public ArticleComment FirstArticleComment { get; set; }
        public SeedData()
        {
            SeedCategories();
            SeedSubCategories();
            SeedProducts();
            SeedArticles();
            SeedComments();
            SeedArticleComments();
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
            DateTime expirationDate4 = new DateTime(2024, 10, 21);
            DateTime expirationDate5 = new DateTime(2025, 02, 02);
            DateTime expirationDate6 = new DateTime(2025, 12, 30);
            DateTime expirationDate7 = new DateTime(2024, 04, 26);
            DateTime expirationDate8 = new DateTime(2024, 09, 27);

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
                ImageUrl = "https://m.ebag.bg/en/products/images/133238/800",
                Origin = "Bulgaria",
                SubCategoryId = 7
            };

            CheeseHarmonica = new Product()
            {
                Id = 4,
                Name = "Organic Cow Cheese Harmonica",
                Description = "Prepare it with natural fresh whole milk and without taking away any ingredients. The cheese thus acquires a specific taste. The traditional Bulgarian cultures of Lactobacilus bulgaricus and Streptococcus thermophilus are used for the starter, and this also adds probiotic properties. The cheese contains huge amounts of protein, also the very useful fatty acids that are characteristic of the milk of the pasture cows.",
                Quantity = 0.4,
                Price = 12.99M,
                ExpirationDate = expirationDate4,
                ImageUrl = "https://production.balevbiomarket-contents.com/p/020022/sirene-ot-krave-mlqko-zoom.jpeg",
                Origin = "Bulgaria",
                SubCategoryId = 3
            };

            Bruschette = new Product()
            {
                Id = 5,
                Name = "Bruschette Maretti Cream & Onion",
                Description = "Maretti are crispy and delicious oven baked bite-size chips offered in variety of rich flavors with Mediterranean twist. Our Bruschette style chips are oven baked in small batches and are made in traditional Bruschette style with two sides of taste – Both good. Only one side seasoned – that gives you a choice how to eat it – spices down for more intensive taste and spices up for delicate taste.",
                Quantity = 0.07,
                Price = 1.49M,
                Discount = 5,
                ExpirationDate = expirationDate5,
                ImageUrl = "https://www.superbagplovdiv.bg/media/99/27815.png",
                Origin = "Bulgaria",
                SubCategoryId = 7
            };

            ApplesGala = new Product()
            {
                Id = 6,
                Name = "Apples Gala",
                Description = "Apples Gala",
                Quantity = 1,
                Price = 3.29M,
                ImageUrl = "https://i5.walmartimages.com/asr/c16b1c2d-6fc9-42c3-865f-575b2dcacb05.b3094ff47e723cb532823dbf849c95a7.jpeg?odnHeight=768&odnWidth=768&odnBg=FFFFFF",
                Origin = "Bulgaria",
                SubCategoryId = 1
            };

            CoffeeNescafe = new Product()
            {
                Id = 7,
                Name = "Coffee Nescafe Classic Crema Instant",
                Description = "Nescafe Classic Crema   It has a strong taste and aroma combined with seductive cream for even more pleasant awakening! Prepare easily and quickly with only hot water.",
                Quantity = 0.095,
                Price = 8.99M,
                Discount = 10,
                ExpirationDate = expirationDate6,
                ImageUrl = "https://www.nescafe.com/bg/sites/default/files/2023-08/11_3.png",
                Origin = "France",
                SubCategoryId = 5
            };

            ChickenRoso = new Product()
            {
                Id = 8,
                Name = "Chicken Roso Chilled",
                Description = "Chicken Roso Chilled about 1.700 kg. The price for one piece.",
                Quantity= 1.7,
                Price = 21.80M,
                ExpirationDate = expirationDate7,
                ImageUrl = "https://m.ebag.bg/en/products/images/85639/800",
                Origin = "Bulgaria",
                SubCategoryId = 4
            };

            SticksScala = new Product()
            {
                Id = 9,
                Name = "Salted Sticks Scala",
                Description = "Hand-made chickens with a balanced, natural taste that brings the authentic taste of home-made brine! Each ingredient is precisely chosen, paying special attention to quality and usefulness!",
                Quantity = 0.1,
                Price = 3.49M,
                ExpirationDate = expirationDate8,
                ImageUrl = "https://m.ebag.bg/en/products/images/111780/800",
                Origin = "Bulgaria",
                SubCategoryId = 7
            };

            CucumbersGr = new Product
            {
                Id = 10,
                Name = "Cucumbers",
                Description = "Cucumbers from Greece",
                Quantity = 1,
                Price = 5.49M,
                ImageUrl = "https://m.ebag.bg/en/products/images/125683/800",
                Origin = "Greece",
                SubCategoryId = 2
            };
        }

        private void SeedArticles()
        {
            NutritionalPsychiatry = new Article()
            {
                Id = 1,
                Title = "Nutritional psychiatry: Your brain on food",
                ImageUrl = "https://d2jx2rerrg6sh3.cloudfront.net/images/Article_Images/ImageForArticle_21990_16425136005131910.jpg",
                Content = "Think about it. Your brain is always \"on.\" It takes care of your thoughts and movements, your breathing and heartbeat, your senses — it works hard 24/7, even while you're asleep. This means your brain requires a constant supply of fuel. That \"fuel\" comes from the foods you eat — and what's in that fuel makes all the difference. Put simply, what you eat directly affects the structure and function of your brain and, ultimately, your mood.\r\n\r\nLike an expensive car, your brain functions best when it gets only premium fuel. Eating high-quality foods that contain lots of vitamins, minerals, and antioxidants nourishes the brain and protects it from oxidative stress — the \"waste\" (free radicals) produced when the body uses oxygen, which can damage cells.\r\n\r\nUnfortunately, just like an expensive car, your brain can be damaged if you ingest anything other than premium fuel. If substances from \"low-premium\" fuel (such as what you get from processed or refined foods) get to the brain, it has little ability to get rid of them. Diets high in refined sugars, for example, are harmful to the brain. In addition to worsening your body's regulation of insulin, they also promote inflammation and oxidative stress. Multiple studies have found a correlation between a diet high in refined sugars and impaired brain function — and even a worsening of symptoms of mood disorders, such as depression.\r\n\r\nIt makes sense. If your brain is deprived of good-quality nutrition, or if free radicals or damaging inflammatory cells are circulating within the brain's enclosed space, further contributing to brain tissue injury, consequences are to be expected. What's interesting is that for many years, the medical field did not fully acknowledge the connection between mood and food.\r\n\r\nToday, fortunately, the burgeoning field of nutritional psychiatry is finding there are many consequences and correlations between not only what you eat, how you feel, and how you ultimately behave, but also the kinds of bacteria that live in your gut.\r\n\r\nHow the foods you eat affect your mental health\r\nSerotonin is a neurotransmitter that helps regulate sleep and appetite, mediate moods, and inhibit pain. Since about 95% of your serotonin is produced in your gastrointestinal tract, and your gastrointestinal tract is lined with a hundred million nerve cells, or neurons, it makes sense that the inner workings of your digestive system don't just help you digest food, but also guide your emotions. What's more, the function of these neurons — and the production of neurotransmitters like serotonin — is highly influenced by the billions of \"good\" bacteria that make up your intestinal microbiome. These bacteria play an essential role in your health. They protect the lining of your intestines and ensure they provide a strong barrier against toxins and \"bad\" bacteria; they limit inflammation; they improve how well you absorb nutrients from your food; and they activate neural pathways that travel directly between the gut and the brain.\r\n\r\nStudies have compared \"traditional\" diets, like the Mediterranean diet and the traditional Japanese diet, to a typical \"Western\" diet and have shown that the risk of depression is 25% to 35% lower in those who eat a traditional diet. Scientists account for this difference because these traditional diets tend to be high in vegetables, fruits, unprocessed grains, and fish and seafood, and to contain only modest amounts of lean meats and dairy. They are also void of processed and refined foods and sugars, which are staples of the \"Western\" dietary pattern. In addition, many of these unprocessed foods are fermented, and therefore act as natural probiotics.\r\n\r\nThis may sound implausible to you, but the notion that good bacteria not only influence what your gut digests and absorbs, but that they also affect the degree of inflammation throughout your body, as well as your mood and energy level, is gaining traction among researchers.\r\n\r\nNutritional psychiatry: What does it mean for you?\r\nStart paying attention to how eating different foods makes you feel — not just in the moment, but the next day. Try eating a \"clean\" diet for two to three weeks — that means cutting out all processed foods and sugar. See how you feel. Then slowly introduce foods back into your diet, one by one, and see how you feel.\r\n\r\nWhen some people \"go clean,\" they cannot believe how much better they feel both physically and emotionally, and how much worse they then feel when they reintroduce the foods that are known to enhance inflammation.",
                PublishDate = DateTime.Now
            };
        }

        private void SeedComments()
        {
            FirstComment = new Comment()
            {
                Id = 1,
                Author = "Eva Selhub",
                Content = "Great article! Learned a lot from it!",
                CommentDate = DateTime.Now
			};
        }

		private void SeedArticleComments()
        {
            FirstArticleComment = new ArticleComment()
            {
                ArticleId = 1,
                CommentId = 1
            };
        }
	}
}

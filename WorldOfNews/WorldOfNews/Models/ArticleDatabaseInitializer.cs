using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.Data.Entity;

namespace WorldOfNews.Models
{
    public class ArticleDatabaseInitializer : DropCreateDatabaseAlways<ArticleContext>
    {
        protected override void Seed(ArticleContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetArticles().ForEach(c => context.Articles.Add(c));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Economy"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Politics"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Education"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Sport"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Technology"
                },
            };

            return categories;
        }

        private static List<Article> GetArticles()
        {
            var articles = new List<Article>
            {
                new Article
                {
                    CategoryID = 5,
                    ArticleName = "Article number 1",
                    ImagePath = "image1.png",
                    ArticleID = 1,
                    Description = "Description for article number 1 made by Initializer"
                },
                new Article
                {
                    CategoryID = 4,
                    ArticleName = "Article number 2",
                    ImagePath = "image2.png",
                    ArticleID = 2,
                    Description = "Description for article number 2 made by Initializer"
                },
                new Article
                {
                    CategoryID = 3,
                    ArticleName = "Article number 3",
                    ImagePath = "image3.png",
                    ArticleID = 3,
                    Description = "Description for article number 3 made by Initializer"
                },
                new Article
                {
                    CategoryID = 2,
                    ArticleName = "Article number 4",
                    ImagePath = "image4.png",
                    ArticleID = 4,
                    Description = "Description for article number 4 made by Initializer"
                },
                new Article
                {
                    CategoryID = 1,
                    ArticleName = "Article number 5",
                    ImagePath = "image5.png",
                    ArticleID = 5,
                    Description = "Description for article number 5 made by Initializer"
                }
            };

            return articles;
        }
    }
}
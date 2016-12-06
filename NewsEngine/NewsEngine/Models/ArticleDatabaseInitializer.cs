using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NewsEngine.Models
{
    public class ArticleDatabaseInitializer : DropCreateDatabaseAlways<ArticleContext>
    {
        protected override void Seed(ArticleContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetArticles().ForEach(p => context.Articles.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Politics"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Technology"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Internet"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Sport"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Education"
                }
            };

            return categories;
        }

        private static List<Article> GetArticles()
        {
            var articles = new List<Article>
            {
                new Article
                {
                    ArticleID = 1,
                    ArticleName = "Donald Trump, the new president",
                    Description = "Donald Trump is the new president of the United States, bla-bla, USA will suffer, bla-bla, USA is surprised",
                    ImagePath = "usa.png",
                    CategoryID = 1
                },
                new Article
                {
                    ArticleID = 2,
                    ArticleName = "Elections day in Romania",
                    Description = "Romania will have to vote for their future on the date of 8th December 2016, bla-bla, they are thiefs, bla-bla, they run only for the money",
                    ImagePath = "romania.png",
                    CategoryID = 1
                },
                new Article
                {
                    ArticleID = 3,
                    ArticleName = "New Macbook Pro 2016 has been released",
                    Description = "Yep! It's here and is more gorgeous than the last version of Macbook Pro, 2015 one",
                    ImagePath = "macbook.png",
                    CategoryID = 2
                },
                new Article
                {
                    ArticleID = 4,
                    ArticleName = "Samsung Galaxy S8 is close",
                    Description = "The south coreeans will launch next year in march thei new S model, 8 is the number and it will be awesome",
                    ImagePath = "samsung.png",
                    CategoryID = 2
                },
                new Article
                {
                    ArticleID = 5,
                    ArticleName = "Android 7.1 is a real succes",
                    Description = "The latest version of Android operating system is a real succes from all points of view",
                    ImagePath = "android.png",
                    CategoryID = 2
                },
                new Article
                {
                    ArticleID = 6,
                    ArticleName = "Name Article number 6",
                    Description = "Article 6 description",
                    ImagePath = "art6.png",
                    CategoryID = 2
                },
                new Article
                {
                    ArticleID = 7,
                    ArticleName = "Numero 7 articole",
                    Description = "Numero 7 descriptione",
                    ImagePath = "art7.png",
                    CategoryID = 2
                },
                new Article
                {
                    ArticleID = 8,
                    ArticleName = "Art.8",
                    Description = "Art.8 Description",
                    ImagePath = "art8.png",
                    CategoryID = 3
                },
                new Article
                {
                    ArticleID = 9,
                    ArticleName = "99999999",
                    Description = "DESCRIPTION 9",
                    ImagePath = "art9.png",
                    CategoryID = 3
                },
                new Article
                {
                    ArticleID = 10,
                    ArticleName = "10 in 10 article",
                    Description = "10 in 10 in 10 in 10",
                    ImagePath = "art10.png",
                    CategoryID = 4
                },
                new Article
                {
                    ArticleID = 11,
                    ArticleName = "nnnumberrr 11",
                    Description = "deeesscriiptiiioonnn 11",
                    ImagePath = "art11.png",
                    CategoryID = 4
                },
                new Article
                {
                    ArticleID = 12,
                    ArticleName = "Twelve Article",
                    Description = "The number after eleven is twelve",
                    ImagePath = "art12.png",
                    CategoryID = 4
                },
                new Article
                {
                    ArticleID = 13,
                    ArticleName = "un troi numero",
                    Description = "description du article numero troix",
                    ImagePath = "art13.png",
                    CategoryID = 4
                },
                new Article
                {
                    ArticleID = 14,
                    ArticleName = "One more article",
                    Description = "Immediatly we will finish to complete these articles",
                    ImagePath = "art14.png",
                    CategoryID = 5
                },
                new Article
                {
                    ArticleID = 15,
                    ArticleName = "Last article for the moment",
                    Description = "Thanks to me for my patience",
                    ImagePath = "art15.png",
                    CategoryID = 5
                }
            };

            return articles;
        }
    }
}
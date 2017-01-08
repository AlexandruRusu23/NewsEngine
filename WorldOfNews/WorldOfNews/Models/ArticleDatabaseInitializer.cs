using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WorldOfNews.Models
{
    public class ArticleDatabaseInitializer : DropCreateDatabaseAlways<ArticleContext>
    {
        protected override void Seed(ArticleContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetArticles().ForEach(c => context.Articles.Add(c));
            GetProposedArticles().ForEach(c => context.ProposedArticles.Add(c));
            GetExternArticles().ForEach(c => context.ExternArticles.Add(c));
            GetComments().ForEach(c => context.Comments.Add(c));
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
                new Category
                {
                    CategoryID = 6,
                    CategoryName = "Science"
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
                    CategoryID = 2,
                    ArticleName = "Donald Trump is the new president of the United States",
                    ImagePath = "image1.png",
                    DatePublished = DateTime.Parse("12/10/2016"),
                    ArticleID = 1,
                    Description = "USA will have to feel the real pressure now that they've changed their president. Barack Obama is feeling awful, but he knows that is better than Donald Trump."
                },
                new Article
                {
                    CategoryID = 3,
                    ArticleName = "Student nowadays don't read book like past's students",
                    ImagePath = "image4.png",
                    DatePublished = DateTime.Parse("12/17/2016"),
                    ArticleID = 3,
                    Description = "The number of student who don't learn the courses from books is decreasing very fast since they've got tablets, laptops and so on. Authorities are alarmed, but me personaly I'm fine."
                },
                new Article
                {
                    CategoryID = 4,
                    ArticleName = "Basketball everywhere",
                    ImagePath = "image2.png",
                    DatePublished = DateTime.Parse("1/2/2017"),
                    ArticleID = 2,
                    Description = "Number of basketball's players has been increased miraculously in the last year and that's a benefit for the players, but also for equipment shops."
                },
                new Article
                {
                    CategoryID = 5,
                    ArticleName = "New iPhone 7 Plus is here and it's awesome",
                    ImagePath = "image3.png",
                    DatePublished = DateTime.Parse("10/2/2016"),
                    ArticleID = 4,
                    Description = "After Apple has launched their new mobile phones, we were more than enthusiast and get a new matte black iPhone 7 Plus to test in our studio."
                },
                new Article
                {
                    CategoryID = 1,
                    ArticleName = "The wars will not get us anywhere",
                    ImagePath = "image5.png",
                    DatePublished = DateTime.Parse("6/22/2016"),
                    ArticleID = 5,
                    Description = "Countries like Syria are in a dark period because of civil wars and a lot of citizens are in danger of death."
                }
            };

            return articles;
        }

        private static List<ProposedArticle> GetProposedArticles()
        {
            var articles = new List<ProposedArticle>
            {
                new ProposedArticle
                {
                    ArticleID = 1,
                    ArticleName = "Name Proposed 1",
                    CategoryID = 2,
                    ImagePath = "image3.png",
                    Description = "proposed article description"
                },
                new ProposedArticle
                {
                    ArticleID = 2,
                    ArticleName = "Name Proposed 2",
                    CategoryID = 4,
                    ImagePath = "image3.png",
                    Description = "proposed article description"
                },
                new ProposedArticle
                {
                    ArticleID = 3,
                    ArticleName = "Name Proposed 3",
                    CategoryID = 4,
                    ImagePath = "image3.png",
                    Description = "proposed article description"
                }
            };

            return articles;
        }

        private static List<ExternArticle> GetExternArticles()
        {
            var articles = new List<ExternArticle>
            {
                new ExternArticle
                {
                    ArticleID = 1,
                    ArticleName = "Clubul dorit de Gigi Becali, patronat de un om de afaceri sirian",
                    Link = "http://www.digisport.ro/Sport/FOTBAL/Competitii/Liga+1/Clubul+dorit+de+Gigi+Becali+patronat+de+un+om+de+afaceri+sirian",
                    DatePublished = DateTime.Parse("12/29/2016"),
                    ImagePath = "gigi.jpg",
                    CategoryID = 4
                },
                new ExternArticle
                {
                    ArticleID = 2,
                    ArticleName = "Charles Manson reportedly moved from hospital back to prison",
                    Link = "http://www.foxnews.com/us/2017/01/07/charles-manson-reportedly-moved-from-hospital-back-to-prison.html",
                    DatePublished = DateTime.Parse("01/07/2016"),
                    ImagePath = "charles.jpg",
                    CategoryID = 2
                }
            };

            return articles;
        }

        private static List<Comment> GetComments()
        {
            var comments = new List<Comment>
            {
                new Comment
                {
                    CommentID = 1,
                    ArticleID = 1,
                    Author = "Alexandru",
                    Description = "Comment number 1 for article number 1"
                },
                new Comment
                {
                    CommentID = 2,
                    ArticleID = 1,
                    Author = "Idosh",
                    Description = "Comment number 2 for article number 1"
                },
                new Comment
                {
                    CommentID = 3,
                    ArticleID = 2,
                    Author = "Gustav",
                    Description = "Comment number 3 for article number 2"
                },
                new Comment
                {
                    CommentID = 4,
                    ArticleID = 4,
                    Author = "Crina",
                    Description = "Comment number 4 for article number 4"
                },
                new Comment
                {
                    CommentID = 5,
                    ArticleID = 5,
                    Author = "Merind",
                    Description = "Comment number 5 for article number 5"
                },
            };

            return comments;
        }
    }
}
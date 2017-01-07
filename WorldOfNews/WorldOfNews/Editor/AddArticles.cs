using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorldOfNews.Models;

namespace WorldOfNews.Editor
{
    public class AddArticles
    {
        public bool AddArticle(string ArticleName, string ArticleDescription, DateTime ArticleDate, string ArticleCategory, string ArticleImagePath)
        {
            var myArticle = new Article();
            myArticle.ArticleName = ArticleName;
            myArticle.Description = ArticleDescription;
            myArticle.ImagePath = ArticleImagePath;
            myArticle.DatePublished = ArticleDate;
            myArticle.CategoryID = Convert.ToInt32(ArticleCategory);

            using (ArticleContext _db = new ArticleContext())
            {
                // Add article to DB.
                _db.Articles.Add(myArticle);
                _db.SaveChanges();
            }

            return true;
        }
    }
}
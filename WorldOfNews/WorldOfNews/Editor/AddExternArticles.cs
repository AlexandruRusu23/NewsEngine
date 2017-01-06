using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorldOfNews.Models;

namespace WorldOfNews.Editor
{
    public class AddExternArticles
    {
        public bool AddExternArticle(string ArticleName, string ArticleLink, string ArticleCategory, string ArticleImagePath)
        {
            var myArticle = new ExternArticle();
            myArticle.ArticleName = ArticleName;
            myArticle.Link = ArticleLink;
            myArticle.ImagePath = ArticleImagePath;
            myArticle.CategoryID = Convert.ToInt32(ArticleCategory);

            using (ArticleContext _db = new ArticleContext())
            {
                // Add article to DB.
                _db.ExternArticles.Add(myArticle);
                _db.SaveChanges();
            }

            return true;
        }
    }
}
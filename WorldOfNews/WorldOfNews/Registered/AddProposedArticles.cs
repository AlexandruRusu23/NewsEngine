using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorldOfNews.Models;

namespace WorldOfNews.Registered
{
    public class AddProposedArticles
    {
        public bool AddArticle(string ArticleName, string ArticleDescription, string ArticleCategory, string ArticleImagePath)
        {
            var myArticle = new ProposedArticle();
            myArticle.ArticleName = ArticleName;
            myArticle.Description = ArticleDescription;
            myArticle.ImagePath = ArticleImagePath;
            myArticle.CategoryID = Convert.ToInt32(ArticleCategory);

            using (ArticleContext _db = new ArticleContext())
            {
                // Add article to DB.
                _db.ProposedArticles.Add(myArticle);
                _db.SaveChanges();
            }

            return true;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NewsEngine.Models;

namespace NewsEngine.Logic
{
    public class AddArticles
    {
        public bool AddArticle(string ArticleName, string ArticleDesc, string ArticleCategory, string ArticleImagePath)
        {
            var myArticle = new Article();
            myArticle.ArticleName = ArticleName;
            myArticle.Description = ArticleDesc;
            myArticle.ImagePath = ArticleImagePath;
            myArticle.CategoryID = Convert.ToInt32(ArticleCategory);

            using (ArticleContext _db = new ArticleContext())
            {
                _db.Articles.Add(myArticle);
                _db.SaveChanges();
            }

            return true;
        }
    }
}
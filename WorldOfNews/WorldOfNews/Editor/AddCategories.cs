using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorldOfNews.Models;

namespace WorldOfNews.Editor
{
    public class AddCategories
    {
        public bool AddCategory(string categoryName)
        {
            var myCategory = new Category();
            myCategory.CategoryName = categoryName;

            using (ArticleContext _db = new ArticleContext())
            {
                // Add category to DB.
                _db.Categories.Add(myCategory);
                _db.SaveChanges();
            }

            return true;
        }
    }
}
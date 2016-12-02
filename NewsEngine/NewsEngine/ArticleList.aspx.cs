using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NewsEngine.Models;
using System.Web.ModelBinding;

namespace NewsEngine
{
    public partial class ArticleList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Article> GetArticles([QueryString("id")] int? categoryId)
        {
            var _db = new NewsEngine.Models.ArticleContext();

            IQueryable<Article> query = _db.Articles;
            if(categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoryID == categoryId);
            }
            return query;
        }
    }
}
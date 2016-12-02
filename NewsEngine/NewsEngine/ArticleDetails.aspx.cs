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
    public partial class ArticleDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Article> GetArticle([QueryString("articleID")] int? articleId)
        {
            var _db = new NewsEngine.Models.ArticleContext();

            IQueryable<Article> query = _db.Articles;
            if(articleId.HasValue && articleId > 0)
            {
                query = query.Where(p => p.ArticleID == articleId);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}
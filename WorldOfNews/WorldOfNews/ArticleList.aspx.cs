using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WorldOfNews.Models;
using System.Web.ModelBinding;
using System.Data.SqlClient;

namespace WorldOfNews
{
    public partial class ArticleList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Article> GetArticles([QueryString("id")] int? categoryId)
        {
            var _db = new WorldOfNews.Models.ArticleContext();
            IQueryable<Article> query = _db.Articles;
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoryID == categoryId);
            }

            string searchInput;
            searchInput = (string)Session["searchInput"];

            if (!string.IsNullOrEmpty(searchInput))
            {
                query = query.Where(p => (p.ArticleName.Contains(searchInput) || p.Description.Contains(searchInput) ));
                Session["searchInput"] = "";
            }

            string orderingInput;
            orderingInput = (string)Session["orderingInput"];

            switch (orderingInput)
            {
                case "A to Z":
                    return query.OrderBy(p => p.ArticleName);
                case "Z to A":
                    return query.OrderByDescending(p => p.ArticleName);
                case "From Old to New":
                    return query.OrderBy(p => p.DatePublished);
                case "From New to Old":
                    return query.OrderByDescending(p => p.DatePublished);
            }

            return query;
        }

        public IQueryable<ExternArticle> GetExternArticles([QueryString("id")] int? categoryId)
        {
            var _db = new WorldOfNews.Models.ArticleContext();
            IQueryable<ExternArticle> query = _db.ExternArticles;
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoryID == categoryId);
                query = query.OrderBy(p => p.ArticleName);
            }

            string searchInput;
            searchInput = (string)Session["searchInput2"];

            if (!string.IsNullOrEmpty(searchInput))
            {
                query = query.Where(p => (p.ArticleName.Contains(searchInput)));
                Session["searchInput2"] = "";
            }

            string orderingInput;
            orderingInput = (string)Session["orderingInput"];

            switch (orderingInput)
            {
                case "A to Z":
                    return query.OrderBy(p => p.ArticleName);
                case "Z to A":
                    return query.OrderByDescending(p => p.ArticleName);
                case "From Old to New":
                    return query.OrderBy(p => p.DatePublished);
                case "From New to Old":
                    return query.OrderByDescending(p => p.DatePublished);
            }

            return query;
        }

        protected void SearchArticles_Click(object sender, EventArgs e)
        {
            Session["searchInput"] = searchTextBox.Text;
            Session["searchInput2"] = searchTextBox.Text;
            searchTextBox.Text = "";
            Response.Redirect(Request.RawUrl);
        }

        protected void OrderArticlesDropDownMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["orderingInput"] = OrderArticlesDropDownMenu.SelectedValue.ToString();
            Response.Redirect(Request.RawUrl);
        }
    }
}
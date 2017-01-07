using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WorldOfNews.Models;
using WorldOfNews.Roles;

namespace WorldOfNews.Editor
{
    public partial class EditorPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string articleAction = Request.QueryString["ArticleAction"];
            string categoryAction = Request.QueryString["CategoryAction"];
            string externArticleAction = Request.QueryString["ExternArticleAction"];
            if (articleAction == "add")
            {
                LabelAddStatus.Text = "Article added!";
            }
            if (articleAction == "remove")
            {
                LabelRemoveStatus.Text = "Article removed!";
            }

            if (externArticleAction == "add")
            {
                LabelAddExternStatus.Text = "Extern Article added!";
            }
            if (externArticleAction == "remove")
            {
                LabelRemoveExternStatus.Text = "Extern Article removed!";
            }

            if (categoryAction == "add")
            {
                LabelAddCategoryStatus.Text = "Category added!";
            }
            if(categoryAction == "remove")
            {
                LabelRemoveCategoryStatus.Text = "Category removed!";
            }
            AddArticleDate.SelectedDate = DateTime.Today;
            AddExternArticleDate.SelectedDate = DateTime.Today;
        }

        protected void AddCategoryButton_Click(object sender, EventArgs e)
        {
            AddCategories category = new AddCategories();
            bool addSuccess = category.AddCategory(AddCategoryName.Text);
            if (addSuccess)
            {
                // Reload the page.
                string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                Response.Redirect(pageUrl + "?CategoryAction=add");
            }
            else
            {
                LabelAddStatus.Text = "Unable to add new category to database.";
            }
        }

        protected void AddArticleButton_Click(object sender, EventArgs e)
        {
            Boolean fileOK = false;
            String path = Server.MapPath("~/Images/");
            if (ArticleImage.HasFile)
            {
                String fileExtension = System.IO.Path.GetExtension(ArticleImage.FileName).ToLower();
                String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (fileExtension == allowedExtensions[i])
                    {
                        fileOK = true;
                    }
                }
            }

            if (fileOK)
            {
                try
                {
                    // Save to Images folder.
                    ArticleImage.PostedFile.SaveAs(path + ArticleImage.FileName);
                    // Save to Images/Thumbs folder.
                    ArticleImage.PostedFile.SaveAs(path + "Thumbs/" + ArticleImage.FileName);
                }
                catch (Exception ex)
                {
                    LabelAddStatus.Text = ex.Message;
                }

                // Add product data to DB.
                AddArticles articles = new AddArticles();
                bool addSuccess = articles.AddArticle(AddArticleName.Text, AddArticleDescription.Text, AddArticleDate.SelectedDate,
                        DropDownAddCategory.SelectedValue, ArticleImage.FileName);
                if (addSuccess)
                {
                    // Reload the page.
                    string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                    Response.Redirect(pageUrl + "?ArticleAction=add");
                }
                else
                {
                    LabelAddStatus.Text = "Unable to add new article to database.";
                }
            }
            else
            {
                LabelAddStatus.Text = "Unable to accept file type.";
            }
        }

        protected void AddExternArticleButton_Click(object sender, EventArgs e)
        {
            Boolean fileOK = false;
            String path = Server.MapPath("~/Images/");
            if (ExternArticleImage.HasFile)
            {
                String fileExtension = System.IO.Path.GetExtension(ExternArticleImage.FileName).ToLower();
                String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (fileExtension == allowedExtensions[i])
                    {
                        fileOK = true;
                    }
                }
            }

            if (fileOK)
            {
                try
                {
                    // Save to Images folder.
                    ExternArticleImage.PostedFile.SaveAs(path + ExternArticleImage.FileName);
                    // Save to Images/Thumbs folder.
                    ExternArticleImage.PostedFile.SaveAs(path + "Thumbs/" + ExternArticleImage.FileName);
                }
                catch (Exception ex)
                {
                    LabelAddExternStatus.Text = ex.Message;
                }

                // Add product data to DB.
                AddExternArticles articles = new AddExternArticles();
                bool addSuccess = articles.AddExternArticle(AddExternArticleName.Text, AddExternArticleLink.Text, AddExternArticleDate.SelectedDate,
                        DropDownAddExternCategory.SelectedValue, ExternArticleImage.FileName);
                if (addSuccess)
                {
                    // Reload the page.
                    string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                    Response.Redirect(pageUrl + "?ExternArticleAction=add");
                }
                else
                {
                    LabelAddStatus.Text = "Unable to add new article to database.";
                }
            }
            else
            {
                LabelAddStatus.Text = "Unable to accept file type.";
            }
        }

        public IQueryable GetCategories()
        {
            var _db = new WorldOfNews.Models.ArticleContext();
            IQueryable query = _db.Categories;
            return query;
        }

        public IQueryable GetArticles()
        {
            var _db = new WorldOfNews.Models.ArticleContext();
            IQueryable query = _db.Articles;
            return query;
        }

        public IQueryable GetExternArticles()
        {
            var _db = new WorldOfNews.Models.ArticleContext();
            IQueryable query = _db.ExternArticles;
            return query;
        }

        protected void RemoveArticleButton_Click(object sender, EventArgs e)
        {
            using (var _db = new WorldOfNews.Models.ArticleContext())
            {
                int articleId = Convert.ToInt16(DropDownRemoveArticle.SelectedValue);
                var myItem = (from c in _db.Articles where c.ArticleID == articleId select c).FirstOrDefault();
                if (myItem != null)
                {
                    _db.Articles.Remove(myItem);
                    _db.SaveChanges();

                    // Reload the page.
                    string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                    Response.Redirect(pageUrl + "?ArticleAction=remove");
                }
                else
                {
                    LabelRemoveStatus.Text = "Unable to locate article.";
                }
            }
        }

        protected void RemoveExternArticleButton_Click(object sender, EventArgs e)
        {
            using (var _db = new WorldOfNews.Models.ArticleContext())
            {
                int articleId = Convert.ToInt16(DropDownRemoveExternArticle.SelectedValue);
                var myItem = (from c in _db.ExternArticles where c.ArticleID == articleId select c).FirstOrDefault();
                if (myItem != null)
                {
                    _db.ExternArticles.Remove(myItem);
                    _db.SaveChanges();

                    // Reload the page.
                    string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                    Response.Redirect(pageUrl + "?ExternArticleAction=remove");
                }
                else
                {
                    LabelRemoveStatus.Text = "Unable to locate article.";
                }
            }
        }

        protected void RemoveCategoryButton_Click(object sender, EventArgs e)
        {
            using (var _db = new WorldOfNews.Models.ArticleContext())
            {
                int categoryId;
                try
                {
                    categoryId = Convert.ToInt16(DropDownRemoveCategory.SelectedValue);
                }
                catch (Exception ex)
                {
                    categoryId = -1;
                }
                var myItems = from c in _db.Articles where c.CategoryID == categoryId select c;
                if (myItems != null)
                {
                    foreach (var iter in myItems)
                    {
                        _db.Articles.Remove(iter);
                    }
                    var myCategory = (from c in _db.Categories where c.CategoryID == categoryId select c).FirstOrDefault();
                    if (myCategory != null)
                    {
                        _db.Categories.Remove(myCategory);
                        _db.SaveChanges();
                    }
                    else
                    {
                        LabelRemoveStatus.Text += "Category not found.";
                    }
                    string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                    Response.Redirect(pageUrl + "?CategoryAction=remove");
                }
                else
                {
                    LabelRemoveStatus.Text += "No category found.";
                }
            }
        }

        protected void AddArticleDate_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void AddExternArticleDate_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
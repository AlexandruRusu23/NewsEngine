using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WorldOfNews.Editor;

namespace WorldOfNews.Registered
{
    public partial class RegisteredPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string articleAction = Request.QueryString["ArticleAction"];
            if (articleAction == "add")
            {
                LabelAddStatus.Text = "Article proposed!";
            }
        }

        public IQueryable GetCategories()
        {
            var _db = new WorldOfNews.Models.ArticleContext();
            IQueryable query = _db.Categories;
            return query;
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
                AddProposedArticles articles = new AddProposedArticles();
                bool addSuccess = articles.AddArticle(AddArticleName.Text, AddArticleDescription.Text,
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

    }
}
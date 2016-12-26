using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WorldOfNews.Models;
using WorldOfNews.Editor;
using System.Web.ModelBinding;

namespace WorldOfNews
{
    public partial class ArticleDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public IQueryable<Article> GetArticle([QueryString("articleID")] int? articleId)
        {
            var _db = new WorldOfNews.Models.ArticleContext();
            IQueryable<Article> query = _db.Articles;
            if (articleId.HasValue && articleId > 0)
            {
                query = query.Where(p => p.ArticleID == articleId);
            }
            else
            {
                query = null;
            }
            return query;
        }

        public IQueryable<Comment> GetComments([QueryString("articleID")] int? articleId)
        {
            var _db = new WorldOfNews.Models.ArticleContext();
            IQueryable<Comment> query = _db.Comments;
            if (articleId.HasValue && articleId > 0)
            {
                query = query.Where(p => p.ArticleID == articleId);
            }
            return query;
        }

        protected void AddCommentButton_Click(object sender, EventArgs e)
        {
            int? myArticleId = Convert.ToInt32(DropDownAddComment.SelectedValue);
            AddComments comment = new AddComments();
            if (myArticleId.HasValue && myArticleId > 0)
            {
                bool addSuccess = comment.AddComment(Convert.ToString(myArticleId), AddCommentAuthor.Text, AddComment.Text);
                if(addSuccess)
                {
                    string pageUrl = Request.RawUrl.ToString();
                    Response.Redirect(pageUrl);
                }
                else
                {
                    LabelAddStatus.Text = "Unable to add comment to database";
                }
            }
            else
            {
                LabelAddStatus.Text = "There is a problem with database.";
            }
        }
    }
}
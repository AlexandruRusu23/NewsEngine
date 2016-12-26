using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorldOfNews.Models;

namespace WorldOfNews.Editor
{
    public class AddComments
    {
        public bool AddComment(string ArticleId, string CommentAuthor, string CommentDescription)
        {
            var myComment = new Comment();
            myComment.ArticleID = Convert.ToInt32(ArticleId);
            myComment.Author = CommentAuthor;
            myComment.Description = CommentDescription;

            using (ArticleContext _db = new ArticleContext())
            {
                // Add comment to DB.
                _db.Comments.Add(myComment);
                _db.SaveChanges();
            }

            return true;
        }
    }
}
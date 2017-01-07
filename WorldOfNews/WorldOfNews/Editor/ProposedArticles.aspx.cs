using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WorldOfNews.Editor
{
    public partial class ProposedArticles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DetailsView1_RowCommand(object sender, DetailsViewCommandEventArgs e)
        {
            if(e.CommandName == "AddToArticles")
            {
                string myArticleName = ProposedArticlesDetails.Rows[1].Cells[1].Text;
                string myDescription = ProposedArticlesDetails.Rows[2].Cells[1].Text;
                string myImagePath = ProposedArticlesDetails.Rows[4].Cells[1].Text;
                string myCategoryID = ProposedArticlesDetails.Rows[5].Cells[1].Text;

                AddArticles articles = new AddArticles();
                bool addSuccess = articles.AddArticle(myArticleName, myDescription, DateTime.UtcNow,
                        myCategoryID, myImagePath);
                if (addSuccess)
                {
                    LabelAddStatus.Text = "Article proposed by user had been added in database.";
                    ProposedArticlesDetails.DeleteItem();
                }
                else
                {
                    LabelAddStatus.Text = "Unable to add new article to database.";
                }
            }
        }
    }
}
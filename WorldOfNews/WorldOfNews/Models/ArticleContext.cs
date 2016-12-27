using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WorldOfNews.Models
{
    public class ArticleContext : DbContext
    {
        public ArticleContext() : base("EngineDatabase")
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ProposedArticle> ProposedArticles { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
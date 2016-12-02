using System;
using System.Collections.Generic;
using System.Data.Entity;
using NewsEngine.Models;
using System.Linq;
using System.Web;

namespace NewsEngine.Models
{
    public class ArticleContext : DbContext
    {
        public ArticleContext() : base("NewsEngine") { }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Article> Articles { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WorldOfNews.Models
{
    public class ProposedArticle
    {
        [ScaffoldColumn(false), Key]
        public int ArticleID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string ArticleName { get; set; }

        [Required, Display(Name = "Article Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string ImagePath { get; set; }

        public int? CategoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}
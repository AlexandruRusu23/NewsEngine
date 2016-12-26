using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WorldOfNews.Models
{
    public class Comment
    {
        [ScaffoldColumn(false)]
        public int CommentID { get; set; }

        [Required]
        public int ArticleID { get; set; }

        [Required, StringLength(50)]
        public string Author { get; set; }

        [Required, StringLength(1000), Display(Name = "Comment Description")]
        public string Description { get; set; }
    }
}
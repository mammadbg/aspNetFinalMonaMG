using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonaWebApp.Models
{
    public class Blogs
    {
        public int BlogId { get; set; }
        public string BlogName { get; set; }
        public DateTime BlogDate { get; set; }
        public int BlogAuthor { get; set; }
        public string Quote { get; set; }
        public int QuoteAuthor { get; set; }
        public int BlogCategory { get; set; }
        public int BlogTags { get; set; } 
        public int BlogPhoto { get; set; }

    }
}
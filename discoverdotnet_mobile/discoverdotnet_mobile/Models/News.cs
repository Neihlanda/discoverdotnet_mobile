using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace discoverdotnet_mobile.Models
{
    public class News
    {
        public string FeedLink { get; set; }
        public string FeedTitle { get; set; }
        public string Title { get; set; }
        [PrimaryKey]
        public string Link { get; set; }
        public DateTime Published { get; set; }
        public IDictionary<string, string> Links { get; }
        public string Author { get; set; }
        public bool Bookmarked { get;set; }
    }
}
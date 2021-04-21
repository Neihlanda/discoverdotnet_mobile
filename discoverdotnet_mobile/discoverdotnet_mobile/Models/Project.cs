using System;
using System.Collections.Generic;
using System.Text;

namespace discoverdotnet_mobile.Models
{
    public class Project
    {
        public string Key { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Image { get; set; }
        public object NuGet { get; set; }
        public string SourceCode { get; set; }
        public string Description { get; set; }
        public int StargazersCount { get; set; }
        public int ForksCount { get; set; }
        public int OpenIssuesCount { get; set; }
        public DateTime PushedAt { get; set; }
        public string Website { get; set; }
        public string Language { get; set; }
        public string[] Tags { get; set; }
        public string Donations { get; set; }
        public bool Foundation { get; set; }
        public string Comment { get; set; }
        public bool Microsoft { get; set; }
        public bool Platform { get; set; }
    }
}

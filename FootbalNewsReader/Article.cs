using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;

namespace FootbalNewsReader
{
    public class Article
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Provider { get; set; }
        public string Link { get; set; }

        public Article(string title, string summary, DateTime publishedDate, string link, string provider)
        {
            Title = title.ToLower().Trim();
            Summary = summary.ToLower().Trim();
            PublishedDate = publishedDate;
            Provider = provider;
        }

        public Article(SyndicationItem item, string provider)
        {
            Title = item.Title.Text.ToLower().Trim();
            Summary = item.Summary.Text.ToLower().Trim();
            PublishedDate = item.PublishDate.DateTime;
            Link = item.Id;
            Provider = provider;
        }
    }
}

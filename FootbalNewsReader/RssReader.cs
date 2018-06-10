using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;
using System.Xml;
using System.Reflection;

namespace FootbalNewsReader
{
    class RssReader
    {
        private string _url;

        public RssReader(string url)
        {
            _url = url;
        }

        public List<Article> GetArticles(string provider)
        {
            XmlReader reader = XmlReader.Create(_url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();
            var articles = new List<Article>();
            foreach (SyndicationItem item in feed.Items)
            {
                articles.Add(new Article(item, provider));
            }

            return articles;
        }
    }
}

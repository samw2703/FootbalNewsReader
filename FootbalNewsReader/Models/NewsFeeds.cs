using FootbalNewsReader.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using FootbalNewsReader;
using System.Data;

namespace FootbalNewsReader.Models
{
    public class NewsFeeds
    {
        public int Id { get; }
        public string Provider { get; set; }
        public string Url { get; set; }

        public NewsFeeds(string provider, string url)
        {
            Provider = provider;
            Url = url;
        }

        public NewsFeeds(string provider, string url, int id)
        {
            Provider = provider;
            Url = url;
            Id = id;
        }
    }
}

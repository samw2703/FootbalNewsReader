using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootbalNewsReader
{
    class ArticlesFilterer
    {
        private List<string> _filterWords;

        public ArticlesFilterer(List<string> filterWords)
        {
            _filterWords = filterWords;
        }

        public List<Article> FilterForAllWords(List<Article> inputArticles)
        {
            var outputArticles = new List<Article>();
            foreach (var article in inputArticles)
            {
                if (ArticleContainsAllFilterWords(article, _filterWords))
                    outputArticles.Add(article);
            }

            return outputArticles;
        }

        private bool ArticleContainsAllFilterWords(Article article, List<string> filterWords) 
        {
            foreach (var word in filterWords)
            {
                if (!article.Title.Contains(word) && !article.Summary.Contains(word))
                    return false;
            }

            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FootbalNewsReader.Models
{
    class NewsFeedsDatabaseModel
    {
        private string _tableName = "dbo.newsFeeds";
        private DatabasePropertyShell _id = new DatabasePropertyShell("feedId", SqlDataType.sqlInt);
        private DatabasePropertyShell _provider = new DatabasePropertyShell("feedProvider", SqlDataType.sqlVarchar);
        private DatabasePropertyShell _url = new DatabasePropertyShell("feedUrl", SqlDataType.sqlVarchar);

        public List<NewsFeeds> GetNewsFeeds()
        {
            string selectString = SqlQueryBuilder.BuildSelectStatement(_tableName, new List<DatabaseProperty>
                { new DatabaseProperty(_id), new DatabaseProperty(_provider), new DatabaseProperty(_url) });
            DataTable dataTable = FootballNewsReaderSqlConnection.Select(selectString);
            List<NewsFeeds> newsFeeds = new List<NewsFeeds>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                newsFeeds.Add(new NewsFeeds(dataRow["feedProvider"].ToString(), dataRow["feedUrl"].ToString(), (int)dataRow["feedId"]));
            }

            return newsFeeds;
        }

        public void InsertNewsFeed(NewsFeeds newsFeed)
        {
            List<DatabaseProperty> databaseProperties = new List<DatabaseProperty>
                {
                    new DatabaseProperty(_provider, newsFeed.Provider),
                    new DatabaseProperty(_url, newsFeed.Url)
                };
            string insertString = SqlQueryBuilder.BuildInsertIntoStatement(_tableName, databaseProperties);

            FootballNewsReaderSqlConnection.Insert(insertString);
        }

        public void UpdateNewsFeed(NewsFeeds newsFeed)
        {
            List<DatabaseProperty> editableDatabaseProperties = new List<DatabaseProperty>
            {
                new DatabaseProperty(_provider, newsFeed.Provider),
                new DatabaseProperty(_url, newsFeed.Url)
            };
            List<DatabaseProperty> primaryKeyDatabaseProperties = new List<DatabaseProperty>
            {
                new DatabaseProperty(_id, newsFeed.Id.ToString())
            };

            string updateString = SqlQueryBuilder.BuildUpdateStatement(_tableName, editableDatabaseProperties, primaryKeyDatabaseProperties);
            FootballNewsReaderSqlConnection.Update(updateString);
        }

        public void DeleteNewsFeed(int id)
        {
            List<DatabaseProperty> primaryKeyProperties = new List<DatabaseProperty>
            {
                new DatabaseProperty(_id, id.ToString())
            };

            string deleteString = SqlQueryBuilder.BuildDeleteStatement(_tableName, primaryKeyProperties);
            FootballNewsReaderSqlConnection.Delete(deleteString);
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootbalNewsReader.Models;
using ClassLibrary1;

namespace FootbalNewsReader
{
    public partial class Form1 : Form
    {
        private List<NewsFeeds> newsFeeds;
        private List<Player> players;

        public Form1()
        {
            InitializeComponent();
            InitializeFormControls();
            GetFeeds();
            GetPlayers();
        }

        private void InitializeFormControls()
        {
            tabControl.Width = Screen.FromControl(this).Bounds.Width - 100;
            tabControl.Height = Screen.FromControl(this).Bounds.Height - 100;
            listView.Width = tabControl.Width - 50;
            listView.Height = tabControl.Height - 100;
            listView.Columns[0].Width = listView.Width / 3;
            listView.Columns[1].Width = listView.Width - listView.Columns[0].Width;
        }

        private void buttonSaveFeeds_Click(object sender, EventArgs e)
        {
            SaveNewFeeds();
            SaveEditedFeeds();
            GetFeeds();
        }

        private void GetFeeds()
        {
            dataGridViewFeeds.Rows.Clear();
            var newsFeedsDatabaseModel = new NewsFeedsDatabaseModel();
            newsFeeds = newsFeedsDatabaseModel.GetNewsFeeds();
            foreach (var newsFeed in newsFeeds)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridViewFeeds.Rows[0].Clone();
                row.Cells[0].Value = newsFeed.Id;
                row.Cells[1].Value = newsFeed.Provider;
                row.Cells[2].Value = newsFeed.Url;
                dataGridViewFeeds.Rows.Add(row);
            }
        }

        private void SaveNewFeeds()
        {
            List<NewsFeeds> newNewsFeeds = new List<NewsFeeds>();
            foreach (DataGridViewRow row in dataGridViewFeeds.Rows)
            {
                if (row.Cells[0].Value == null && row.Cells[1].Value != null && row.Cells[2].Value != null)
                    newNewsFeeds.Add(new NewsFeeds(row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString()));
            }

            var newsFeedDatabaseModel = new NewsFeedsDatabaseModel();
            foreach (var newsFeed in newNewsFeeds)
            {
                newsFeedDatabaseModel.InsertNewsFeed(newsFeed);
            }
        }

        private void SaveEditedFeeds()
        {
            List<NewsFeeds> editedNewsFeeds = new List<NewsFeeds>();
            foreach (DataGridViewRow row in dataGridViewFeeds.Rows)
            {
                if (row.Cells[0].Value == null)
                    continue;

                var newsFeed = newsFeeds.Where(c => c.Id == (int)row.Cells[0].Value).First();
                if (row.Cells[1].Value.ToString() != newsFeed.Provider || row.Cells[2].Value.ToString() != newsFeed.Url)
                    editedNewsFeeds.Add(new NewsFeeds(row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), (int)row.Cells[0].Value));
            }

            var newsFeedDatabaseModel = new NewsFeedsDatabaseModel();
            foreach (var newsFeed in editedNewsFeeds)
            {
                newsFeedDatabaseModel.UpdateNewsFeed(newsFeed);
            }
        }

        private void dataGridViewFeeds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (senderGrid.Columns[e.ColumnIndex].Name == "ColumnDelete")
                {
                    var newsFeedDatabaseModel = new NewsFeedsDatabaseModel();
                    newsFeedDatabaseModel.DeleteNewsFeed((int)senderGrid.Rows[e.RowIndex].Cells[0].Value);
                    GetFeeds();
                }
            }
        }

        private void GetPlayers()
        {
            dataGridViewPlayers.Rows.Clear();
            var playersDatabaseModel = new PlayerDatabaseModel();
            players = playersDatabaseModel.GetPlayers();
            foreach (var player in players)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridViewPlayers.Rows[0].Clone();
                row.Cells[0].Value = player.Id;
                row.Cells[1].Value = player.Name;
                dataGridViewPlayers.Rows.Add(row);
            }
        }

        private void SaveNewPlayers()
        {
            List<Player> newPlayers = new List<Player>();
            foreach (DataGridViewRow row in dataGridViewPlayers.Rows)
            {
                if (row.Cells[0].Value == null && row.Cells[1].Value != null)
                    newPlayers.Add(new Player(row.Cells[1].Value.ToString()));
            }

            var playerDatabaseModel = new PlayerDatabaseModel();
            foreach (var newPlayer in newPlayers)
            {
                playerDatabaseModel.PostPlayer(newPlayer);
            }
        }

        private void SaveEditedPlayers()
        {
            var editedPlayers = new List<Player>();
            foreach (DataGridViewRow row in dataGridViewPlayers.Rows)
            {
                if (row.Cells[0].Value == null)
                    continue;

                var player = players.Where(c => c.Id == (int)row.Cells[0].Value).First();
                if (row.Cells[1].Value.ToString() != player.Name)
                    editedPlayers.Add(new Player(row.Cells[1].Value.ToString(), (int)row.Cells[0].Value));
            }

            var playerDatabaseModel = new PlayerDatabaseModel();
            foreach (var editedPlayer in editedPlayers)
            {
                playerDatabaseModel.PutPlayer(editedPlayer);
            }
        }

        private void buttonSavePlayers_Click(object sender, EventArgs e)
        {
            SaveNewPlayers();
            SaveEditedPlayers();
            GetPlayers();
        }

        private void dataGridViewPlayers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (senderGrid.Columns[e.ColumnIndex].Name == "ColumnPlayerDelete")
                {
                    var playersDatabaseModel = new PlayerDatabaseModel();
                    playersDatabaseModel.DeletePlayer((int)senderGrid.Rows[e.RowIndex].Cells[0].Value);
                    GetPlayers();
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var articles = GetArticles();
            var playerArticlesDict = new Dictionary<string, List<Article>>();
            foreach (var player in players)
            {
                playerArticlesDict.Add(player.Name, new List<Article>());
                List<string> playerNameList = player.Name.Split(null).ToList();
                List<Article> articlesForPlayer = articles.Where(c => (c.Title + " " + c.Summary).ContainsAll(playerNameList)).ToList();
                playerArticlesDict[player.Name].AddRange(articlesForPlayer);
            }
            playerArticlesDict.OrderBy(c => c.Value.Count);

            foreach (KeyValuePair<string, List<Article>> entry in playerArticlesDict)
            {
                var listViewGroup = new ListViewGroup(entry.Key, HorizontalAlignment.Left);
                listView.Groups.Add(listViewGroup);
                foreach (var article in entry.Value)
                {
                    var listViewItem = new ListViewItem(new string[] { article.Provider + " - " + article.Title, article.Summary }, listViewGroup);
                    listView.Items.Add(listViewItem);
                }
            }

            //var test = new ListViewGroup("Toby Alderweireld", HorizontalAlignment.Left);
            //listView.Groups.Add(test);
            //listView.Items.Add(new ListViewItem("H e l l o" + Environment.NewLine + "there", test));

            //listView.Items[0].Group = listView.Groups[0];
        }

        private List<Article> GetArticles()
        {
            var articles = new List<Article>();
            foreach (var feed in newsFeeds)
            {
                var reader = new RssReader(feed.Url);
                articles.AddRange(reader.GetArticles(feed.Provider));
            }

            return articles.Where(c => c.PublishedDate > DateTime.Now.AddHours(-24)).ToList();
        }

    }
}

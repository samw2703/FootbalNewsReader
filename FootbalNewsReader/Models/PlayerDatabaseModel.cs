using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FootbalNewsReader.Models
{
    class PlayerDatabaseModel
    {
        private string _tableName = "dbo.Players";
        private DatabasePropertyShell _id = new DatabasePropertyShell("playerId", SqlDataType.sqlInt);
        private DatabasePropertyShell _name = new DatabasePropertyShell("playerName", SqlDataType.sqlVarchar);

        public List<Player> GetPlayers()
        {
            string selectString = SqlQueryBuilder.BuildSelectStatement(_tableName, new List<DatabaseProperty>
            {
                new DatabaseProperty(_id),
                new DatabaseProperty(_name)
            });
            DataTable dataTable = FootballNewsReaderSqlConnection.Select(selectString);
            List<Player> players = new List<Player>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                players.Add(new Player(dataRow["playerName"].ToString(), (int)dataRow["playerId"]));
            }

            return players;
        }

        public Player GetPlayer(int id)
        {
            return new Player("Sam Watson");
        }

        public void PostPlayer(Player player)
        {
            List<DatabaseProperty> databaseProperties = new List<DatabaseProperty>
                {
                    new DatabaseProperty(_name, player.Name)
                };
            string insertString = SqlQueryBuilder.BuildInsertIntoStatement(_tableName, databaseProperties);

            FootballNewsReaderSqlConnection.Insert(insertString);
        }

        public void PutPlayer(Player player)
        {
            List<DatabaseProperty> editableDatabaseProperties = new List<DatabaseProperty>
            {
                new DatabaseProperty(_name, player.Name)
            };
            List<DatabaseProperty> primaryKeyDatabaseProperties = new List<DatabaseProperty>
            {
                new DatabaseProperty(_id, player.Id.ToString())
            };

            string updateString = SqlQueryBuilder.BuildUpdateStatement(_tableName, editableDatabaseProperties, primaryKeyDatabaseProperties);
            FootballNewsReaderSqlConnection.Update(updateString);
        }

        public void DeletePlayer(int id)
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

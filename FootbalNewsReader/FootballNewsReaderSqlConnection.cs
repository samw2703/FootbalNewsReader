using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace FootbalNewsReader
{
    static class FootballNewsReaderSqlConnection
    {
        private static string connectionString = "user id=swatson; password=Nordic20; server=HP\\SAMINHO; Trusted_Connection=yes; database=FootballNewsReader; connection timeout = 30";

        public static DataTable Select(string selectQuery)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(selectQuery, conn);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                da.Fill(ds, "table");
                dt = ds.Tables["table"];
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public static int ExecuteTransactSql(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query))
                {
                    command.Connection = connection;
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

        public static int Insert(string insertQuery)
        {
            return ExecuteTransactSql(insertQuery);
        }
        
        public static int Update(string updateQuery)
        {
            return ExecuteTransactSql(updateQuery);
        } 

        public static int Delete(string deleteQuery)
        {
            return ExecuteTransactSql(deleteQuery);
        }

    }
}

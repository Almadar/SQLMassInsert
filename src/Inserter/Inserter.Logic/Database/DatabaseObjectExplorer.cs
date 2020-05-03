using System.Collections.Generic;
using System.Data.SqlClient;

namespace Inserter.Logic.Database
{
    public class DatabaseObjectExplorer
    {
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        private string UserName { get; set; }
        private string Password { get; set; }
        
        public List<string> DatabaseList { get; set; }
        public List<string> TableList { get; set; }
        public List<string> ColumnList { get; set; }
        
        private string connectionString;
        private SqlConnection connection;           

        public DatabaseObjectExplorer(string server, string db)
        {
            ServerName = server;
            DatabaseName = db;

            connectionString = $"Server={ServerName}, Database={DatabaseName}, Trusted Connection=True";
            connection = new SqlConnection(connectionString);

            InstanceObjects();
        }

        public DatabaseObjectExplorer(string server, string db, string user, string pwd)
        {
            ServerName = server;
            DatabaseName = db;
            UserName = user;
            Password = pwd;

            connectionString = $"Server={ServerName}, Database={DatabaseName}, User Id={UserName}, Password={Password}";
            connection = new SqlConnection(connectionString);

            InstanceObjects();
        }

        private void InstanceObjects()
        {
            DatabaseList = new List<string>();
            TableList = new List<string>();
            ColumnList = new List<string>();
        }

        public List<string> GetAllDatabaseNames()
        {
            try
            {
                connection.Open();
                var cmd = new SqlCommand(Constants.QUERY_ALL_DATABASES);
                var results = cmd.ExecuteReader();
                connection.Close();
                DatabaseList = GetListFromDataReader(results);
            }
            catch
            {
                throw;
            }

            return DatabaseList; ;
        }

        public List<string> GetTableNamesFromCurrentDatabase()
        {
            try
            {
                connection.Open();
                var cmd = new SqlCommand(Constants.QUERY_ALL_TABLES);
                var results = cmd.ExecuteReader();
                connection.Close();
                TableList = GetListFromDataReader(results);
            }
            catch
            {
                throw;
            }

            return TableList;
        }

        public List<string> GetColumnsFromTable(string tableName)
        {
            try
            {
                connection.Open();
                var cmd = new SqlCommand(string.Format(Constants.QUERY_ALL_COLUMNS, tableName));
                var results = cmd.ExecuteReader();
                connection.Close();
                ColumnList = GetListFromDataReader(results);
            }
            catch
            {
                throw;
            }

            return ColumnList;
        }

        private List<string> GetListFromDataReader(SqlDataReader source)
        {
            var results = new List<string>();

            if (source.HasRows)
            {
                while (source.Read())
                {
                    results.Add(source[0].ToString());
                }
            }

            return results;
        }
    }
}

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
        public List<string> ViewList { get; set; }
        public List<string> StoredProcedureList { get; set; }
        
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
            ViewList = new List<string>();
            StoredProcedureList = new List<string>();
        }

        public List<string> GetAllDatabaseNames()
        {
            var databases = new List<string>();

            try
            {
                connection.Open();
                connection.Close();
            }
            catch
            {
                throw;
            }

            return databases;
        }
    }
}

namespace Inserter.Logic.Database
{
    public static class Constants
    {
        public static readonly string QUERY_ALL_DATABASES = "SELECT name FROM sys.databases";
        public static readonly string QUERY_ALL_TABLES = "SELECT name FROM sys.tables";
        public static readonly string QUERY_ALL_COLUMNS = "SELECT name FROM sys.columns WHERE object_id = (SELECT object_id FROM sys.tables WHERE name = '{0}'";
    }
}

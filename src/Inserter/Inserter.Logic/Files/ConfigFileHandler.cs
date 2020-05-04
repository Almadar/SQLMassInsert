using System.Collections.Generic;
using System.IO;

namespace Inserter.Logic.Files
{
    public class ConfigFileHandler
    {
        public string FilePath { get; set; }
        public List<string> Servers { get; set; }
        public List<string> Databases { get; set; }

        private FileStream file;

        public ConfigFileHandler(string filePath)
        {
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }

            FilePath = filePath;
        }

        public string[] GetAllConfigurationData()
        {
            return File.ReadAllLines(FilePath);
        }

        public List<string> GetAllServers()
        {
            var serverList = new List<string>();
            var lines = File.ReadAllLines(FilePath);

            foreach (string line in lines)
            {
                var elements = line.Split(',');
                int foundAlias = serverList.IndexOf(elements[0]);

                if (foundAlias == -1)
                {
                    serverList.Add(elements[0] + " - " + elements[1]);
                }
            }

            Servers = serverList;
            return serverList;
        }

        public List<string> GetAllDatabasesInServer(string alias, string server)
        {
            var dbList = new List<string>();
            var lines = File.ReadAllLines(FilePath);

            foreach (string line in lines)
            {
                var elements = line.Split(',');

                if (elements[0] == alias || elements[1] == server)
                {
                    dbList.Add(elements[2]);
                }
            }

            Databases = dbList;
            return dbList;
        }

        public void WriteConfig(string config)
        {
            File.AppendAllText(FilePath, config);
        }
    }
}

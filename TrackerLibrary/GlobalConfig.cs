using Microsoft.Extensions.Configuration;


namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }
        public static IConfigurationRoot configuration;

        static GlobalConfig()
        {
            configuration = new ConfigurationBuilder()
                .AddJsonFile("config.json")
                .Build();
        }

        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                //TODO set up the sql connector properly

                var sql = new SqlConnector();
                Connection = sql;
            }
            else if (db == DatabaseType.TextFile)
            {
                //TODO create textFiles connection
                var text = new TextFileConnector();
                Connection = text;
            }
        }

        public static string ConnectionString(string name)
        {
            return configuration.GetConnectionString(name);
        }
    }
}
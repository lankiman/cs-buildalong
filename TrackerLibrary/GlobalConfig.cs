using Microsoft.Extensions.Configuration;


namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

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
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .AddJsonFile("config.json")
                .Build();

            return configuration.GetConnectionString(name);
        }
    }
}
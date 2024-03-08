using Microsoft.Extensions.Configuration;


namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                //TODO set up the sql connector properly

                var sql = new SqlConnector();
                Connections.Add(sql);
            }

            if (textFiles)
            {
                //TODO create textFiles connection
                var text = new TextFileConnector();
                Connections.Add(text);
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
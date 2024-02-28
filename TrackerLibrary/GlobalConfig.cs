﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
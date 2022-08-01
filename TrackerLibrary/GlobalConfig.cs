using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataconnection> Connections { get; private set; } = new List<IDataconnection>();

        public static void InitializeConnections(bool database, bool textfiles)
        {
            if (database)
            {
                //TODO - Set up the SQL Connector properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if (textfiles)
            {
                //TODO - Create the text connection
                TextConnection text = new TextConnection();
                Connections.Add(text);
            }
        }
    }
}

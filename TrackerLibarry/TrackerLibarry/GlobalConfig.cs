using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibarry
{
   public static class GlobalConfig
    {
        // public static List<IDbconnection> connection { get; private set; } = new List<IDbconnection>();
        public static IDbconnection connection { get; private set; } 

        public static void initializeConnection(databaseType db) {
            
            //switch (db)
            //{
            //    case databaseType.Sql:
            //        SqlConnector sql = new SqlConnector();
            //        connection = sql;
            //        break;
            //    case databaseType.textFile:
            //        TextConnector Text = new TextConnector();
            //        connection = Text;
            //        break;
            //    default:
            //        break;
            //}
            if (db == databaseType.Sql) {
                //TODO - makeconnection
                SqlConnector sql = new SqlConnector();
                connection = sql;
            }

           else if (db == databaseType.textFile) {
                //TODO - make text Connection
                TextConnector Text = new TextConnector();
                connection = Text;
            }

        }

        public static string ConnString(string name) {

            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}

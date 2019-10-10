using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchedulerLibrary.DataAccess;
using System.Configuration;

namespace SchedulerLibrary
{
    public class GlobalConfig
    {
        /// <summary>
        /// Your connection.
        /// (You can have one or more data sources to save  or pull from).
        /// </summary>
        public static IDataConnection Connection { get; private set; }
        public static string CnnString;
        /// <summary>
        /// Initialize connections.
        /// This connections we want to set up. 
        /// (called at program starts).
        /// </summary>
        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.SqlDb)
            {
                // TODO - St up the SQL Connection properly.
                SqlDbConnector sql = new SqlDbConnector();
                Connection = (IDataConnection)sql;
                CnnString = ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString;
            }
            else if (db == DatabaseType.SQLite)
            {
                // TODO - Create Access Connection
                SQLiteConnector sql = new SQLiteConnector();
                Connection = sql;
                //CnnString = ConfigurationManager.ConnectionStrings["SQLite"].ConnectionString;
                CnnString = "Data Source=" + Environment.CurrentDirectory + "\\LessonsSchedulerDB.db;";
            }
        }

        /// <summary>
        /// Get connection string to db
        /// </summary>
        /// <param name="name">db name</param>
        /// <returns>connection string</returns>
      /*  public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }*/
    }
}

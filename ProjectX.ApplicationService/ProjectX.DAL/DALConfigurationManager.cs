using DataBuddy;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.DAL
{
    public static class DALConfigurationManager
    {
        private static string sharedConnectionString = ConfigurationManager.AppSettings.Get("SharedConnectionString");
        private static IConnectionManager connectionManager;
        private static IDataManagerFactory sqlFactory;
        private static IDataManagerFactory sqlcacheFactory;

        static DALConfigurationManager()
        {
            connectionManager = new ProjectXSQLConnectionManager(new ProjectXSQLDataManagerFactory(new DefaultConnectionManager(sharedConnectionString)));
            sqlFactory = new ProjectXSQLDataManagerFactory(connectionManager);
            sqlcacheFactory = new ProjectXSQLDataManagerFactory(connectionManager);
        }

        public static DataManager GetSQLDataManager()
        {
            return sqlFactory.GetDataManager();
        }

        public static DataManager GetSQLCacheDataManager()
        {
            return sqlcacheFactory.GetDataManager();
        }
    }
}

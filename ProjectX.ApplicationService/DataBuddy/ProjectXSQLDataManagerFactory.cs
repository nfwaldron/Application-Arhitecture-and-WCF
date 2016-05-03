using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBuddy
{
    public class ProjectXSQLDataManagerFactory : IDataManagerFactory
    {
        private IConnectionManager _connectionManager;

        public ProjectXSQLDataManagerFactory(IConnectionManager connectionManager)
        {
            _connectionManager = connectionManager;
        }

        public DataManager GetDataManager()
        {
            return new ProjectXSQLDataManager(_connectionManager);
        }

    }
}


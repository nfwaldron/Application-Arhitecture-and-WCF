using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBuddy
{
    public class ProjectXSQLConnectionManager : IConnectionManager
    {
        private static Dictionary<string, string> connectionStringsDictionary;
        private IDataManagerFactory _factory;

        static ProjectXSQLConnectionManager()
        {
            connectionStringsDictionary = new Dictionary<string, string>();
        }

        public ProjectXSQLConnectionManager(IDataManagerFactory factory)
        {
            _factory = factory;
        }

        public string GetConnectionByCommandName(string commandName)
        {
            if (connectionStringsDictionary.ContainsKey(commandName))
                return connectionStringsDictionary[commandName];

            string ConnString;
            using (var dataManager = _factory.GetDataManager())
            {
                dataManager.CommandName = "usp_GetConnString";
                dataManager.Parameters.AddWithValue("@ProcName", commandName);

                dataManager.Connection.Open();
                ConnString = dataManager.ExecuteScalar<string>();
                dataManager.Connection.Close();
            }

            object lockobj = new object();
            lock (lockobj)
            {
                connectionStringsDictionary.Add(commandName, ConnString);
            }

            return ConnString;
        }
    }
}

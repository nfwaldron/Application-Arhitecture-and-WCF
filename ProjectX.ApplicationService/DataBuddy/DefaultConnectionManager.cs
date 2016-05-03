using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBuddy
{
    public class DefaultConnectionManager : IConnectionManager
    {
        private string _connectionString;

        public DefaultConnectionManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        public string GetConnectionByCommandName(string commandName)
        {
            return _connectionString;
        }
    }
}

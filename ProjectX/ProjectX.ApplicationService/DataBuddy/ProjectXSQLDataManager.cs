using ProjectX.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBuddy
{
    public class ProjectXSQLDataManager : DataManager
    {
        #region "Local Variables"
        private ParameterCollection _parameters;
        private SqlConnection _connection;
        private IConnectionManager _connectionManager;
        private string _connectionString;
        #endregion

        #region "Properties"
        public override ParameterCollection Parameters
        {
            get
            {
                if (_parameters == null)
                    _parameters = new ParameterCollection();

                return _parameters;
            }
        }

        public override SqlConnection Connection
        {
            get
            {
                if (_connection == null)
                    _connection = GetSQLConnection();

                return _connection;
            }
        }

        public override string CommandName { get; set; }

        #endregion

        private ProjectXSQLDataManager()
        {

        }

        public ProjectXSQLDataManager(IConnectionManager connectionManager)
        {
            if (connectionManager == null)
                throw new InvalidOperationException("connectionManager cannot be null.");

            _connectionManager = connectionManager;
        }

        public ProjectXSQLDataManager(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new InvalidOperationException("connectionString cannot be null or empty.");

            _connectionString = connectionString;

        }

        /// <summary>
        /// Sends the SqlCommandText to the SqlConnection and builds a SqlDataReader.
        /// </summary>
        /// <returns></returns>
        public override SqlDataReader ExecuteReader()
        {

            //move CMD so we can dispose
            var SQLCmd = new SqlCommand();

            SQLCmd.Connection = Connection;
            SQLCmd.CommandText = CommandName;
            SQLCmd.CommandType = CommandType.StoredProcedure;
            SQLCmd.Parameters.AddRange(Parameters.ToArray());

            return SQLCmd.ExecuteReader();
        }

        /// <summary>
        /// Executes a Transact-SQL Statement against the connection and returns the number of rows affected.
        /// </summary>
        /// <returns></returns>
        public override int ExecuteNonQuery()
        {
            var SQLCmd = new SqlCommand();

            SQLCmd.Connection = Connection;
            SQLCmd.CommandText = CommandName;
            SQLCmd.CommandType = CommandType.StoredProcedure;
            SQLCmd.Parameters.AddRange(Parameters.ToArray());

            return SQLCmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Executes the query and returns the first column of the first row in the result set.  You must specify the expected data type with (T).
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public override T ExecuteScalar<T>()
        {

            var SQLCmd = new SqlCommand();

            SQLCmd.Connection = Connection;
            SQLCmd.CommandText = CommandName;
            SQLCmd.CommandType = CommandType.StoredProcedure;
            SQLCmd.Parameters.AddRange(Parameters.ToArray());

            return TypeConverter.ConvertValueType<T>(SQLCmd.ExecuteScalar());

        }

        private SqlConnection GetSQLConnection()
        {
            if (_connectionManager != null)
                return new SqlConnection(_connectionManager.GetConnectionByCommandName(CommandName));

            return new SqlConnection(_connectionString);
        }

        public override void Dispose()
        {
            _connection.Dispose();
        }
    }
}

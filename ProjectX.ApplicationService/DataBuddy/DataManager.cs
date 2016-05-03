using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBuddy
{
    public abstract class DataManager : IDisposable
    {
        abstract public string CommandName { get; set; }

        abstract public ParameterCollection Parameters { get; }

        abstract public SqlConnection Connection { get; }

        abstract public SqlDataReader ExecuteReader();

        abstract public int ExecuteNonQuery();

        abstract public T ExecuteScalar<T>();

        abstract public void Dispose();

    }
}

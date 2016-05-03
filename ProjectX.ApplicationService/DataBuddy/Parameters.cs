using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBuddy
{
   public class ParameterCollection : List<SqlParameter>
    {
        public void AddWithValue(string Name, object value)
        {
            this.Add(new SqlParameter(Name, value));
        }
    }
}



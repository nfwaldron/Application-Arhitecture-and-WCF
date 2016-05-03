using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.Utilities
{
    /// <summary>
    /// Provides a means to convert one Type to another Type
    /// </summary>
    public class TypeConverter
    {
        /// <summary>
        /// Converts the supplied value to the type of (T)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static T ConvertValueType<T>(object value)
        {

            var valueType = Nullable.GetUnderlyingType(typeof(T));

            if (value == null || value is System.DBNull)
            {
                return default(T);
            }

            if (valueType == null)
                return (T)Convert.ChangeType(value, typeof(T));

            var Result = Convert.ChangeType(value, valueType);

            return (T)Result;
        }

        public static T TryGetValue<T, O>(T ItemToSet, O value)
        {
            return ConvertValueType<T>(value);
        }

        public static T TryGetValue<T>(object value)
        {
            try
            {
                return ConvertValueType<T>(value);
            }
            catch
            {

            }
            return default(T);

        }
    }
}

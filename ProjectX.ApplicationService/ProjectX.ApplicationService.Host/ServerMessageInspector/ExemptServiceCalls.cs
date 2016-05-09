using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace ProjectX.ApplicationService.Host
{
    public class ExemptServiceCalls
    {
        public const string GetGender = "http://tempuri.org/IApplicationService/GetGender";

        public static List<string> GetExemptServices()
        {
            string serviceCall;
            var serviceList = new List<string>();
            Type type = typeof(ExemptServiceCalls); // Get Type Pointer
            FieldInfo[] fields = type.GetFields(); // Obtain all fields
            foreach (var field in fields)
            {
                object value = field.GetValue(null);
                serviceCall = (string)value;
                serviceList.Add(serviceCall);
            }
            return serviceList;
        }
    }
}
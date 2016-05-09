using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace ProjectX.ApplicationService.Host
{
    public static class ExemptServiceCalls
    {
        public const string GetLatestVersion = "http://tempuri.org/IApplicationService/GetLatestVersion";
        public const string GetOwners = "http://tempuri.org/IApplicationService/GetOwners";
        public const string GetNoteCategories = "http://tempuri.org/IApplicationService/GetNoteCategories";
        public const string GetFacility = "http://tempuri.org/IApplicationService/GetFacility";
        public const string GetServiceSubType = "http://tempuri.org/IApplicationService/GetServiceSubtype";
        public const string GetStaticAnswerGroups = "http://tempuri.org/IApplicationService/GetStaticAnswerGroups";
        public const string GetDiagnosis = "http://tempuri.org/IApplicationService/GetDiagnosis";
        public const string GetEpisodeStatus = "http://tempuri.org/IApplicationService/GetEpisodeStatus";
        public const string GetEpisodeType = "http://tempuri.org/IApplicationService/GetEpisodeType";
        public const string GetGender = "http://tempuri.org/IApplicationService/GetGender";
        public const string GetTaskPriority = "http://tempuri.org/IApplicationService/GetTaskPriority";
        public const string GetTaskStatus = "http://tempuri.org/IApplicationService/GetTaskStatus";
        public const string GetLcpSiteLocations = "http://tempuri.org/IApplicationService/GetLcpSiteLocations";
        public const string GetServiceType = "http://tempuri.org/IApplicationService/GetServiceType";
        public const string GetSnooze = "http://tempuri.org/IApplicationService/GetSnooze";

        public static List<string> GetExemptServices()
        {
            string serviceCall;
            var serviceList = new List<string>();
            Type type = typeof(ExemptServiceCalls); // Get Type Pointer
            FieldInfo[] fields = type.GetFields(); // Obtain all fields
            foreach (var field in fields)
            {
                object value = field.GetValue(null);
                serviceCall  = (string)value;
                serviceList.Add(serviceCall);
            }
            return serviceList;
        }
    }

}
using DataBuddy;
using ProjectX.Model;
using ProjectX.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.DAL
{
    public class Gender
    {
        public static List<IGender> GetGender()
        {
            var myList = new List<IGender>();
            var resultDT = new DataTable();
            using (DataManager MyDataManger = DALConfigurationManager.GetSQLCacheDataManager())
            {

                MyDataManger.CommandName = StoredProcs.GetGender.Name;
                MyDataManger.Connection.Open();
                resultDT.Load(MyDataManger.ExecuteReader());
                MyDataManger.Connection.Close();

                foreach (DataRow row in resultDT.Rows)
                {
                    var myItem = new Model.Gender();

                    myItem.GenderId = TypeConverter.TryGetValue(myItem.GenderId, row["GenderId"]);
                    myItem.GenderType = TypeConverter.TryGetValue(myItem.GenderType, row["Gender"]);
                    myItem.CreateById = TypeConverter.TryGetValue(myItem.CreateById, row["CreateById"]);
                    myItem.CreateDate = TypeConverter.TryGetValue(myItem.CreateDate, row["CreateDate"]);
                    myItem.ModifiedById = TypeConverter.TryGetValue(myItem.ModifiedById, row["ModifiedById"]);
                    myItem.ModifiedDate = TypeConverter.TryGetValue(myItem.ModifiedDate, row["ModifiedDate"]);
                    myList.Add(myItem);
                }
            }

            return myList;
        }
    }
}

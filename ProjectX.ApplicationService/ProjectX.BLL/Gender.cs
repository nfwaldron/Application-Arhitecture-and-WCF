using ProjectX.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.BLL
{
    public class Gender
    {
        public static List<IGender> GetGender()
        {
            return DAL.Gender.GetGender();
        }
    }
}

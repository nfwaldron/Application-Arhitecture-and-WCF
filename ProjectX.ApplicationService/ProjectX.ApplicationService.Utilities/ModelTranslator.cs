using ProjectX.ApplicationService.Contracts.Gender;
using ProjectX.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.ApplicationService.Utilities
{
    public class ModelTranslator
    {
        public static GenderDataContract Translate(IGender source)
        {
            var result = new GenderDataContract
            {
                CreateById = source.CreateById,
                CreateDate = source.CreateDate,
                GenderId = source.GenderId,
                GenderType = source.GenderType,
                ModifiedById = source.ModifiedById,
                ModifiedDate = source.ModifiedDate
            };

            return result;

        }

        public static List<GenderDataContract> Translate(List<IGender> source)
        {
            var result = new List<GenderDataContract>();

            foreach (var item in source)
            {
                result.Add(Translate(item));
            }
            return result;
        }
    }
}

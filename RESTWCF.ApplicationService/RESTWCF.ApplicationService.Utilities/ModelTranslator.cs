using RESTWCF.ApplicationService.Contracts.Product;
using RESTWCF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTWCF.ApplicationService.Utilities
{
    public class ModelTranslator
    {
        public static ProductDataContract Translate(IProduct source)
        {
            var result = new ProductDataContract
            {
                CategoryName = source.CategoryName,
                Name = source.Name,
                Price = source.Price,
                ProductId = source.ProductId
            };

            return result;
        }

        public static List<ProductDataContract> Translate(List<IProduct> source)
        {
            var result = new List<ProductDataContract>();
            foreach (var item in source)
            {
                result.Add(Translate(item));
            }

            return result;
        }
    }
}

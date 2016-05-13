using RESTWCF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTWCF.BLL
{
    public class Product
    {
        public static List<IProduct> GetProductList()
        {
            return DAL.Product.Instance.ProductList;
        }
    }
}

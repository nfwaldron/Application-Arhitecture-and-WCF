using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTWCF.Model
{
    public class Product : IProduct
    {
        public string CategoryName { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }
        public int Price { get; set; }
    }
}

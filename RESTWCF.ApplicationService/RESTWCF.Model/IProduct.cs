using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTWCF.Model
{
    public interface IProduct
    {
        int ProductId { get; set; }
        string Name { get; set; }
        string CategoryName { get; set; }
        int Price { get; set; }
    }
}

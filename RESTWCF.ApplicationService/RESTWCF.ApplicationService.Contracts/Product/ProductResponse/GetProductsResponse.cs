using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RESTWCF.ApplicationService.Contracts.Product.ProductResponse
{
    [DataContract]
    public class GetProductsResponse : BaseResponse
    {
        [DataMember]
        public List<ProductDataContract> Products { get; set; }
    }
}

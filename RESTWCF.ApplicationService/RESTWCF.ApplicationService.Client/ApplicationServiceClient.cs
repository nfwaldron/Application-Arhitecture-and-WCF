using RESTWCF.ApplicationService.Contracts;
using RESTWCF.ApplicationService.Contracts.Ping;
using RESTWCF.ApplicationService.Contracts.Product.ProductRequest;
using RESTWCF.ApplicationService.Contracts.Product.ProductResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace RESTWCF.ApplicationService.Client
{
    public class ApplicationServiceClient : ClientBase<IApplicationService>, IApplicationService
    {
       public PingResponse Ping (PingRequest request)
        {
            return Channel.Ping(request);
        }

        public GetProductsResponse GetProducts(GetProductsRequest request)
        {
            return Channel.GetProducts(request);
        }

    }
}

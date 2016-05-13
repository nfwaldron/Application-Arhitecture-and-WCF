using RESTWCF.ApplicationService.Contracts.Ping;
using RESTWCF.ApplicationService.Contracts.Product.ProductRequest;
using RESTWCF.ApplicationService.Contracts.Product.ProductResponse;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace RESTWCF.ApplicationService.Contracts
{
    [ServiceContract]
    public interface IApplicationService
    {
        [OperationContract]
        PingResponse Ping (PingRequest request);

        [OperationContract]
        GetProductsResponse GetProducts(GetProductsRequest request);
    }
}

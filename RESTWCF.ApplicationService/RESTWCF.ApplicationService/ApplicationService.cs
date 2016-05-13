using RESTWCF.ApplicationService.Contracts;
using RESTWCF.ApplicationService.Contracts.Ping;
using RESTWCF.ApplicationService.Contracts.Product.ProductRequest;
using RESTWCF.ApplicationService.Contracts.Product.ProductResponse;
using RESTWCF.ApplicationService.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTWCF.ApplicationService
{
    public class ApplicationService : IApplicationService
    {
        public PingResponse Ping(PingRequest request)
        {
            var response = new PingResponse();

            try
            {
                response.Message = "Ping Successful at: " + DateTime.Now;
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessage = ex.ToString();
            }

            return response;
        }

        public GetProductsResponse GetProducts(GetProductsRequest request)
        {
            var response = new GetProductsResponse();

            try
            {
                response.Products = ModelTranslator.Translate(BLL.Product.GetProductList());
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessage = ex.ToString();
            }

            return response;
        }

    }
}

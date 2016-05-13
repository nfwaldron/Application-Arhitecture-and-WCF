using ProjectY.ApplicationService.Contracts;
using ProjectY.ApplicationService.Contracts.Ping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectY.ApplicationService
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
    }
}

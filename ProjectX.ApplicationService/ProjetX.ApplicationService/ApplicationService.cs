using ProjectX.ApplicationService.Contracts;
using ProjectX.ApplicationService.Contracts.Ping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.ApplicationService
{
    /// <summary>
    /// Created By: Nathan Waldron
    /// Create Date: 04/11/2016
    /// The ApplicationService class implements the IApplication service, and defines the operations declared in the interface
    /// </summary>
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

using ProjectY.ApplicationService.Contracts;
using ProjectY.ApplicationService.Contracts.Ping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ProjectY.ApplicationServiceClient
{
    public class ApplicationServiceClient : ClientBase<IApplicationService>, IApplicationService
    {
        public PingResponse Ping(PingRequest request)
        {
            return Channel.Ping(request);
        }
    }
}

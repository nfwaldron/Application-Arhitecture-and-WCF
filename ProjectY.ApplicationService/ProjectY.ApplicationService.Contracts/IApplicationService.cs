using ProjectY.ApplicationService.Contracts.Ping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ProjectY.ApplicationService.Contracts
{
    [ServiceContract]
    public interface IApplicationService
    {
        [OperationContract]
        PingResponse Ping(PingRequest request);
    }
}

using ProjectX.ApplicationService.Contracts;
using ProjectX.ApplicationService.Contracts.Gender.Request;
using ProjectX.ApplicationService.Contracts.Gender.Response;
using ProjectX.ApplicationService.Contracts.Ping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.ApplicationServiceClient
{
    /// <summary>
    /// Created By: Nathan Waldron
    /// Create Date: 04/11/2016
    /// The ApplicationServiceClient class implements the ClientBase<T Channel> Class, 
    /// which Provides the base implementation used to create Windows Communication Foundation (WCF) client objects that can call services.
    /// ApplicationServiceClient also implements the IApplicationService interface, which ensures that all of the Operations that are available in the 
    /// Application Service can be called by the Application Client
    /// </summary>
    public class ApplicationServiceClient : ClientBase<IApplicationService>, IApplicationService
    {
        public PingResponse Ping(PingRequest request)
        {
            return Channel.Ping(request);
        }

        public GetGenderResponse GetGender(GetGenderRequest request)
        {
            return Channel.GetGender(request);
        }

    }
}

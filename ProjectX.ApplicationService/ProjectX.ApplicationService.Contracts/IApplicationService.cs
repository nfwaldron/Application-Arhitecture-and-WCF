using ProjectX.ApplicationService.Contracts.Gender.Request;
using ProjectX.ApplicationService.Contracts.Gender.Response;
using ProjectX.ApplicationService.Contracts.Ping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// It is contracts that that client and service agree as to the type of operation and structure they will use during communication. 
/// It is a formal agreement between a client and service to define a platform-neutral and standard way of describing what the service does.
/// Service contract describes the operations, or methods, that are available on the service endpoint, and exposed to the outside world. 
/// A Service contract describes the client-callable operations (functions) exposed by the service, apart from that it also describes.
/// To create a service contract you define an interface with related methods representative of a collection of service operations, 
/// and then decorate the interface/class with the ServiceContract Attribute to indicate it is a service contract. 
/// Methods in the interface that should be included in the service contract are decorated with the OperationContract Attribute.      
/// </summary>


namespace ProjectX.ApplicationService.Contracts
{
    [ServiceContract]
    public interface IApplicationService
    {
        [OperationContract]
        PingResponse Ping(PingRequest request);

        [OperationContract]
        GetGenderResponse GetGender(GetGenderRequest request);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.ApplicationService.Contracts.Ping
{
    // A data contract is a formal agreement between a service and a client 
    // that abstractly describes the data to be exchanged. That is, to communicate, the client 
    // and the service do not have to share the same types, only the same data contracts. 
    // A data contract precisely defines, for each parameter or return type, what data is serialized(turned into XML) to be exchanged.
    // Windows Communication Foundation (WCF) uses a serialization engine called the Data Contract Serializer by default to serialize
    // and deserialize data (convert it to and from XML). 

    [DataContract]
    public class PingResponse : BaseResponse
    {
        // [DataMember] When applied to the member of a type, specifies that the member is part of a data contract and is serializable by the DataContractSerializer.
        [DataMember]
        public string Message { get; set; }
    }
}

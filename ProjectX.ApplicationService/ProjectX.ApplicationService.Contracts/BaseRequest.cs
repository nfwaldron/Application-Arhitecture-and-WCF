﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.ApplicationService.Contracts
{
    // A data contract is a formal agreement between a service and a client 
    // that abstractly describes the data to be exchanged. That is, to communicate, the client 
    // and the service do not have to share the same types, only the same data contracts. 
    // A data contract precisely defines, for each parameter or return type, what data is serialized(turned into XML) to be exchanged.
    // Windows Communication Foundation (WCF) uses a serialization engine called the Data Contract Serializer by default to serialize
    // and deserialize data (convert it to and from XML). 

    [DataContract]
    public abstract class BaseRequest
    {
        [DataMember]
        public string UserToken { get; set; }
    }
}

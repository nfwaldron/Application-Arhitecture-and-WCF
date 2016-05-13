using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProjectY.ApplicationService.Contracts
{
    [DataContract]
    public abstract class BaseResponse
    {
        // [DataMember] When applied to the member of a type, specifies that the member is part of a data contract and is serializable by the DataContractSerializer.
        [DataMember]
        public string ErrorMessage { get; set; }
        [DataMember]
        public bool Success { get; set; }
        
    }
}

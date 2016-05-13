using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RESTWCF.ApplicationService.Contracts
{
    [DataContract]
    public abstract class BaseResponse
    {
        [DataMember]
        public string ErrorMessage { get; set; }

        [DataMember]
        public bool Success { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RESTWCF.ApplicationService.Contracts
{
    [DataContract]
    public abstract class BaseRequest
    {
        [DataMember]
        public string UserToken { get; set; }

    }
}

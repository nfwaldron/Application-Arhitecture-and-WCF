using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RESTWCF.ApplicationService.Contracts.Ping
{
    [DataContract]
    public class PingResponse : BaseResponse
    {
        [DataMember]
        public string Message { get; set; }
    }
}

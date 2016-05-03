using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.ApplicationService.Contracts
{
    [DataContract]
    public enum ErrorCodes
    {
        [EnumMember]
        None,

        [EnumMember]
        Invalid
    }
}

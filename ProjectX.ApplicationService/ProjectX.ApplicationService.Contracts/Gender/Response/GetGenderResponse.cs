using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.ApplicationService.Contracts.Gender.Response
{
    [DataContract]
    public class GetGenderResponse : BaseResponse
    {
        [DataMember]
        public List<GenderDataContract> GenderList { get; set; }
    }
}

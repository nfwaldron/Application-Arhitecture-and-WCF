using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.ApplicationService.Contracts.Gender
{
    [DataContract]
    public class GenderDataContract
    {
        [DataMember]
        public int GenderId { get; set; }
        [DataMember]
        public string GenderType { get; set; }
        [DataMember]
        public int CreateById { get; set; }
        [DataMember]
        public DateTime CreateDate { get; set; }
        [DataMember]
        public int ModifiedById { get; set; }
        [DataMember]
        public DateTime ModifiedDate { get; set; }
    }
}

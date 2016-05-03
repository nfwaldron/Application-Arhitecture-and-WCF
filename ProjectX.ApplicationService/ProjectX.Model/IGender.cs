using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.Model
{
    public interface IGender
    {
        int GenderId { get; set; }
        string GenderType { get; set; }
        int CreateById { get; set; }
        DateTime CreateDate { get; set; }
        int ModifiedById { get; set; }
        DateTime ModifiedDate { get; set; }
    }
}

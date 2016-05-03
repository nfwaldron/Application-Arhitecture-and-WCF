using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.Model
{
    public class Gender : IGender
    {
        public int GenderId { get; set; }
        public string GenderType { get; set; }
        public int CreateById { get; set; }
        public DateTime CreateDate { get; set; }
        public int ModifiedById { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}

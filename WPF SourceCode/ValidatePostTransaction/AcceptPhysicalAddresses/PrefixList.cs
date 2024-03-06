using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcceptPhysicalAddresses
{
    public class PrefixList : List<String>
    {
        public PrefixList()
        {
            this.Add("Open");
            this.Add("Closed");
        }
    }
}

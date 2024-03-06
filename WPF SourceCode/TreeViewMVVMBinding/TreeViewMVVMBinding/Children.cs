using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewMVVMBinding
{
    public class Children : ViewModelBase
    {
      
        public Children(string childrenname)
        {
            ChildrenName = childrenname;
         
        }        

        public string ChildrenName
        {
            get;
            set;
        }
    }
}

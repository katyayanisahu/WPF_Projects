using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLB
{
    public class ListItemsModel
    {
        public ListItemsViewModel MyViewModel { get; set; }
        public ListItemsModel()
        {
            MyViewModel = new ListItemsViewModel();

        }
    }
}

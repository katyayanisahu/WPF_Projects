using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AddNonMapped
{
    public class AddNonMappedParcelViewModel
    {
        public ObservableCollection<string> listsNonMappedParcels { get; set; }
        public AddNonMappedParcelViewModel()
        {

            listsNonMappedParcels = new ObservableCollection<string>() { "Condo","Leaseholds", "Townhomes", "Mobile homes", "Street malls"};
        }
    }
}

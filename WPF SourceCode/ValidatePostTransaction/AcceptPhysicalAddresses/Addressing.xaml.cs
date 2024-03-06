using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AcceptPhysicalAddresses
{  
    /// <summary>
    /// Interaction logic for Addressing.xaml
    /// </summary>
    public partial class Addressing : ArcGIS.Desktop.Framework.Controls.ProWindow
    {
        public Addressing()
        {
            InitializeComponent();
            this.DataContext = new PhysicalAddressViewModel();
        }     
    }
}

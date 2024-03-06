using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AcceptPhysicalAddresses
{
   
    /// <summary>
    /// Interaction logic for Addressing.xaml
    /// </summary>
    public partial class Addressing : ArcGIS.Desktop.Framework.Controls.ProWindow
    {
        //public ObservableCollection<WidgetModel> Widgets { get; init; }

        public Addressing()
        {
            InitializeComponent();

      
            List<PhysicalAddress> users = new List<PhysicalAddress>();
            users.Add(new PhysicalAddress() { ParcelPk = 23165, NoAddr = true, StreetNumber = 0, Msc = " ", Building = " ", Unit = 0, Prefix = "Open" });
            users.Add(new PhysicalAddress() { ParcelPk = 23166, NoAddr = true, StreetNumber = 0, Msc = " ", Building = " ", Unit = 0, Prefix = "Close" });


            dgSimple2.ItemsSource = users;
        }
      
    }
}

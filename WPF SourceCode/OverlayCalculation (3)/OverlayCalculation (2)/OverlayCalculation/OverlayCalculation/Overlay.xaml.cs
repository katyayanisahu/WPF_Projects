using OverlayCalculation.ViewModel;
using System.Windows.Controls;

namespace OverlayCalculation
{
    /// <summary>
    /// Interaction logic for Overlay.xaml
    /// </summary>
    public partial class Overlay : ArcGIS.Desktop.Framework.Controls.ProWindow
    {      

        public Overlay()
        {
            InitializeComponent();
            this.DataContext = new OverlayViewModel(stkpnlDynamicControls2);
        }
    }
}

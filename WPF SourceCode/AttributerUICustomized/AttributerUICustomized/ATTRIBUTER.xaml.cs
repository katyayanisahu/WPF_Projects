using AttributerUI.ViewModel;
using System.Windows.Controls;

namespace AttributerUICustomized
{
    /// <summary>
    /// Interaction logic for ATTRIBUTER.xaml
    /// </summary>
    public partial class ATTRIBUTER : ArcGIS.Desktop.Framework.Controls.ProWindow
    {
        private StackPanel stkpnlDynamicControls2;

        public ATTRIBUTER()
        {
            InitializeComponent();
            this.DataContext = new AttributeViewModel(stkpnlDynamicControls);
        }
       
    }
}

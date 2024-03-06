using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AttributerUI.Model;
using AttributerUI.ViewModel;

namespace AttributerUI
{
    /// <summary>
    /// Interaction logic for Attributer.xaml
    /// </summary>
    public partial class Attributer : ArcGIS.Desktop.Framework.Controls.ProWindow
    {
        public Attributer()
        {
            InitializeComponent();
            this.DataContext = new LoadTransactionViewModel(stkpnlDynamicControls2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using static ArcGIS.Desktop.Internal.Core.PortalTrafficDataService.PortalDescriptionResponse;

namespace ValidatePostTransaction
{
    /// <summary>
    /// Interaction logic for Validate_Post.xaml
    /// </summary>
    public partial class Validate_Post : ArcGIS.Desktop.Framework.Controls.ProWindow
    {       
        public Validate_Post()
        {           
            InitializeComponent();         
            this.DataContext = new ValidatePostViewModel(stkpnlDynamicControls2);
          
        }
    }
}

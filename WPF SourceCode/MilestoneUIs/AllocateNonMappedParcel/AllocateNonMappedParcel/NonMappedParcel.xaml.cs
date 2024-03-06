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

namespace AllocateNonMappedParcel
{
    /// <summary>
    /// Interaction logic for NonMappedParcel.xaml
    /// </summary>
    public partial class NonMappedParcel : ArcGIS.Desktop.Framework.Controls.ProWindow
    {
        //public ObservableCollection<string> Names { get; set; }
        public NonMappedParcel()
        {
            //Names = new ObservableCollection<string>() { "5986191531010", "5986191531020" };
            InitializeComponent();
            DataContext = new NonMappedViewModel();
        }
       
       
    }
}

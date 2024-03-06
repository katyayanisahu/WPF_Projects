using Intersoft.Crosslight;

namespace DemoLB
{
    /// <summary>
    /// Interaction logic for ListItems.xaml
    /// </summary>
    /// 
  
    public partial class ListItems : ArcGIS.Desktop.Framework.Controls.ProWindow
    {
        //public ObservableCollection<string> Names { get; set; }
        public ListItems()
        {
      
              InitializeComponent();
              this.DataContext = new ListItemsViewModel();
        }
    }
}

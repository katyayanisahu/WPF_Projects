using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows.Controls;
using System.Windows.Input;

namespace ValidatePostTransaction
{
    public class ValidatePostViewModel : BindableBase
    {
        public ObservableCollection<string> Names { get; set; }

        private ValidatePostModel insertUpdate;
        public ObservableCollection<InsertUpdate> InsertUpdates { get; set; }
        public ObservableCollection<DeleteUpdate> DeleteUpdates { get; set; }
        public ICommand AddCommand { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="stkpnlDynamicControls2"></param>
        public ValidatePostViewModel(StackPanel stkpnlDynamicControls2)
        {
            this.Names = new ObservableCollection<string>() { "PARCEL_LINES", "ADDRESSPOINT", "TOWNSHIPS", "TAX_DISTRICTS", "FLOOD_MAPS", "COMBINED_ZONING", "SOILS", "PARCELS", "NON_MAPPED_PARCELS" };         
            insertUpdate = new ValidatePostModel();
            InsertUpdates = new ObservableCollection<InsertUpdate>(insertUpdate.GetPeople());
            DeleteUpdates = new ObservableCollection<DeleteUpdate>(insertUpdate.GetPeople1());

        }


        public ValidatePostModel TestModel
        {
            get { return insertUpdate; }
            set { SetProperty(ref insertUpdate, value); }
        }

        public DataTable DataTable { get; }
    }
}

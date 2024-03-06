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
        public ObservableCollection<string> Names { get; set; }
        public Validate_Post()
        {
            Names = new ObservableCollection<string>() { "PARCEL_LINES", "ADDRESSPOINT", "TOWNSHIPS", "TAX_DISTRICTS","FLOOD_MAPS","COMBINED_ZONING","SOILS","PARCELS","NON_MAPPED_PARCELS" };
            InitializeComponent();
            DataContext = this;

            List<InsertUpdate> users = new List<InsertUpdate>();
            users.Add(new InsertUpdate() {   OID = 216189, FEATURE_KEY = 206678, UPDATE_INSERT = "INSERT", ERROR_MESSAGE = " " });
            users.Add(new InsertUpdate() {   OID = 216190, FEATURE_KEY = 206679, UPDATE_INSERT = "INSERT", ERROR_MESSAGE = " " });


            dgSimple.ItemsSource = users;

            List<DeleteUpdate> users2 = new List<DeleteUpdate>();
            users2.Add(new DeleteUpdate() { OID = 10446, FEATURE_KEY = 10446, UPDATE_DELETE = "DELETE", ERROR_MESSAGE = " " });

            dgSimple2.ItemsSource = users2;


        }
    }
}

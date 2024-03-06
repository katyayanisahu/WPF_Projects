using ArcGIS.Desktop.Framework;
using ArcGIS.Desktop.Framework.Contracts;

namespace AcceptPhysicalAddresses
{
    internal class ShowAddressing : Button
    {

        private Addressing _addressing = null;

        protected override void OnClick()
        {
            //already open?
            if (_addressing != null)
                return;
            _addressing = new Addressing();
            _addressing.Owner = FrameworkApplication.Current.MainWindow;
            _addressing.Closed += (o, e) => { _addressing = null; };
            _addressing.Show();
            //uncomment for modal
            //_addressing.ShowDialog();
        }

    }
}

using ArcGIS.Desktop.Framework;
using ArcGIS.Desktop.Framework.Contracts;

namespace OverlayCalculation
{
    internal class ShowOverlay : Button
    {

        private Overlay _overlay = null;

        protected override void OnClick()
        {
            //already open?
            if (_overlay != null)
                return;
            _overlay = new Overlay();
            _overlay.Owner = FrameworkApplication.Current.MainWindow;
            _overlay.Closed += (o, e) => { _overlay = null; };
            _overlay.Show();
            //uncomment for modal
            //_overlay.ShowDialog();
        }

    }
}


using ArcGIS.Desktop.Framework;
using ArcGIS.Desktop.Framework.Contracts;


namespace MatchingAddressess
{
    internal class ShowMatching : Button
    {

        private Matching _matching = null;

        protected override void OnClick()
        {
            //already open?
            if (_matching != null)
                return;
            _matching = new Matching();
            _matching.Owner = FrameworkApplication.Current.MainWindow;
            _matching.Closed += (o, e) => { _matching = null; };
            _matching.Show();
            //uncomment for modal
            //_matching.ShowDialog();
        }

    }
}

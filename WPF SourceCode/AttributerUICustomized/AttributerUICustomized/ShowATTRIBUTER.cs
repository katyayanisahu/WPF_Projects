using ArcGIS.Desktop.Framework;
using ArcGIS.Desktop.Framework.Contracts;

namespace AttributerUICustomized
{
    internal class ShowATTRIBUTER : Button
    {

        private ATTRIBUTER _attributer = null;

        protected override void OnClick()
        {
            //already open?
            if (_attributer != null)
                return;
            _attributer = new ATTRIBUTER();
            _attributer.Owner = FrameworkApplication.Current.MainWindow;
            _attributer.Closed += (o, e) => { _attributer = null; };
            _attributer.Show();
            //uncomment for modal
            //_attributer.ShowDialog();
        }

    }
}

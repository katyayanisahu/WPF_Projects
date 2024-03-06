using ArcGIS.Desktop.Framework;
using ArcGIS.Desktop.Framework.Contracts;

namespace AllocateNonMappedParcel
{
    internal class ShowNonMappedParcel : Button
    {

        private NonMappedParcel _nonmappedparcel = null;

        protected override void OnClick()
        {
            //already open?
            if (_nonmappedparcel != null)
                return;
            _nonmappedparcel = new NonMappedParcel();
            _nonmappedparcel.Owner = FrameworkApplication.Current.MainWindow;
            _nonmappedparcel.Closed += (o, e) => { _nonmappedparcel = null; };
            _nonmappedparcel.Show();
            //uncomment for modal
            //_nonmappedparcel.ShowDialog();
        }

    }
}

using ArcGIS.Desktop.Framework;
using ArcGIS.Desktop.Framework.Contracts;

namespace ValidatePostTransaction
{
    internal class ShowValidate_Post : Button
    {

        private Validate_Post _validate_post = null;

        protected override void OnClick()
        {
            //already open?
            if (_validate_post != null)
                return;
            _validate_post = new Validate_Post();
            _validate_post.Owner = FrameworkApplication.Current.MainWindow;
            _validate_post.Closed += (o, e) => { _validate_post = null; };
            _validate_post.Show();
            //uncomment for modal
            //_validate_post.ShowDialog();
        }

    }
}

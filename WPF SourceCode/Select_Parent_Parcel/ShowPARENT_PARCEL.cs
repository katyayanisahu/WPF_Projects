using ArcGIS.Core.CIM;
using ArcGIS.Core.Data;
using ArcGIS.Core.Geometry;
using ArcGIS.Desktop.Catalog;
using ArcGIS.Desktop.Core;
using ArcGIS.Desktop.Editing;
using ArcGIS.Desktop.Extensions;
using ArcGIS.Desktop.Framework;
using ArcGIS.Desktop.Framework.Contracts;
using ArcGIS.Desktop.Framework.Dialogs;
using ArcGIS.Desktop.Framework.Threading.Tasks;
using ArcGIS.Desktop.Layouts;
using ArcGIS.Desktop.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select_Parent_Parcel
{
    internal class ShowPARENT_PARCEL : Button
    {

        private PARENT_PARCEL _parent_parcel = null;

        protected override void OnClick()
        {
            //already open?
            if (_parent_parcel != null)
                return;
            _parent_parcel = new PARENT_PARCEL();
            _parent_parcel.Owner = FrameworkApplication.Current.MainWindow;
            _parent_parcel.Closed += (o, e) => { _parent_parcel = null; };
            _parent_parcel.Show();
            //uncomment for modal
            //_parent_parcel.ShowDialog();
        }

    }
}

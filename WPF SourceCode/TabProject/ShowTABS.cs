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

namespace TabProject
{
    internal class ShowTABS : Button
    {

        private TABS _tabs = null;

        protected override void OnClick()
        {
            //already open?
            if (_tabs != null)
                return;
            _tabs = new TABS();
            _tabs.Owner = FrameworkApplication.Current.MainWindow;
            _tabs.Closed += (o, e) => { _tabs = null; };
            _tabs.Show();
            //uncomment for modal
            //_tabs.ShowDialog();
        }

    }
}

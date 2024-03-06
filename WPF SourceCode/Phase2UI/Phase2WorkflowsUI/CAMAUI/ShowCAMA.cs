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

namespace CAMAUI
{
    internal class ShowCAMA : Button
    {

        private CAMA _cama = null;

        protected override void OnClick()
        {
            //already open?
            if (_cama != null)
                return;
            _cama = new CAMA();
            _cama.Owner = FrameworkApplication.Current.MainWindow;
            _cama.Closed += (o, e) => { _cama = null; };
            _cama.Show();
            //uncomment for modal
            //_cama.ShowDialog();
        }

    }
}

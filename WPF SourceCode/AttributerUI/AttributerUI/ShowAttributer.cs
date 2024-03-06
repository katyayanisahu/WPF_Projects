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

namespace AttributerUI
{
    internal class ShowAttributer : Button
    {

        private Attributer _attributer = null;

        protected override void OnClick()
        {
            //already open?
            if (_attributer != null)
                return;
            _attributer = new Attributer();
            _attributer.Owner = FrameworkApplication.Current.MainWindow;
            _attributer.Closed += (o, e) => { _attributer = null; };
            _attributer.Show();
            //uncomment for modal
            //_attributer.ShowDialog();
        }

    }
}

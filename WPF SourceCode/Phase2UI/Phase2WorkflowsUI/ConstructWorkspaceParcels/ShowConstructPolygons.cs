﻿using ArcGIS.Core.CIM;
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

namespace ConstructWorkspaceParcels
{
    internal class ShowConstructPolygons : Button
    {

        private ConstructPolygons _constructpolygons = null;

        protected override void OnClick()
        {
            //already open?
            if (_constructpolygons != null)
                return;
            _constructpolygons = new ConstructPolygons();
            _constructpolygons.Owner = FrameworkApplication.Current.MainWindow;
            _constructpolygons.Closed += (o, e) => { _constructpolygons = null; };
            _constructpolygons.Show();
            //uncomment for modal
            //_constructpolygons.ShowDialog();
        }

    }
}

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

namespace TreeViewMVVMBinding
{
    internal class ShowTREEVIEW : Button
    {

        private TREEVIEW _treeview = null;

        protected override void OnClick()
        {
            //already open?
            if (_treeview != null)
                return;
            _treeview = new TREEVIEW();
            _treeview.Owner = FrameworkApplication.Current.MainWindow;
            _treeview.Closed += (o, e) => { _treeview = null; };
            _treeview.Show();
            //uncomment for modal
            //_treeview.ShowDialog();
        }

    }
}

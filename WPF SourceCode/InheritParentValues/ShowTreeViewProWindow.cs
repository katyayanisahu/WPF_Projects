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

namespace InheritParentValues
{
    internal class ShowTreeViewProWindow : Button
    {

        private TreeViewProWindow _treeviewprowindow = null;

        protected override void OnClick()
        {
            //already open?
            if (_treeviewprowindow != null)
                return;
            _treeviewprowindow = new TreeViewProWindow();
            _treeviewprowindow.Owner = FrameworkApplication.Current.MainWindow;
            _treeviewprowindow.Closed += (o, e) => { _treeviewprowindow = null; };
            _treeviewprowindow.Show();
            //uncomment for modal
            //_treeviewprowindow.ShowDialog();
        }

    }
}

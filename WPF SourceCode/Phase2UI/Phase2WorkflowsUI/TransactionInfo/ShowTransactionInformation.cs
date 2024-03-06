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

namespace TransactionInfo
{
    internal class ShowTransactionInformation : Button
    {

        private TransactionInformation _transactioninformation = null;

        protected override void OnClick()
        {
            //already open?
            if (_transactioninformation != null)
                return;
            _transactioninformation = new TransactionInformation();
            _transactioninformation.Owner = FrameworkApplication.Current.MainWindow;
            _transactioninformation.Closed += (o, e) => { _transactioninformation = null; };
            _transactioninformation.Show();
            //uncomment for modal
            //_transactioninformation.ShowDialog();
        }

    }
}

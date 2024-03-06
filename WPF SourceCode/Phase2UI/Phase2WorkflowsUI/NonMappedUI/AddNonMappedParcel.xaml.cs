﻿using NonMappedUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NonMappedUI
{
    /// <summary>
    /// Interaction logic for AddNonMappedParcel.xaml
    /// </summary>
    public partial class AddNonMappedParcel : ArcGIS.Desktop.Framework.Controls.ProWindow
    {
        public AddNonMappedParcel()
        {
            InitializeComponent();
            this.DataContext = new AddNonMappedParcelViewModel();
        }
    }
}

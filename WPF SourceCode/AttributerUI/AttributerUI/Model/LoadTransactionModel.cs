using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Haley.WPF;


namespace AttributerUI.Model
{
    class LoadTransactionModel : BindableBase
    {
        private StackPanel _stkPanel;
        public StackPanel stkPanel
        {
            get { return _stkPanel; }
            set { SetProperty(ref _stkPanel, value); }
        }
    }
}

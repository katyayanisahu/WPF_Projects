using Prism.Mvvm;
using System.Windows.Controls;

namespace AttributerUI.Model
{
    class AttributeModel : BindableBase
    {
        private StackPanel _stkPanel;
        public StackPanel stkPanel
        {
            get { return _stkPanel; }
            set { SetProperty(ref _stkPanel, value); }
        }

    }
}

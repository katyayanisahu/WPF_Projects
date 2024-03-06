using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewMVVMBinding
{
    public class MainWindowViewModel : ViewModelBase
    {
        private List<Parent> parents;

        public MainWindowViewModel()
        {
            Parents = new List<Parent>()
            {
                new Parent("(Parent) REID: 5986380441000, PIN: 5986380441"),
                new Parent("(Parent) REID: 5986380441001, PIN: 5986380442")
            };
        }

        public List<Parent> Parents
        {
            get
            {
                return parents;
            }
            set
            {
                parents = value;
                OnPropertyChanged("Parents");
            }
        }
    }
}

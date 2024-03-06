using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewMVVMBinding
{
    public class Parent : ViewModelBase
    {
        private List<Children> childrens;

        public Parent(string parname)
        {
            ParentName = parname;
            childrens = new List<Children>()
            {
                new Children("Owner = E R E V A N S & SONS INC"),
                new Children("Deed Book = 000456"),
                new Children("Deed Page = 00597"),
                new Children("Deed Date = 1/4/1989 12:01:00 AM"),
                new Children("Subdiv/Desc =  PORTER/BRIDGER"),
                
            };
        }
        public List<Children> Childrens
        {
            get
            {
                return childrens;
            }
            set
            {
                childrens = value;
                OnPropertyChanged("Childrens");
            }
        }
        public string ParentName
        {
            get;
            set;
        }
    }
}

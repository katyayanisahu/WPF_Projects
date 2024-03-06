
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicTreeViewWPF
{
    public class ViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;


        private ObservableCollection<CheckableItem> miscellaneousImports;
        public ObservableCollection<CheckableItem> MiscellaneousImports
        {
            get { return miscellaneousImports; }
            set
            {
                miscellaneousImports = value;
                OnPropertyChanged("MiscellaneousImports");
            }
        }
        public ViewModel()
        {
            LoadCheckableItems();
        }

        private void LoadCheckableItems()
        {
            miscellaneousImports = new ObservableCollection<CheckableItem>();
           miscellaneousImports.Add(new CheckableItem()
           {
               Name = "Miscellaneous Imports"
            });

            //miscellaneousImports.Children = new ObservableCollection<CheckableItem>();
            //miscellaneousImports.Children.Add(new CheckableItem()
            //{
            //    Name = "GPO Import"

            //});

            //miscellaneousImports = new CheckableItem()
            //{
            //    Name = "Miscellaneous Imports1"
            //};

            //miscellaneousImports.Children.Add(new CheckableItem()
            //{
            //    Name = "GPO Import1"

            //});
        }
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }

}

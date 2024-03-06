using ArcGIS.Core.Internal.CIM;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DemoLB
{
    public  class ListItemsViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<Names> _namesCollection = new ObservableCollection<Names>();
        public ObservableCollection<Names> NamesCollection //Binds with the listbox
        {
            get { return _namesCollection; }
            set { _namesCollection = value; RaisePropertyChanged("NamesCollection"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public ListItemsViewModel()
        {
            _namesCollection = new ObservableCollection<Names>()
        {
            new Names() { REID = 545989039, PIN = 0370903525 },
            new Names() { REID = 545989039, PIN = 0370903525 }

       };
        }


        //private ObservableCollection<string> Names { get; set; }

        // //private ObservableCollection<Names> NamesCollection { get; set; }      
        // public ListItemsViewModel()
        // {
        //     //this.NamesCollection = new ObservableCollection<Names>();
        //     //SelectFilesAction();
        //     this.Names = new ObservableCollection<string>() { "REID: 545987984, PIN:0370098" };

        // }

        //private void SelectFilesAction()
        //{
        //    NamesCollection.Add(new Names { REID = 545989039, PIN = 0370903525 });
        //}

    }
}

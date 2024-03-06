using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TabProject
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        static int tabs = 1;

        public MainWindowViewModel()
        {
            Titles = new ObservableCollection<Item>();
        }

        public ObservableCollection<Item> Titles
        {
            get { return _titles; }
            set
            {
                _titles = value;
                OnPropertyChanged("Titles");
            }
        }

        public class Item
        {
            public string Header { get; set; }
            public string Content { get; set; }
        }

        private ICommand _addTab;
        private ICommand _removeTab;
        private ObservableCollection<Item> _titles;

        public ICommand AddTab
        {
            get
            {
                return _addTab ?? (_addTab = new RelayCommand(
                   x =>
                   {
                       AddTabItem();
                   }));
            }
        }

        public ICommand RemoveTab
        {
            get
            {
                return _removeTab ?? (_removeTab = new RelayCommand(
                   x =>
                   {
                       RemoveTabItem();
                   }));
            }
        }

        private void RemoveTabItem()
        {
            Titles.Remove(Titles.Last());
            tabs--;
        }

        private void AddTabItem()
        {
            var header = "Tab " + tabs;
            var content = "Content " + tabs;
            var item = new Item { Header = header, Content = content };

            Titles.Add(item);
            tabs++;
            OnPropertyChanged("Titles");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            VerifyPropertyName(propertyName);
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        [Conditional("DEBUG")]
        private void VerifyPropertyName(string propertyName)
        {
            if (TypeDescriptor.GetProperties(this)[propertyName] == null)
                throw new ArgumentNullException(GetType().Name + " does not contain property: " + propertyName);
        }
    }
}

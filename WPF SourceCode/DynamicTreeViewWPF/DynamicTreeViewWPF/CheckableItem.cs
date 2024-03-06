using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DynamicTreeViewWPF
{
    public class CheckableItem
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public ObservableCollection<CheckableItem> Children { get; set; }
        private Visibility _isChecked;
        public Visibility IsChecked
        {
            get { return _isChecked; }
            set
            {
                _isChecked = value;
                OnPropertyChanged("IsChecked");
                CheckChildren(value);
            }
        }
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private void CheckChildren(Visibility parentIsChecked)
        {
            foreach (CheckableItem child in Children)
            {
                child.IsChecked = parentIsChecked;
            }
        }
    }
  }

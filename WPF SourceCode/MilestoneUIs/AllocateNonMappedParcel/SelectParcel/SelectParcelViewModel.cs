using System.Collections.ObjectModel;

namespace SelectParcel
{
    public class SelectParcelViewModel
    {
        private ObservableCollection<string> Names1 { get; set; }


        public SelectParcelViewModel()
        {

            Names1 = new ObservableCollection<string>() { "REID: 545987984, PIN:0370098" };

        }
    }
}

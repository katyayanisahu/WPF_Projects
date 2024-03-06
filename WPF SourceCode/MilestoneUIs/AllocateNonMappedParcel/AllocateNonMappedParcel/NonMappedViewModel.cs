using System.Collections.ObjectModel;

namespace AllocateNonMappedParcel
{
    public class NonMappedViewModel
    {
        public ObservableCollection<Model> Names { get; set; }

        public NonMappedViewModel() {
            this.Names = new ObservableCollection<Model>();
            Names.Add(new Model { REID = 545989039 });
            Names.Add(new Model { REID = 545989040 });
        }

    }
}

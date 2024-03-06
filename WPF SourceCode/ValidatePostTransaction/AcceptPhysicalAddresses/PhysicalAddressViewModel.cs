using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AcceptPhysicalAddresses
{
    public class PhysicalAddressViewModel
    {
        public ObservableCollection<string> Names1 { get; set; }
        public ObservableCollection<string> Names2 { get; set; }
        public ObservableCollection<string> Names3 { get; set; }
        public ObservableCollection<PhysicalAddress> Names4 { get; set; }
        public ObservableCollection<string> Names5 { get; set; }
        public ObservableCollection<string> Names6 { get; set; }
        public PhysicalAddressViewModel()
        {

            Names1 = new ObservableCollection<string>() { "23165[REID:872535, PIN:87985] Address Count 1" };         
            Names2 = new ObservableCollection<string>() { "0 OFF END OF SR 1172 MURFREESBORO 27855" };

            //List<PhysicalAddress> users = new List<PhysicalAddress>();
            List<string> users1 = new List<string>();
            users1.Add("Open");
            users1.Add("Close");
            users1.Add("Cancel");

            this.Names4 = new ObservableCollection<PhysicalAddress>();
            Names4.Add(new PhysicalAddress { ParcelPk = 23165, NoAddr = true, StreetNumber = 0, Msc = " ", Building = " ", Unit = 0 ,Prefix= users1, StreetName="NO ADDRESS", StreetType= " ", Suffix=" ", 
            AddressType=" ", City=" ", CrLot=" ", PJ= " ", Primary=" ", Status=" ", Unique=" " });

            this.Names4.Add(new PhysicalAddress { ParcelPk = 23166, NoAddr = true, StreetNumber = 0, Msc = " ", Building = " ", Unit = 0, Prefix = users1, StreetName="NO ADDRESS", StreetType= " ", Suffix=" ", 
            AddressType=" ", City=" ", CrLot=" ", PJ= " ", Primary=" ", Status=" ", Unique=" "});

            //this.Names3 = new ObservableCollection<string>();
            //Names3.Add(new string{ "Open", "Close" });

            Names5 = new ObservableCollection<string>() { "Copy Selected", "Copy Selected to All Other Parcels"};
            Names6 = new ObservableCollection<string>() { "New Address", "No Address", "No Address to All Parcels", "From Parent/Container" };

        }
    }
}

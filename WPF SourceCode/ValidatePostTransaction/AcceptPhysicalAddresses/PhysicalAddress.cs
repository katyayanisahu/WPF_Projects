using System.Collections.Generic;

namespace AcceptPhysicalAddresses
{
    public class PhysicalAddress
    {
        public int ParcelPk { get; set; }
        public bool NoAddr { get; set; }
        public int StreetNumber { get; set; }
        public string Msc { get; set; }
        public string Building { get; set; }
        public int Unit { get; set; }
        public List<string> Prefix { get; set; } 

        //private int _prefix;
        //public string Prefix {

        //    get { return _prefix; }
        //    set { _prefix = value; }
        //}
        public string StreetName{ get; set; }
        public string StreetType { get; set; }
        public string Suffix { get; set; }
        public string AddressType { get; set; }
        public string Primary { get; set; }
        public string CrLot{ get; set; }
        public string PJ { get; set; }
        public string Unique { get; set; }
        public string Status { get; set; }
        public string City { get; set; }

    }
    //public class PrefixList : List<String>
    //{
    //    public PrefixList() {
    //        this.Add("Open");
    //        this.Add("Closed");
    //    }
    //}

    //public enum PrefixStatus{ None, New, Processing, Shipped, Received };
} 

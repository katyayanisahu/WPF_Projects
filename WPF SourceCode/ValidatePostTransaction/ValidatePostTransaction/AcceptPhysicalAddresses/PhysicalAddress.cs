using ArcGIS.Desktop.Core;
using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Data;

namespace AcceptPhysicalAddresses
{

    public class PhysicalAddress
    {

        public int ParcelPk { get; set; }

        public bool NoAddr { get; set; }

        public int StreetNumber { get; set; }

        public String Msc { get; set; }

        public String Building { get; set; }

        public int Unit { get; set; }

        // public PrefixStatus Prefix { get; set; }
        public String Prefix { get; set; }


        public String StreetName{ get; set; }

        public String StreetType { get; set; }

        public String Suffix { get; set; }
        public String AddressType { get; set; }

        public String Primary { get; set; }
        public String CrLot{ get; set; }
        public String PJ { get; set; }
        public String Unique { get; set; }
        public String Status { get; set; }
        public String City { get; set; }

    }
    public class PrefixList : List<String>
    {
        public PrefixList() {
            this.Add("Open");
            this.Add("Closed");
        }
    }

    //public enum PrefixStatus{ None, New, Processing, Shipped, Received };
} 

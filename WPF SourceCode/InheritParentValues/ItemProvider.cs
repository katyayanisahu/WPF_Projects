using ArcGIS.Desktop.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritParentValues
{
    public class ItemProvider
    {
        private readonly DirectoryItem _rootDirectoryItem;

        public ItemProvider()
        {
            _rootDirectoryItem = new DirectoryItem { Name = "X" };

            var childItem1 = new DirectoryItem { Name = "(Parent) REID: 5986380441000, PIN: 5986380441" };

            var grandChildItem11 = new DirectoryItem { Name = "Owner = E R E V A N S & SONS INC" };
            var grandChildItem12 = new DirectoryItem { Name = "Deed Book = 000456" };

            var grandChildItem13 = new DirectoryItem { Name = "Deed Page = 00597" };
            var grandChildItem14 = new DirectoryItem { Name = "Deed Date = 1/4/1989 12:01:00 AM" };
            var grandChildItem15 = new DirectoryItem { Name = "Subdiv/Desc =  PORTER/BRIDGER" };
            var grandChildItem16 = new DirectoryItem { Name = "Situs Effective Date = 1/1/1900 12:00:00 AM" };

            var grandChildItem17 = new DirectoryItem { Name = "Corner Lot = N" };
            var grandChildItem18 = new DirectoryItem { Name = "Township = MURFREESBORO" };
            var grandChildItem19 = new DirectoryItem { Name = "CAMA MAP SCALE = 00" };

            //var greatgrandChildItem2 = new DirectoryItem { Name = "A2_1" };
            //grandChildItem11.AddDirItem(greatgrandChildItem2);

            childItem1.AddDirItem(grandChildItem11);
            childItem1.AddDirItem(grandChildItem12);


            childItem1.AddDirItem(grandChildItem13);
            childItem1.AddDirItem(grandChildItem14);


            childItem1.AddDirItem(grandChildItem15);
            childItem1.AddDirItem(grandChildItem16);


            childItem1.AddDirItem(grandChildItem17);
            childItem1.AddDirItem(grandChildItem18);


            childItem1.AddDirItem(grandChildItem19);


            //var childItem2 = new DirectoryItem { Name = "B" };
            //var childItem3 = new DirectoryItem { Name = "C" };
            //var childItem4 = new DirectoryItem { Name = "D" };

            //var grandChildItem121 = new DirectoryItem { Name = "B1" };
            //childItem2.AddDirItem(grandChildItem121);

            var childList1 = new List<DirectoryItem>
         {
            childItem1,
            //childItem2,
            //childItem3,
            //childItem4
         };

            _rootDirectoryItem.Items = childList1;
        }

        public List<Item> DirItems => _rootDirectoryItem.Traverse(_rootDirectoryItem);
    }
}

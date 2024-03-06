using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_jsoncontrols.Models
{
    public class jsoncontrols
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
        public int Width { get; set; }
        public int row { get; set; }
        public int column { get; set; }
        public int Height { get; set; }
        public string HorizontalAlignmemt { get; set; }
        public string VerticalAlignmemt { get; set; }

         public string  Path { get; set; }

        public string Margin { get; set; }

        public string Padding { get; set; }

        public int ColumnSpan { get; set; }
        public int RowSpan { get; set; }

        public string Background { get; set; }



    }

    public class jsoncontrollist
    {
        public List<jsoncontrols> controls { get; set; }
    }
}

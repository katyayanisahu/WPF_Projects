using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Haley.WPF;
using AttributerUI.Model;

namespace AttributerUI.Model
{
    public class LoadTransactionJsonControl
    {
     

        public int ID { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
        public int Width { get; set; }

        public int Height { get; set; }

        public string Background { get; set; }

        public string Foreground { get; set; }

        public string Margin { get; set; }

       // public string lightTheme{ get; set; }

    //public string Dock { get; set; }

    public string VerticallAlignmemt { get; set; }

        public string Orientation { get; set; }

        public string HorizontalAlignmemt { get; set; }
        public int row { get; set; }
        public int column { get; set; }

        public string Path { get; set; }

        public int ColumnSpan { get; set; }
        public int RowSpan { get; set; }

        public string FontWeight { get; set; }

        public string FontFamily { get; set; }

        public string FontStyle { get; set; }

 


    }

    public class jsoncontrollist2
    {
        public List<LoadTransactionJsonControl> controls { get; set; }
    }

}

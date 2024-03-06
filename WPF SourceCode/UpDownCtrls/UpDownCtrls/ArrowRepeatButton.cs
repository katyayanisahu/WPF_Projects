using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Windows.Controls.Primitives;

namespace UpDownCtrls
{
    public enum ButtonArrowType : byte
    {
        Down,
        Up,
        Left,
        Right
    }

    [ValueConversion(typeof(CornerCtrlEdge), typeof(CornerRadius))]
    public class CornerCtrlEdgeToRadiusConverter : IValueConverter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter">Must be a string that can be converted into an int, either directly as a decimal or as an hexadecimal
        /// prefixed with either 0x or 0X. The first 8 bits will give the CornerRadius rounding next to edge of control. The following bits will
        /// give rounding of a corner not adjoining an edge. Example: 0x305: inner rounding: 0x3, outer rounding: 0x5. Inner rounding of a 
        /// corner not adjoining an edge currently not used and set to 0.</param>
        /// <param name="culture"></param>
        /// <returns></returns>

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                 throw new System.ArgumentNullException();

            if (!(value is CornerCtrlEdge))
                throw new System.ArgumentException();

            string str = (string)parameter;
            CornerCtrlEdge cce = (CornerCtrlEdge)value; 
            int rounding;

            if (!int.TryParse(str, out rounding))
            {
                if (!(str[0] == '0' && (str[1] == 'x' || str[1] == 'X')))
                    throw new System.ArgumentException();

                if (!Int32.TryParse(str.Substring(2), System.Globalization.NumberStyles.HexNumber, null, out rounding))
                    throw new System.ArgumentException();
            }
            int NotEdgeRounding = rounding >> 8;
            int EdgeRounding = rounding & 0x000000FF;

            return new CornerRadius(cce.TopLeft? EdgeRounding : NotEdgeRounding, cce.TopRight? EdgeRounding : NotEdgeRounding,
                                    cce.BottomRight? EdgeRounding : NotEdgeRounding, cce.BottomLeft? EdgeRounding : NotEdgeRounding);
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException("Not Implemented.");
        }
    }

    public class CornerCtrlEdgeConverter : TypeConverter
    {
        public CornerCtrlEdgeConverter() { }
        public override bool CanConvertFrom(ITypeDescriptorContext typeDescriptorContext, Type sourceType)
        {
            return sourceType == Type.GetType("System.String"); 
        }
        public override bool CanConvertTo(ITypeDescriptorContext typeDescriptorContext, Type destinationType)
        {
            return destinationType == Type.GetType("System.String"); 
        }
        public override object ConvertFrom(ITypeDescriptorContext typeDescriptorContext, System.Globalization.CultureInfo cultureInfo, object source)
        {
            if (source == null)
                throw new System.ArgumentNullException();

            String[] strArr = ((String)source).Split(',');

            if (strArr.Count() != 4)
                throw new System.ArgumentException();

            bool[] cornerstates = new bool[4];

            for (int i = 0; i < strArr.Count(); i++)
            {
                if (!bool.TryParse(strArr[i], out cornerstates[i]))
                    throw new System.ArgumentException();
            }
            return new CornerCtrlEdge(cornerstates[0], cornerstates[1], cornerstates[2], cornerstates[3]);
        }
        public override object ConvertTo(ITypeDescriptorContext typeDescriptorContext, System.Globalization.CultureInfo cultureInfo, object value, Type destinationType)
        {
            if (value == null)
                throw new System.ArgumentNullException();
            if (!(value is CornerCtrlEdge))
                throw new System.ArgumentException();

            CornerCtrlEdge cce = (CornerCtrlEdge)(value);

            return cce.TopLeft.ToString() + "," + cce.TopRight.ToString() + "," + cce.BottomRight.ToString() + "," + cce.BottomLeft.ToString();
        }
    }

    /// <summary>
    /// CornerCtrlEdge is used to indicate which corners of the arrow button are on the edge of the control in which it
    /// is inserted. If for instance the arrow button is placed on right hand side as with a combo box, then both right hand
    /// sides corners of CornerCtrlEdge will be set to true, while both left hand sides will be set to false.
    /// Order is same as with Border.CornerRadius: topleft, topright, bottomright, bottomleft.
    /// Reason for this is because with some themes (example: Aero), button has slightly rounded corners when these are on 
    /// edge of control.
    /// </summary>
    [TypeConverter(typeof(CornerCtrlEdgeConverter))]
    public struct CornerCtrlEdge : IEquatable<CornerCtrlEdge>
    {
        private bool topLeft, topRight, bottomRight, bottomLeft;
        public CornerCtrlEdge(bool uniformCtrlEdge)
        {
           topLeft = topRight = bottomRight = bottomLeft = uniformCtrlEdge;
        }
        public CornerCtrlEdge(bool topLeft, bool topRight, bool bottomRight, bool bottomLeft)
        {
            this.topLeft = topLeft;
            this.topRight = topRight;
            this.bottomRight = bottomRight;
            this.bottomLeft = bottomLeft;
        }
        public bool BottomLeft {get { return bottomLeft; } set { bottomLeft = value; }}
        public bool BottomRight {get { return bottomRight; } set { bottomRight = value; }}
        public bool TopLeft {get { return topLeft; } set { topLeft = value; }}
        public bool TopRight {get { return topRight; } set { topRight = value; }}

        public static bool operator != (CornerCtrlEdge cce1, CornerCtrlEdge cce2)
        {
            return cce1.topLeft != cce2.topLeft || cce1.topRight != cce2.topRight ||
                    cce1.bottomRight != cce2.bottomRight || cce1.bottomLeft != cce2.topLeft;
        }
        public static bool operator == (CornerCtrlEdge cce1, CornerCtrlEdge cce2)
        {
            return cce1.topLeft == cce2.topLeft && cce1.topRight == cce2.topRight &&
                cce1.bottomRight == cce2.bottomRight && cce1.bottomLeft == cce2.topLeft;
        }
        public bool Equals(CornerCtrlEdge cornerRadius)
        {
            return this == cornerRadius;
        }
        public override bool Equals(object obj)
        {
            if (obj is CornerCtrlEdge)
                return this == (CornerCtrlEdge)obj;
            else
                return false;
        }
        public override int GetHashCode()
        {
            return (topLeft? 0x00001000 : 0x00000000) | (topRight? 0x00000100 : 0x00000000) |
                (bottomRight? 0x00000010 : 0x00000000) | (bottomLeft? 0x00000001 : 0x00000000);
        }
        public override string ToString()
        {
            return topLeft.ToString() + "," + topRight.ToString() + "," + bottomRight.ToString() + "," + bottomLeft.ToString();
        }
    }

    public class ArrowRepeatButton : RepeatButton
    {
        private static readonly DependencyProperty ButtonArrowTypeProperty =
            DependencyProperty.Register("ButtonArrowType", typeof(ButtonArrowType), typeof(ArrowRepeatButton), new FrameworkPropertyMetadata(ButtonArrowType.Down));
        private static readonly DependencyProperty CornerCtrlEdgeProperty =
            DependencyProperty.Register("CornerCtrlEdge", typeof(CornerCtrlEdge), typeof(ArrowRepeatButton), new FrameworkPropertyMetadata(new CornerCtrlEdge(false, true, true, false)));

        static ArrowRepeatButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ArrowRepeatButton), new FrameworkPropertyMetadata(typeof(ArrowRepeatButton)));
        }
        public ButtonArrowType ButtonArrowType
        {
            get { return (ButtonArrowType)GetValue(ButtonArrowTypeProperty); }
            set { SetValue(ButtonArrowTypeProperty, value); }
        }
        public CornerCtrlEdge CornerCtrlEdge
        {
            get { return (CornerCtrlEdge)GetValue(CornerCtrlEdgeProperty); }
            set { SetValue(CornerCtrlEdgeProperty, value); }
        }
    }
}

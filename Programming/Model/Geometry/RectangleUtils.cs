using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.Model.Geometry
{
    public static class RectangleUtils
    {
        public static void UpdateRectangleInfo(Model.Rectangle rectangle, TextBox IDRectangleBox, TextBox widthRectangleBox, TextBox lengthRectangleBox, TextBox XCenterBox, TextBox YCenterBox)
        {
            if (rectangle != null)
            {
                IDRectangleBox.Text = rectangle.ID.ToString();
                lengthRectangleBox.Text = rectangle.Length.ToString();
                widthRectangleBox.Text = rectangle.Width.ToString();
                XCenterBox.Text = rectangle.Center.X.ToString();
                YCenterBox.Text = rectangle.Center.Y.ToString();
            }
        }
        public static void ClearRectangleInfo(TextBox IDRectangleBox, TextBox widthRectangleBox, TextBox lengthRectangleBox, TextBox XCenterBox, TextBox YCenterBox)
        {
            widthRectangleBox.Text = string.Empty;
            lengthRectangleBox.Text = string.Empty;
            XCenterBox.Text = string.Empty;
            YCenterBox.Text = string.Empty;
            IDRectangleBox.Text = string.Empty;
        }
    }
}

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
        /// <summary>
        /// A function of updating rectangle's fields.
        /// </summary>
        /// <param name="rectangle"> Current rectangle. </param>
        /// <param name="IDRectangleBox"> The field is readonly. </param>
        /// <param name="widthRectangleBox"> The field must be positive and double. </param>
        /// <param name="lengthRectangleBox"> The field must be positive and double. </param>
        /// <param name="XCenterBox"> The field must be positiveand double. </param>
        /// <param name="YCenterBox"> The field must be positive and double. </param>
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

        /// <summary>
        /// Deleting rectangle's data in fields.
        /// </summary>
        /// <param name="IDRectangleBox"></param>
        /// <param name="widthRectangleBox"></param>
        /// <param name="lengthRectangleBox"></param>
        /// <param name="XCenterBox"></param>
        /// <param name="YCenterBox"></param>
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

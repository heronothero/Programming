using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public static class AppColors
    {
        public static readonly Color ValidationError = Color.LightPink;
        public static readonly Color ValidationSuccess = SystemColors.Window;
        public static readonly Color Winter = Color.LightBlue;
        public static readonly Color Spring = Color.LightGreen;
        public static readonly Color Summer = Color.Yellow;
        public static readonly Color Autumn = Color.Orange;
        public static readonly Color RectangleCollision = Color.FromArgb(127, 255, 127, 127);
        public static readonly Color RectangleNoCollision = Color.FromArgb(127, 127, 255, 127);
    }
}

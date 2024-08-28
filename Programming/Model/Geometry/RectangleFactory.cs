using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.Model.Geometry
{
    public static class RectangleFactory
    {
        private static Random random = new Random();
        public static Model.Rectangle Randomize()
        {
            double x = random.NextDouble() * 500;
            double y = random.NextDouble() * 500;
            double length = random.NextDouble() * 100;
            double width = random.NextDouble() * 100;
            string color = GetRandomColor();
            Point2D center = new Point2D(x, y);
            return new Model.Rectangle(length, width, color, center);
        }
        private static string GetRandomColor()
        {
            string[] availableColors = { "blue", "red", "green", "yellow", "black", "white" };
            return availableColors[random.Next(availableColors.Length)];
        }
    }
}

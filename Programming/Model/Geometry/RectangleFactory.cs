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
        public static Model.Rectangle Randomize(int canvasWidth, int canvasHeight, int margin = 30)
        {
            double length = random.NextDouble() * (100 - 10) + 10;
            double width = random.NextDouble() * (100 - 10) + 10;
            double maxX = canvasWidth - margin - width / 2;
            double minX = margin + width / 2;
            double maxY = canvasHeight - margin - length / 2;
            double minY = margin + length / 2;
            double x = random.NextDouble() * (maxX - minX) + minX;
            double y = random.NextDouble() * (maxY - minY) + minY;
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

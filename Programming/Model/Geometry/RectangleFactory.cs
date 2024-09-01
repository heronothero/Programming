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
        /// <summary>
        /// A private property of creating random
        /// </summary>
        private static Random random = new Random();

        /// <summary>
        /// A function of generating a random rectangle
        /// </summary>
        /// <param name="canvasWidth"> A canva's width </param>
        /// <param name="canvasHeight"> A canva's height </param>
        /// <param name="margin"> Internal indentation from the canvas margins </param>
        /// <returns> Returns new rectangle </returns>
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

        /// <summary>
        /// A function of generating random color for rectangles
        /// </summary>
        /// <returns> Returns random available color </returns>
        public static string GetRandomColor()
        {
            string[] availableColors = { "blue", "red", "green", "yellow", "black", "white" };
            return availableColors[random.Next(availableColors.Length)];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Rectangle
    {
        private double length;
        private double width;
        private string color;
        public Point2D Center { get; private set; }
        public int ID { get; }
        public double Length
        {
            get { return length; }
            set 
            {
                Validator.AssertOnPositiveValue(value, "Length");
                length = value;
            }
        }
        public double Width
        {
            get { return width; }
            set 
            {
                Validator.AssertOnPositiveValue(value, "Width");
                width = value;
            }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public void SetCenter(double x, double y)
        {
            Center = new Point2D(x, y);
        }
        private static int _allRectanglesCount = 0;
        public static int AllRectanglesCount
        {
           get { return _allRectanglesCount; }
        }
        public Rectangle(double length, double width, string color, Point2D center)
        {
            Length = length;
            Width = width;
            Color = color;
            Center = center;
            _allRectanglesCount++;
            ID = _allRectanglesCount;
        }
        ~Rectangle()
        {
            _allRectanglesCount--;
        }
    }
}

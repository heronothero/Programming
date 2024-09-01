using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Rectangle
    {
        /// <summary>
        /// A private property of length
        /// </summary>
        private double length;

        /// <summary>
        /// A private property of width
        /// </summary>
        private double width;

        /// <summary>
        /// A private property of color
        /// </summary>
        private string color;

        /// <summary>
        /// A public property of rectangle's coordinates
        /// </summary>
        public Point2D Center { get; private set; }

        /// <summary>
        /// A public property of rectangle's ID
        /// </summary>
        public int ID { get; }

        /// <summary>
        /// A public property of rectangle's length which must be double and positive
        /// </summary>
        public double Length
        {
            get { return length; }
            set 
            {
                Validator.AssertOnPositiveValue(value, "Length");
                length = value;
            }
        }

        /// <summary>
        /// A public property of rectangle's width which must be double and positive
        /// </summary>
        public double Width
        {
            get { return width; }
            set 
            {
                Validator.AssertOnPositiveValue(value, "Width");
                width = value;
            }
        }

        /// <summary>
        /// A public property of color
        /// </summary>
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        /// <summary>
        /// A public property of setting coordinates
        /// </summary>
        /// <param name="x"> The horizontal axis </param>
        /// <param name="y"> The vertical axis </param>
        public void SetCenter(double x, double y)
        {
            Center = new Point2D(x, y);
        }

        /// <summary>
        /// A private property of counter of rectangles which is equal to 0
        /// </summary>
        private static int _allRectanglesCount = 0;

        /// <summary>
        /// A public property of rectangles' counter
        /// </summary>
        public static int AllRectanglesCount
        {
           get { return _allRectanglesCount; }
        }

        /// <summary>
        /// Rectangle's constructor
        /// </summary>
        /// <param name="length"> The field must be double </param>
        /// <param name="width"> The field must be double </param>
        /// <param name="color"> The value of the field will be chosen by random from array </param>
        /// <param name="center"> The field must be double and positive </param>
        public Rectangle(double length, double width, string color, Point2D center)
        {
            Length = length;
            Width = width;
            Color = color;
            Center = center;
            _allRectanglesCount++;
            ID = _allRectanglesCount;
        }

        /// <summary>
        /// Deleting rectangles
        /// </summary>
        ~Rectangle()
        {
            _allRectanglesCount--;
        }
    }
}

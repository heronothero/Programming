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
        public double Length {
            get { return length; }
            set
            {
                Validator.AssertOnPositiveValue(value, "Length");
                length = value;
            }
        }
        public double Width {
            get { return width; }
            set
            {
                Validator.AssertOnPositiveValue(value, "Width");
                width = value;
            }
        }
        public string Color {
            get { return color; }
            set { color = value; }
        }
        public Rectangle(double width, double length, string color)
        {
            Width = width;
            Length = length;
            Color = color;
        }
    }
}

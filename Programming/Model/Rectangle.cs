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
                if (value <= 0)
                {
                    throw new ArgumentException("Длина должна быть положительным числом.");
                }
                length = value;
            }
        }
        public double Width {
            get { return width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Ширина должна быть положительным числом.");
                }
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

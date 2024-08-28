using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Ring
    {
        private double innerRadius;
        private double outerRadius;
        public Point2D Center { get; set; }
        public double InnerRadius
        {
            get { return innerRadius; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Inner radius must be a positive number.");
                }
                if (outerRadius > 0 && value > outerRadius)
                {
                    throw new ArgumentException("Inner radius cannot be greater than outer radius.");
                }
                innerRadius = value;
            }
        }

        public double OuterRadius
        {
            get { return outerRadius; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Outer radius must be a positive number.");
                }
                if (value < innerRadius)
                {
                    throw new ArgumentException("Outer radius cannot be less than inner radius.");
                }
                outerRadius = value;
            }
        }
        public double Area
        {
            get
            {
                double outArea = Math.PI * Math.Pow(outerRadius, 2);
                double innerArea = Math.PI * Math.Pow(innerRadius, 2);
                return outArea - innerArea;
            }
        }
        public Ring (Point2D center, double innerRadius, double outerRadius)
        {
            Center = center;
            InnerRadius = innerRadius;
            OuterRadius = outerRadius;
        }
    }
}

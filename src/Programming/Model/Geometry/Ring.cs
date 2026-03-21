using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Ring
    {
        /// <summary>
        /// A private property of inner radius.
        /// </summary>
        private double innerRadius;

        /// <summary>
        /// A private property of outer radius.
        /// </summary>
        private double outerRadius;

        /// <summary>
        /// A public property of ring's coordinates.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// A function of finding an inner radius, which must be a positive value but less than outer radius.
        /// </summary>
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

        /// <summary>
        /// A function of finding an outer radius, which must be a positive value but more than inner radius.
        /// </summary>
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

        /// <summary>
        /// A function of finding areas of inner radius and outer radius.
        /// </summary>
        public double Area
        {
            get
            {
                double outArea = Math.PI * Math.Pow(outerRadius, 2);
                double innerArea = Math.PI * Math.Pow(innerRadius, 2);
                return outArea - innerArea;
            }
        }

        /// <summary>
        /// A ring's constructor.
        /// </summary>
        /// <param name="center"> Contains x & y which must be positive and double. </param>
        /// <param name="innerRadius"> The field being checked. </param>
        /// <param name="outerRadius"> The field being checked. </param>
        public Ring (Point2D center, double innerRadius, double outerRadius)
        {
            Center = center;
            InnerRadius = innerRadius;
            OuterRadius = outerRadius;
        }
    }
}

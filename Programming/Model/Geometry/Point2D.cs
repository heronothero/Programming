using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Point2D
    {
        /// <summary>
        /// A public property of x
        /// </summary>
        public double X { get; private set; } 

        /// <summary>
        /// A public property of y
        /// </summary>
        public double Y { get; private set; }

        /// <summary>
        /// A function of coordinates
        /// </summary>
        /// <param name="x"> The horizontal axis, which must be double and positive </param>
        /// <param name="y"> The vertical axis, which must be double and positive </param>
        public Point2D (double x, double y)
        {
            X = Validator.ValidateCoordinate(x, nameof(X));
            Y = Validator.ValidateCoordinate(y, nameof(Y));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Point2D
    {
        public double X { get; private set; } 
        public double Y { get; private set; }
        public Point2D (double x, double y)
        {
            X = Validator.ValidateCoordinate(x, nameof(X));
            Y = Validator.ValidateCoordinate(y, nameof(Y));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public static class CollisionManager
    {
        /// <summary>
        /// A function of finding rectangles' collisions.
        /// </summary>
        /// <param name="rectangle1"> A first rectangle which will be checked with next rectangle. </param>
        /// <param name="rectangle2"> A second rectangle which will be checked with a previous rectangle. </param>
        /// <returns> A bool value that returns intersected rectangles on the vertical axis or horizontal. </returns>
        public static bool IsCollisionRectangles(Rectangle rectangle1, Rectangle rectangle2)
        {
            double deltaX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            double deltaY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);
            double halfWidth1 = rectangle1.Width / 2;
            double halfWidth2 = rectangle2.Width / 2;
            double halfLength1 = rectangle1.Length / 2;
            double halfLength2 = rectangle2.Length / 2;
            bool isXCollision = deltaX < (halfWidth1 + halfWidth2);
            bool isYCollision = deltaY < (halfLength1 + halfLength2);
            return isXCollision && isYCollision;
        }

        /// <summary>
        /// A function of finding rings' collisions.
        /// </summary>
        /// <param name="ring1"> A first ring which will be checked with next ring. </param>
        /// <param name="ring2"> A second ring which will be checked with the previous ring. </param>
        /// <returns> A bool value that returns intersected rings in outer radius or inner radius.  </returns>
        public static bool IsCollisionRings(Ring ring1, Ring ring2)
        {
            double distanceBetweenCenters = Math.Sqrt(Math.Pow(ring1.Center.X - ring2.Center.X, 2) + Math.Pow(ring1.Center.Y - ring2.Center.Y, 2));
            bool isOuterCollision = distanceBetweenCenters < (ring1.OuterRadius + ring2.OuterRadius);
            bool isOneRingInsideAnother = distanceBetweenCenters + Math.Min(ring1.OuterRadius, ring2.OuterRadius) < Math.Max(ring1.OuterRadius, ring2.OuterRadius);
            return isOuterCollision && isOneRingInsideAnother;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public static class CollisionManager
    {
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
        public static bool IsCollisionRings(Ring ring1, Ring ring2)
        {
            double distanceBetweenCenters = Math.Sqrt(Math.Pow(ring1.Center.X - ring2.Center.X, 2) + Math.Pow(ring1.Center.Y - ring2.Center.Y, 2));
            bool isOuterCollision = distanceBetweenCenters < (ring1.OuterRadius + ring2.OuterRadius);
            bool isOneRingInsideAnother = distanceBetweenCenters + Math.Min(ring1.OuterRadius, ring2.OuterRadius) < Math.Max(ring1.OuterRadius, ring2.OuterRadius);
            return isOuterCollision && isOneRingInsideAnother;
        }
    }
}

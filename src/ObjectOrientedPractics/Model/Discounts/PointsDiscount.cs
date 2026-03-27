using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    public class PointsDiscount
    {
        private int _points;

        public int Points
        {
            get => _points;
            private set => _points = value < 0 ? 0 : value;
        }

        public string Info => $"Накопительная – {Points} баллов";

        public double Calculate(List<Item> items)
        {
            double total = (double)items.Sum(i => i.Cost); //Можно ли так явно преобразовывать?
            double maxDiscount = total * 0.3;

            return Math.Min(Points, maxDiscount);
        }

        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);

            Points -= (int)Math.Ceiling(discount);

            return discount;
        }

        public void Update(List<Item> items)
        {
            double total = (double)items.Sum(i => i.Cost);

            int earnedPoints = (int)Math.Ceiling(total * 0.1);
            Points += earnedPoints;
        }
    }
}

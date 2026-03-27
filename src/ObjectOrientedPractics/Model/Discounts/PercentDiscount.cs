using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    public class PercentDiscount : IDiscount
    {
        private int _percent = 1;
        private double _totalSpent = 0;

        public int Percent
        {
            get => _percent;
            private set
            {
                if (value < 1) _percent = 1;
                else if (value > 10) _percent = 10;
                else _percent = value;
            }
        }

        public Category Category { get; }

        public string Info => $"Процентная \"{Category}\" - {Percent}%";

        public PercentDiscount(Category category)
        {
            Category = category;
        }

        public double Calculate(List<Item> items)
        {
            double sum = (double)items
                .Where(i => i.Category == Category)
                .Sum(i => i.Cost);

            return sum * Percent / 100.0;
        }

        public double Apply(List<Item> items)
        {
            return Calculate(items);
        }

        public void Update(List<Item> items)
        {
            double sum = (double)items
                .Where(i => i.Category == Category)
                .Sum(i => i.Cost);

            if (sum == 0) return;

            _totalSpent += sum;

            int newPercent = 1 + (int)(_totalSpent / 1000);

            Percent = newPercent;
        }
    }
}

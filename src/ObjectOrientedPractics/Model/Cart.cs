using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс корзины
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// Список товаров
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Список товаров в корзине
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set => _items = value ?? new List<Item>();
        }

        /// <summary>
        /// Общая стоимость товаров
        /// </summary>
        public decimal Amount
        {
            get
            {
                if (_items.Count == 0 || _items == null)
                    return 0;
                decimal sum = 0;

                foreach (var item in _items)
                {
                    sum += item.Cost;
                }

                return sum;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс корзины, позволяет вычислить стоимость товаров в ней
    /// </summary>
    public class Cart : ICloneable
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
                decimal sum = 0;

                foreach (var item in _items)
                {
                    sum += item.Cost;
                }

                return sum;
            }
        }

        /// <summary>
        /// Создаёт глубокую копию корзины вместе с товарами
        /// </summary>
        /// <returns>Копия объекта корзины</returns>
        public object Clone()
        {
            var newCart = new Cart();

            newCart.Items = _items
                .Select(item => (Item)item.Clone())
                .ToList();

            return newCart;
        }
    }
}

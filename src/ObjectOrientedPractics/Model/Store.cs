using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Store
    {
        /// <summary>
        /// Список товаров
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Список покупателей
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Свойство товаров
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set => _items = value ?? new List<Item>();
        }

        /// <summary>
        /// Свойство покупателей
        /// </summary>
        public List<Customer> Customers
        {
            get => _customers;
            set => _customers = value ?? new List<Customer>();
        }

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Store()
        {
            _items = new List<Item>();
            _customers = new List<Customer>();
        }
    }
}

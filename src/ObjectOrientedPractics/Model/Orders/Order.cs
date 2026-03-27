using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.Model.Orders
{
    /// <summary>
    /// Представляет заказ пользователя, содержащий список товаров, адрес доставки, статус и время создания заказа
    /// </summary>
    public class Order
    {
        private readonly int _id;
        private readonly DateTime _createdAt;
        private List<Item> _items;
        private Address _deliveryAddress;
        private OrderStatus _orderStatus;

        /// <summary>
        /// Уникальный идентификатор заказа
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Дата и время создания заказа
        /// </summary>
        public DateTime CreatedAt => _createdAt;

        /// <summary>
        /// Список товаров в заказе
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set => _items = value ?? new List<Item>();
        }

        /// <summary>
        /// Адрес доставки
        /// </summary>
        public Address DeliveryAddress
        {
            get => _deliveryAddress;
            set => _deliveryAddress = value ?? new Address();
        }

        /// <summary>
        /// Статус заказа
        /// </summary>
        public OrderStatus OrderStatus
        {
            get => _orderStatus;
            set => _orderStatus = value;
        }

        /// <summary>
        /// Сумма заказа (общая стоимость)
        /// </summary>
        public decimal Amount
        {
            get
            {
                if (_items == null || _items.Count == 0)
                    return 0;

                decimal sum = 0;

                foreach (var item in _items)
                {
                    sum += item.Cost;
                }

                return sum;
            }
        }

        /// <summary>
        /// Создает новый заказ с указанными товарами и адресом доставки
        /// При создании устанавливается уникальный идентификатор и текущая дата/время
        /// Изначально статус заказа New
        /// </summary>
        /// <param name="items">Товары</param>
        /// <param name="deliveryAddress">Адрес доставки</param>
        public Order(List<Item> items, Address deliveryAddress)
        {
            _id = IdGenerator.GetNextIdOrder();
            _createdAt = DateTime.Now;
            _orderStatus = OrderStatus.New;
            _deliveryAddress = deliveryAddress ?? new Address();
            _items = items ?? new List<Item>();
        }

        public Order()
        {
            _id = IdGenerator.GetNextIdOrder();
            _createdAt = DateTime.Now;
            _orderStatus = OrderStatus.New;
            _deliveryAddress = new Address();
            _items = new List<Item>();
        }

        protected Order(int id, DateTime createdAt, OrderStatus status, Address deliveryAddress, List<Item> items)
        {
            _id = id;
            _createdAt = createdAt;
            _orderStatus = status;
            _deliveryAddress = deliveryAddress ?? new Address();
            _items = items ?? new List<Item>();
        }
    }
}

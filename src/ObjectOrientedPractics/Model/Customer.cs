using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс покупателя
    /// </summary>
    public class Customer
    {
        private readonly int _id;
        private string _fullName;
        private Address _address = new Address();
        private Cart _cart;
        private List<Order> _orders;

        public bool IsPriority { get; set; } = false;

        /// <summary>
        /// Свойство идентификатора
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Свойство ФИО, при котором оно не может быть пустым и превышать 200 символов
        /// </summary>
        public string FullName
        {
            get => _fullName;
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(FullName));
                _fullName = value;
            }
        }

        /// <summary>
        /// Свойство адреса
        /// </summary>
        public Address Address
        {
            get => _address;
            set => _address = value;
        }

        /// <summary>
        /// Свойство корзины
        /// </summary>
        public Cart Cart
        {
            get => _cart;
            set => _cart = value ?? new Cart();
        }

        /// <summary>
        /// Свойство заказов
        /// </summary>
        public List<Order> Orders
        {
            get => _orders;
            set => _orders = value ?? new List<Order>();
        }

        /// <summary>
        /// Переписывает в строчные данные
        /// </summary>
        /// <returns>Возвращает результат данных в строковом типе</returns>
        public override string ToString()
        {
            return FullName;
        }

        /// <summary>
        /// Конструктор класса клиента
        /// </summary>
        /// <param name="id">Уникальный идентификатор клиента</param>
        /// <param name="fullName">ФИО клиента</param>
        /// <param name="address">Адрес клиента</param>
        /// <param name="cart">Корзина клиента</param>
        /// <param name="orders">Заказы клиента</param>
        public Customer()
        {
            _id = IdGenerator.GetNextIdCustomer();
            _fullName = "Andrew Stone";
            _address = new Address();
            _cart = new Cart();
            _orders = new List<Order>();
        }
    }
}

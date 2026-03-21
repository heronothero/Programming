using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    internal class Customer
    {
        /// <summary>
        /// Статические поля
        /// </summary>
        private readonly int _id;
        private string _fullName;
        private string _address;

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
        /// Свойство адреса, при котором оно не может быть пустым и превышать 500 символов
        /// </summary>
        public string Address
        {
            get => _address;
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, nameof(Address));
                _address = value;
            }
        }

        /// <summary>
        /// Конструктор класса клиента
        /// </summary>
        /// <param name="id">Уникальный идентификатор клиента</param>
        /// <param name="fullName">ФИО клиента</param>
        /// <param name="address">Адрес клиента</param>
        public Customer(string fullName, string address)
        {
            _id = IdGenerator.GetNextId();
            FullName = fullName;
            Address = address;
        }
    }
}

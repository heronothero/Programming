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
        private readonly int _id;
        private string _fullName;
        private string _address;

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
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("The parametr can't be empty.");
                if (value.Length > 200)
                    throw new ArgumentException("The parametr must not exceed 200 symbols");
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
                if (value.Length > 500)
                    throw new ArgumentException("The prametr must not exceed 500 symbols");
                _address = value;
            }
        }
    }
}

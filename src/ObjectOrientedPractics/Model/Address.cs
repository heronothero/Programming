using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Address
    {
        /// <summary>
        /// Статические поля
        /// </summary>
        private int _index;
        private string _country;
        private string _city;
        private string _street;
        private string _building;
        private string _apartment;

        /// <summary>
        /// Почтовый индекс
        /// </summary>
        public int Index
        {
            get => _index;
            set
            {
                if (value < 100000 || value > 999999)
                    throw new ArgumentException("Индекс должен быть шестизначным");
                _index = value;
            }
        }

        /// <summary>
        /// Страна
        /// </summary>
        public string Country
        {
            get => _country;
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
                _country = value;
            }
        }

        /// <summary>
        /// Город
        /// </summary>
        public string City
        {
            get => _city;
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(City));
                _city = value;
            }
        }

        /// <summary>
        /// Улица
        /// </summary>
        public string Street
        {
            get => _street;
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, nameof(Street));
                _street = value;
            }
        }

        /// <summary>
        /// Здание
        /// </summary>
        public string Building
        {
            get => _building;
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Building));
                _building = value;
            }
        }

        /// <summary>
        /// Квартира
        /// </summary>
        public string Apartment
        {
            get => _apartment;
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment));
                _apartment = value;
            }
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Address()
        {
            _index = 100000;
            _country = "";
            _city = "";
            _street = "";
            _building = "";
            _apartment = "";
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="index">Почтовый индекс</param>
        /// <param name="country">Страна</param>
        /// <param name="city">Город</param>
        /// <param name="street">Улица</param>
        /// <param name="building">Здание</param>
        /// <param name="apartment">Квартира</param>
        public Address (int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Возвращает строковое представление адреса
        /// </summary>
        /// <returns>Измененный тип данных адреса</returns>
        public override string ToString()
        {
            return $"{Index}, {Country}, {City}, {Street}, {Building}, {Apartment}";
        }
    }
}

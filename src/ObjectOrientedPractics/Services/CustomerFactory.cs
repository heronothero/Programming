using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    internal class CustomerFactory
    {
        /// <summary>
        /// Статический генератор случайных чисел для создания случайных покупателей
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Массив ФИО
        /// </summary>
        private static string[] _fullNames =
        {
            "Юдин Яков Евгеньевич",
            "Сидоров Евгений Савванович",
            "Мельникова Ефросинья Алексеевна",
            "Жданова Альбина Никитьевна",
            "Пахомов Иван Игнатьевич",
            "Беспалова Заря Георгьевна",
            "Рыбаков Нифонт Фадеевич",
            "Соловьева Катерина Тарасовна",
            "Харитонова Клара Никитьевна",
            "Соболева Юлиана Марковна",
        };

        /// <summary>
        /// Статичные поля, содержащие массивы строковых данных
        /// </summary>
        private static string[] _countries = { "Россия", "Беларусь", "Казахстан" };
        private static string[] _cities = { "Москва", "Санкт-Петербург", "Новосибирск", "Казань" };
        private static string[] _streets = { "Ленина", "Мира", "Пушкина", "Советская", "Октябрьская" };

        /// <summary>
        /// Создает случайного покупателя с валидным адресом
        /// </summary>
        /// <returns>Возвращает покупателя с заполненными адресом и ФИО</returns>
        public static Customer CreateRandom()
        {
            var address = new Address
            (
                index: _random.Next(100000, 999999),
                country: _countries[_random.Next(_countries.Length)],
                city: _cities[_random.Next(_cities.Length)],
                street: _streets[_random.Next(_streets.Length)],
                building: (_random.Next(1, 100) + "а"),
                apartment: (_random.Next(1, 200).ToString())
            );

            return new Customer
            {
                FullName = _fullNames[_random.Next(_fullNames.Length)],
                Address = address
            };
        }
    }
}

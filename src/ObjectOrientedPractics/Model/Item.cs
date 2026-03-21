using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс товара
    /// </summary>
    internal class Item
    {
        /// <summary>
        /// Статичные поля
        /// </summary>
        private readonly int _id;
        private string _name;
        private string _info;
        private decimal _cost;

        /// <summary>
        /// Свойство идентификатора товара
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Свойство названия товара, при котором оно не может быть пустым и превышать 200 символов
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Свойство описания товара, при котором оно может быть пустым, но не должно превышать 1000 символов
        /// </summary>
        public string Info
        {
            get => _info;
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                _info = value;
            }
        }

        /// <summary>
        /// Свойство цены товара, которое не может быть равным 0 или больше 100000
        /// </summary>
        public decimal Cost
        {
            get => _cost;
            set
            {
                ValueValidator.AssertNumberInRange(value, 0m, 100000m, nameof(Cost));
                _cost = value;
            }
        }

        /// <summary>
        /// Конструктор товара
        /// </summary>
        /// <param name="id">Уникальный идентификатор товара</param>
        /// <param name="name">Название товара</param>
        /// <param name="info">Описание товара</param>
        /// <param name="cost">Цена товара</param>
        public Item(string name, string info, decimal cost)
        {
            _id = IdGenerator.GetNextId();
            Name = name;
            Info = info;
            Cost = cost;
        }
    }
}

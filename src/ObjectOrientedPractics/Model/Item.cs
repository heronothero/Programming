using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс товара
    /// </summary>
    public class Item : ICloneable, IEquatable<Item>, IComparable<Item>
    {
        /// <summary>
        /// Статичные поля
        /// </summary>
        private readonly int _id;
        private string _name;
        private string _info;
        private decimal _cost;

        /// <summary>
        /// Объявление категорий
        /// </summary>
        public Category Category { get; set; }

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
        /// Перевод значений в строковые данные
        /// </summary>
        /// <returns>Возвращает измененный тип данных</returns>
        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// Конструктор товара
        /// </summary>
        /// <param name="id">Уникальный идентификатор товара</param>
        /// <param name="name">Название товара</param>
        /// <param name="info">Описание товара</param>
        /// <param name="cost">Цена товара</param>
        public Item(string name, string info, decimal cost, Category category)
        {
            _id = IdGenerator.GetNextIdItem();
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }

        public object Clone()
        {
            return new Item(Name, Info, Cost, Category);
        }

        public bool Equals(Item other)
        {
            if (other == null) return false;

            return Name == other.Name
                && Info == other.Info
                && Cost == other.Cost
                && Category == other.Category;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Item);
        }

        public int CompareTo(Item other)
        {
            if (other == null) return 1;

            return Cost.CompareTo(other.Cost);
        }
    }
}

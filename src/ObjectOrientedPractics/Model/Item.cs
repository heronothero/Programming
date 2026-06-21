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
        /// Уникальный идентификатор товара
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Название товара
        /// </summary>
        private string _name;

        /// <summary>
        /// Описание товара
        /// </summary>
        private string _info;

        /// <summary>
        /// Цена товара
        /// </summary>
        private decimal _cost;

        /// <summary>
        /// Событие изменения названия товара
        /// </summary>
        public event EventHandler NameChanged;

        /// <summary>
        /// Событие изменения цены товара
        /// </summary>
        public event EventHandler CostChanged;

        /// <summary>
        /// Событие изменения описания товара
        /// </summary>
        public event EventHandler InfoChanged;

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
                if (_name == value) return;

                _name = value;
                NameChanged?.Invoke(this, EventArgs.Empty);
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
                if (_info == value) return;

                _info = value;
                InfoChanged?.Invoke(this, EventArgs.Empty);
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
                if (_cost == value) return;

                _cost = value;
                CostChanged?.Invoke(this, EventArgs.Empty);
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

        /// <summary>
        /// Создает копию товара
        /// </summary>
        public object Clone()
        {
            return new Item(Name, Info, Cost, Category);
        }

        /// <summary>
        /// Определяет равенство товаров по основным полям
        /// </summary>
        public bool Equals(Item other)
        {
            if (other == null) return false;

            return Name == other.Name
                && Info == other.Info
                && Cost == other.Cost
                && Category == other.Category;
        }

        /// <summary>
        /// Определяет равенсто объектов
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return Equals(obj as Item);
        }

        /// <summary>
        /// Сравнивает товары по стоимости
        /// </summary>
        public int CompareTo(Item other)
        {
            if (other == null) return 1;

            return Cost.CompareTo(other.Cost);
        }
    }
}

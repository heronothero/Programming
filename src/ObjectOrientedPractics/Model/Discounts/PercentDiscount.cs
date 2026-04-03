using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Представляет процентную скидку для определённой категории товаров
    /// Процент скидки увеличивается в зависимости от общей суммы покупок
    /// </summary>
    public class PercentDiscount : IDiscount, IComparable<PercentDiscount>
    {
        /// <summary>
        /// Текущий процент скидки (1%-10%)
        /// </summary>
        private int _percent = 1;

        /// <summary>
        /// бщая сумма покупок по данной категории
        /// Используется для увеличения процента скидки
        /// </summary>
        private double _totalSpent = 0;

        /// <summary>
        /// Получает текущий процент скидки (диапазон от 1 до 10)
        /// </summary>
        public int Percent
        {
            get => _percent;
            private set
            {
                if (value < 1) _percent = 1;
                else if (value > 10) _percent = 10;
                else _percent = value;
            }
        }

        /// <summary>
        /// Категория товаров, к которой применяется скидка
        /// </summary>
        public Category Category { get; }

        /// <summary>
        /// Получает строку с информацией о скидке
        /// </summary>
        public string Info => $"Процентная \"{Category}\" - {Percent}%";

        /// <summary>
        /// Инициализирует новый экземпляр скидки для указанной категории
        /// </summary>
        /// <param name="category">Категория товаров</param>
        public PercentDiscount(Category category)
        {
            Category = category;
        }

        /// <summary>
        /// Вычисляет размер скидки для товаров заданной категории
        /// </summary>
        /// <param name="items">Список товаров</param>
        /// <returns>Размер скидки</returns>
        public double Calculate(List<Item> items)
        {
            double sum = (double)items
                .Where(i => i.Category == Category)
                .Sum(i => i.Cost);

            return sum * Percent / 100.0;
        }

        /// <summary>
        /// Применяет скидку (без изменения состояния)
        /// </summary>
        /// <param name="items">Список товаров</param>
        /// <returns>Размер скидки</returns>
        public double Apply(List<Item> items)
        {
            return Calculate(items);
        }

        /// <summary>
        /// Обновляет процент скидки на основе накопленной суммы покупок
        /// За каждые 1000 единиц увеличивает процент на 1
        /// </summary>
        /// <param name="items">Список товаров</param>
        public void Update(List<Item> items)
        {
            double sum = (double)items
                .Where(i => i.Category == Category)
                .Sum(i => i.Cost);

            if (sum == 0) return;

            _totalSpent += sum;

            int newPercent = 1 + (int)(_totalSpent / 1000);

            Percent = newPercent;
        }

        /// <summary>
        /// Возвращает строковое представление скидки
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Info;
        }

        /// <summary>
        /// Сравнивает текущий объект с другим по проценту скидки
        /// </summary>
        /// <param name="other">Другой объект скидки</param>
        /// <returns>Результат сравнения</returns>
        public int CompareTo(PercentDiscount other)
        {
            if (other == null) return 1;

            return Percent.CompareTo(other.Percent);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Представляет скидку, основанную на накопленных баллах.
    /// Баллы могут быть потрачены для получения скидки, но не более 30% от суммы заказа
    /// </summary>
    public class PointsDiscount : IDiscount, IComparable<PointsDiscount>
    {
        /// <summary>
        /// Текущее количество накопленных баллов
        /// </summary>
        private int _points;

        /// <summary>
        /// Получает текущее количество баллов (не может быть отрицательным)
        /// </summary>
        public int Points
        {
            get => _points;
            private set => _points = value < 0 ? 0 : value;
        }

        /// <summary>
        /// Получает строку с информацией о скидке
        /// </summary>
        public string Info => $"Накопительная – {Points} баллов";

        /// <summary>
        /// Вычисляет размер скидки на основе текущих баллов
        /// Максимальная скидка ограничена 30% от общей стоимости товаров
        /// </summary>
        /// <param name="items">Список товаров</param>
        /// <returns>Размер сктдки</returns>
        public double Calculate(List<Item> items)
        {
            double total = (double)items.Sum(i => i.Cost); //Можно ли так явно преобразовывать?
            double maxDiscount = total * 0.3;

            return Math.Min(Points, maxDiscount);
        }

        /// <summary>
        /// Применяет скидку и списывает соответствующее количество баллов
        /// </summary>
        /// <param name="items">Список товаров</param>
        /// <returns>Фактическая примененная скикда</returns>
        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);

            Points -= (int)Math.Ceiling(discount);

            return discount;
        }

        /// <summary>
        /// Обновляет количество баллов на основе суммы покупки
        /// Начисляется 10% от стоимости заказа (округление вверх)
        /// </summary>
        /// <param name="items">Список товаров</param>
        public void Update(List<Item> items)
        {
            double total = (double)items.Sum(i => i.Cost);

            int earnedPoints = (int)Math.Ceiling(total * 0.1);
            Points += earnedPoints;
        }

        /// <summary>
        /// Возвращает строковое представление скидки
        /// </summary>
        public override string ToString()
        {
            return Info;
        }

        /// <summary>
        /// Сравнивает текущий объект с другим по количеству баллов
        /// </summary>
        /// <param name="other">Другой объект скидки</param>
        /// Положительное число, если текущий объект больше;
        /// отрицательное — если меньше;
        /// 0 — если равны
        /// <returns></returns>
        public int CompareTo(PointsDiscount other)
        {
            if (other == null) return 1;

            return Points.CompareTo(other.Points);
        }
    }
}

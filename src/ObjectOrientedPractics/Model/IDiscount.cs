using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Интерфейс для всех типов скидок
    /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// Возвращает информацию о скидке
        /// </summary>
        string Info { get; }

        /// <summary>
        /// Рассчитывает размер скидки без её применения
        /// </summary>
        double Calculate(List<Item> items);

        /// <summary>
        /// Применяет скидку и возвращает её размер
        /// </summary>
        double Apply(List<Item> items);

        /// <summary>
        /// Обновляет состояние скидки после покупки
        /// </summary>
        void Update(List<Item> items);
    }
}

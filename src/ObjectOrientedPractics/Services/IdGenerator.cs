using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс для генерации идентификатора
    /// </summary>
    public static class IdGenerator
    {
        /// <summary>
        /// Установлено начальное значение
        /// </summary>
        private static int _itemId = 1;
        private static int _customerId = 1;
        private static int _orderId = 0;

        /// <summary>
        /// Счет айди товара
        /// </summary>
        /// <returns>Следующее значение будет на 1 больше</returns>
        public static int GetNextIdItem()
        {
            return _itemId++;
        }

        /// <summary>
        /// Счет айди покупателя
        /// </summary>
        /// <returns>Следующее значение будет на 1 больше</returns>
        public static int GetNextIdCustomer()
        {
            return _customerId++;
        }

        /// <summary>
        /// Счет айди заказов
        /// </summary>
        /// <returns>Следующее значение будет на 1 больше</returns>
        public static int GetNextIdOrder()
        {
            return _orderId++;
        }
    }
}

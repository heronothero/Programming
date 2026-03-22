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
        /// Установлено начальное значение в качестве единицы
        /// </summary>
        private static int _itemId = 1;

        private static int _customerId = 1;

        /// <summary>
        /// Счет айди товара
        /// </summary>
        /// <returns>next id will be 1 more</returns>
        public static int GetNextIdItem()
        {
            return _itemId++;
        }

        /// <summary>
        /// Счет айди покупателя
        /// </summary>
        /// <returns></returns>
        public static int GetNextIdCustomer()
        {
            return _customerId++;
        }
    }
}

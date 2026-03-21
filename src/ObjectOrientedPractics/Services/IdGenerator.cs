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
        private static int _currentId = 1;

        /// <summary>
        /// Счет айди
        /// </summary>
        /// <returns>next id will be 1 more</returns>
        public static int GetNextId()
        {
            return _currentId++;
        }
    }
}

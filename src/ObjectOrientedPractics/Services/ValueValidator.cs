using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Создание класса обработки значений
    /// </summary>
    public static class ValueValidator
    {
        /// <summary>
        /// Установка значений для переменной
        /// </summary>
        /// <param name="value">Значение переменной</param>
        /// <param name="maxLength">Максимальная длинна, разрешенная условием</param>
        /// <param name="propertyName">Имя переменной</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertStringOnLength (string value, int maxLength, string propertyName)
        {
            if (value == null)
                throw new ArgumentException($"{propertyName} не может быть null.");

            if (value.Length > maxLength)
                throw new ArgumentException($"{propertyName} должен быть не длиннее {maxLength} символов.");
        }
    }
}

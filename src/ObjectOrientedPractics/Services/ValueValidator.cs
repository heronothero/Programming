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
        /// <exception cref="ArgumentException">Выбрасывается, если значение не удовлетворяет условиям</exception>
        public static void AssertStringOnLength (string value, int maxLength, string propertyName)
        {
            if (value == null)
                throw new ArgumentException($"{propertyName} не может быть null.");

            if (value.Length > maxLength)
                throw new ArgumentException($"{propertyName} должен быть не длиннее {maxLength} символов.");
        }

        /// <summary>
        /// Установка численных значений для переменной
        /// </summary>
        /// <typeparam name="T">Тип числа (должен реализовывать IComparable)</typeparam>
        /// <param name="value">Значение переменной</param>
        /// <param name="min">Минимальное разрешенное значение</param>
        /// <param name="max">Максимальное разрешенное значение</param>
        /// <param name="propertyName">Имя переменной</param>
        /// <exception cref="ArgumentOutOfRangeException">Выбрасывается, если значение не удовлетворяет условиям</exception>
        public static void AssertNumberInRange<T>(T value, T min, T max, string propertyName) where T : IComparable<T>
        {
            if (value.CompareTo(min) < 0 || value.CompareTo(max) > 0)
            {
                throw new ArgumentOutOfRangeException(propertyName, value,
                    $"{propertyName} должен быть в диапазоне от {min} до {max}.");
            }
        }
    }
}

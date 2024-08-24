using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Значение свойства {propertyName} должно быть положительным");
            }
        }
        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Значение свойства {propertyName} должно быть положительным");
            }
        }
        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Значение свойства {propertyName} должно находиться в диапазоне от {min} до {max}");
            }
        }
        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Значение свойства {propertyName} должно находиться в диапазоне от {min} до {max}");
            }
        }
        public static void AssertValueLength(int value, int max, string propetyName)
        {
            value = value.ToString().Length;
            if (value != max)
            {
                throw new ArgumentException($"Значение свойства {propetyName} должно содержать {max} символов");
            }
        }
    }
}

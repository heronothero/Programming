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
                throw new ArgumentException($"{propertyName} must be positive");
            }
        }
        public static double AssertOnPositiveValue(double value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{propertyName} must be positive");
            }
            return value;
        }
        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"{propertyName} must be in range {min}-{max}");
            }
        }
        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"{propertyName} must be in range {min}-{max}");
            }
        }
        public static void AssertValueLength(int value, int max, string propetyName)
        {
            value = value.ToString().Length;
            if (value != max)
            {
                throw new ArgumentException($"{propetyName} must contain {max} symbols");
            }
        }
        public static void AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"{propertyName} can not be null or empty");
            }
            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                {
                    throw new ArgumentException($"{propertyName} must contain only letters");
                }
            }
        }
        public static double ValidateCoordinate(double value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{propertyName} can't be negative");
            }
            const double MaxCoordinate = 1000.0;
            if (value > MaxCoordinate)
            {
                throw new ArgumentException($"{propertyName} can't exceed {MaxCoordinate}");
            }
            return value;
        }
    }
}

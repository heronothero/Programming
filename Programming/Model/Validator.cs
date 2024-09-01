using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public static class Validator
    {
        /// <summary>
        /// A function for checking a value for a positive int value
        /// </summary>
        /// <param name="value"> The (int) value which should be checked </param>
        /// <param name="propertyName"> The name of the checking value </param>
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{propertyName} must be positive");
            }
        }

        /// <summary>
        /// A function for checking a value for a positive double value
        /// </summary>
        /// <param name="value"> The (double) value which should be checked </param>
        /// <param name="propertyName"> The name of the checking value </param>
        /// <returns></returns>
        public static double AssertOnPositiveValue(double value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{propertyName} must be positive");
            }
            return value;
        }

        /// <summary>
        /// A function for checking int value to be in range int min value and int max value
        /// </summary>
        /// <param name="value"> The (int) value which should be checked </param>
        /// <param name="min"> The start point of range </param>
        /// <param name="max"> The end point of range </param>
        /// <param name="propertyName"> The name of the checking value </param>
        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"{propertyName} must be in range {min}-{max}");
            }
        }

        /// <summary>
        /// A function for checking double value to be in range double min value and double max value
        /// </summary>
        /// <param name="value"> The (double) value which should be checked </param>
        /// <param name="min"> The start point of range </param>
        /// <param name="max"> The end point of range </param>
        /// <param name="propertyName"> The name of the checking value </param>
        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"{propertyName} must be in range {min}-{max}");
            }
        }

        /// <summary>
        /// A function for cheking value's symbols length
        /// </summary>
        /// <param name="value"> The (int) value which should be checked </param>
        /// <param name="max"> A number of value's symbols length which must be equal </param>
        /// <param name="propetyName"> The name of the checking value </param>
        public static void AssertValueLength(int value, int max, string propetyName)
        {
            value = value.ToString().Length;
            if (value != max)
            {
                throw new ArgumentException($"{propetyName} must contain {max} symbols");
            }
        }

        /// <summary>
        /// A function for checking that value contains only letters
        /// </summary>
        /// <param name="value"> The (string) value which should be checked </param>
        /// <param name="propertyName"> The name of the checking value </param>
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

        /// <summary>
        /// A function for checking whether coordinates are valide or not
        /// </summary>
        /// <param name="value"> The (double) value which should be checked </param>
        /// <param name="propertyName"> The name of the checking value </param>
        /// <returns> Returns value if it's positive and less than 1000 </returns>
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

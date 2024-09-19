using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksListApp.Model
{
    public static class Validator
    {
        /// <summary>
        /// A function for checking int value to be in range int min value and int max value.
        /// </summary>
        /// <param name="value"> The (int) value which should be checked. </param>
        /// <param name="min"> The start point of range. </param>
        /// <param name="max"> The end point of range. </param>
        /// <param name="propertyName"> The name of the checking value. </param>
        public static void AssertValueInRange(string value, int min, int max, string propertyName)
        {
            if (value.Length < min || value.Length > max)
            {
                throw new ArgumentException($"{propertyName} must be between {min} and {max}");
            }
        }

        /// <summary>
        /// A function for checking that value contains only letters.
        /// </summary>
        /// <param name="value"> The (string) value which should be checked. </param>
        /// <param name="propertyName"> The name of the checking value. </param>
        public static void AssertValueContainsOnlyLetters(string value, string propertyName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"{propertyName} can not be null or empty");
            }
            foreach (char c in value)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    throw new ArgumentException($"{propertyName} must contain only letters");
                }
            }
        }

        /// <summary>
        /// A function for cheking value's symbols length.
        /// </summary>
        /// <param name="value"> The (int) value which should be checked. </param>
        /// <param name="max"> A number of value's symbols length which must be equal. </param>
        /// <param name="propetyName"> The name of the checking value. </param>
        public static void AssertValueLength(int value, int max, string propetyName)
        {
            value = value.ToString().Length;
            if (value != max)
            {
                throw new ArgumentException($"{propetyName} must contain {max} symbols");
            }
        }

        /// <summary>
        /// A function for checking a value for a positive int value.
        /// </summary>
        /// <param name="value"> The (int) value which should be checked. </param>
        /// <param name="propertyName"> The name of the checking value. </param>
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{propertyName} must be positive");
            }
        }

        /// <summary>
        /// A function for checking a value in range.
        /// </summary>
        /// <param name="value"> The (int) value which should be checked. </param>
        /// <param name="minYear"> The min value. </param>
        /// <param name="currentYear"> The max value. </param>
        /// <param name="propertyName"> The name of the checking value. </param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertReleaseYear(int value, int  minYear, int currentYear, string propertyName)
        {
            currentYear = DateTime.Now.Year;
            if (value > currentYear || value < minYear)
            {
                throw new ArgumentException($"{propertyName} must be between {minYear} and {currentYear}");
            }
        }

        /// <summary>
        /// A function for checking a field
        /// </summary>
        /// <param name="value"> The (obj) value which should be checked. </param>
        /// <param name="propertyName"> The name of the value. </param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertGenre(object value, string propertyName)
        {
            if (value == null)
            {
                throw new ArgumentException($"{propertyName} can't be null");
            }
        }
    }
}

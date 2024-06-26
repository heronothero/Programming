using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Contact
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                AssertStringContainsOnlyLetters(value, "Name");
                name = value;
            }
        }

        private string surname;
        public string Surname
        {
            get { return surname; }
            set
            {
                AssertStringContainsOnlyLetters(value, "Surname");
                surname = value;
            }
        }
        private string phoneNumber;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (value.Length != 11)
                {
                    throw new ArgumentException("Номер телефона должен быть длиной 11 символов.");
                }
                phoneNumber = value;
            }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                if (!value.Contains("@"))
                {
                    throw new ArgumentException("Некорректный формат адреса электронной почты.");
                }
                email = value;
            }
        }
        private string organization;
        public string Organization
        {
            get { return organization; }
            set { organization = value; }
        }
        public Contact()
        {
            Name = "";
            Surname = "";
            PhoneNumber = "";
            Email = "";
            Organization = "";
        }

        public Contact(string name, string surname, string phoneNumber, string email, string organization)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            Email = email;
            Organization = organization;
        }

        private void AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"Значение свойства {propertyName} не может быть пустым.");
            }

            foreach (char c in value)
            {
                if (!char.IsLetter(c) || !char.IsLetter(c))
                {
                    throw new ArgumentException($"Значение свойства {propertyName} должно содержать только буквы английского алфавита.");
                }
            }
        }
    }
}

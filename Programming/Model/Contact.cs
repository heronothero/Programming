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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Имя контакта не может быть пустым.");
                }
                name = value;
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
            PhoneNumber = "";
            Email = "";
            Organization = "";
        }
        public Contact(string name, string phoneNumber, string email, string organization)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
            Organization = organization;
        }
    }
}

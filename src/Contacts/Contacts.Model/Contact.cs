using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Model
{
    public class Contact : IDataErrorInfo
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Error => null;

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Contact() { }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="phone">Номер телефона</param>
        /// <param name="email">Электронная почта</param>
        public Contact(string name, string phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }

        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case "Name":
                        if (Name?.Length > 100)
                            return "Name не более 100 символов";
                        if (Name == null)
                            return "Name не может быть пустым";
                        break;

                    case "Phone":
                        if (Phone?.Length > 100)
                            return "Телефон не более 100 символов";
                        if (!System.Text.RegularExpressions.Regex.IsMatch(Phone ?? "",
                            @"^[0-9+\-() ]*$"))
                            return "Только цифры и +-()";
                        if (Phone == null)
                            return "Телефон не может быть пустым";
                        break;

                    case "Email":
                        if (Email?.Length > 100)
                            return "Email не более 100 символов";
                        if (Email == null || !Email.Contains("@"))
                            return "Email должен содержать @";
                        if (Email == null)
                            return "Email не должен быть пустым";
                        break;
                }

                return null;
            }
        }
    }
}

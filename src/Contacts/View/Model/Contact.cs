using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    public class Contact
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

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
    }
}

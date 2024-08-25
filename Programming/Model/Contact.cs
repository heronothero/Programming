using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Contact
    {
        private int phoneNumber;
        private string contactName;
        public string ContactName 
        { 
            get { return contactName; }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, "ContactName");
                contactName = value;
            }
        }
        public int PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                Validator.AssertValueLength(value, 11, "PhoneNumber");
                phoneNumber = value;
            }
        }
        public string Organization { get; set; }
        private string surname;
        public string Surname 
        { 
            get { return surname; }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, "Surname");
                surname = value;
            }
        }
        public Contact(string contactName, string surname, int phoneNumber, string organization)
        {
            ContactName = contactName;
            Surname = surname;
            PhoneNumber = phoneNumber;
            Organization = organization;
        }
    }
}

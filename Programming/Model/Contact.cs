using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Contact
    {
        /// <summary>
        /// A private property of phone number
        /// </summary>
        private int phoneNumber;

        /// <summary>
        /// A private property of contact name
        /// </summary>
        private string contactName;

        /// <summary>
        /// Checking contact name's field which must contain only letters
        /// </summary>
        public string ContactName 
        { 
            get { return contactName; }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, "ContactName");
                contactName = value;
            }
        }

        /// <summary>
        /// Checking phone number's field which must be int and contain only 11 numbers
        /// </summary>
        public int PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                Validator.AssertValueLength(value, 11, "PhoneNumber");
                phoneNumber = value;
            }
        }

        /// <summary>
        /// A public property of organization
        /// </summary>
        public string Organization { get; set; }

        /// <summary>
        /// A private property of surname
        /// </summary>
        private string surname;

        /// <summary>
        /// Checling surname's field which must contain only letters
        /// </summary>
        public string Surname 
        { 
            get { return surname; }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, "Surname");
                surname = value;
            }
        }

        /// <summary>
        /// Contact's constructor
        /// </summary>
        /// <param name="contactName"> The field must contain only letters </param>
        /// <param name="surname"> The field must contain only letters </param>
        /// <param name="phoneNumber"> The field contain only 11 numbers </param>
        /// <param name="organization"> The field can contain letters and numbers </param>
        public Contact(string contactName, string surname, int phoneNumber, string organization)
        {
            ContactName = contactName;
            Surname = surname;
            PhoneNumber = phoneNumber;
            Organization = organization;
        }
    }
}

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
        public string ContactName { get; set; }
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
        public Contact(string contactName, int phoneNumber, string organization)
        {
            ContactName = contactName;
            PhoneNumber = phoneNumber;
            Organization = organization;
        }
    }
}

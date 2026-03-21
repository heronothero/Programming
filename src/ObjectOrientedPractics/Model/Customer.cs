using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    internal class Customer
    {
        private readonly int _id;
        private string _fullName;
        private string _address;

        /// <summary>
        /// Constructor of the class
        /// </summary>
        /// <param name="id">Parametr of the unique identificator of a customer</param>
        /// <param name="fullName">Parametr of the name of a customer</param>
        /// <param name="address">Parametr of the address of a customer</param>
        public Customer(string fullName, string address)
        {
            _id = IdGenerator.GetNextId();
            FullName = fullName;
            Address = address;
        }

        /// <summary>
        /// Property of the Id
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Property of the name with limit of 200 characters
        /// </summary>
        public string FullName
        {
            get => _fullName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("The parametr can't be empty.");
                if (value.Length > 200)
                    throw new ArgumentException("The parametr must not exceed 200 symbols");
                _fullName = value;
            }
        }

        /// <summary>
        /// Property of the Address with limit of 1000 characters
        /// </summary>
        public string Address
        {
            get => _address;
            set
            {
                if (value.Length > 500)
                    throw new ArgumentException("The prametr must not exceed 500 symbols");
                _address = value;
            }
        }
    }
}

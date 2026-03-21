using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Class item
    /// </summary>
    internal class Item
    {
        private readonly int _id;
        private string _name;
        private string _info;
        private decimal _cost;

        /// <summary>
        /// Static count of the Id
        /// </summary>
        private static int _nextId = 1;

        /// <summary>
        /// Constructor of the class
        /// </summary>
        /// <param name="id">Parametr of the unique identificator of an item</param>
        /// <param name="name">Parametr of the name of an item</param>
        /// <param name="info">Parametr of info of an item</param>
        /// <param name="cost">Parametr of the cost of an item</param>
        public Item(string name, string info, decimal cost)
        {
            _id = IdGenerator.GetNextId();
            Name = name;
            Info = info;
            Cost = cost;
        }

        /// <summary>
        /// Property of the Id
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Property of the name with limit of 200 characters
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(value));
                if (value.Length > 200)
                    throw new ArgumentException("The parametr must not exceed 200 symbols");
                _name = value;
            }
        }

        /// <summary>
        /// Property of the Info with limit of 1000 characters
        /// </summary>
        public string Info
        {
            get => _info;
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(value));
                if (value.Length > 1000)
                    throw new ArgumentException("The prametr must not exceed 1000 symbols");
                _info = value;
            }
        }

        /// <summary>
        /// Property of the Cost with limit between 0 and 100000
        /// </summary>
        public decimal Cost
        {
            get => _cost;
            set
            {
                if (value < 0 || value > 100000) 
                    throw new ArgumentNullException(nameof(value), "The parametr must be between 0 and 100000");
                _cost = value;
            }
        }
    }
}

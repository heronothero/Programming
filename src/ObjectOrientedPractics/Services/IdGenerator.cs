using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Class for id
    /// </summary>
    public static class IdGenerator
    {
        /// <summary>
        /// Set a specific number
        /// </summary>
        private static int _currentId = 1;

        /// <summary>
        /// Counts id
        /// </summary>
        /// <returns>next id will be 1 more</returns>
        public static int GetNextId()
        {
            return _currentId++;
        }
    }
}

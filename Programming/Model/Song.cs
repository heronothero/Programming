using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Song
    {
        /// <summary>
        /// A private property of duration
        /// </summary>
        private double duration;

        /// <summary>
        /// A public property of the name of the song
        /// </summary>
        public string NameOfTheSong { get; set; }

        /// <summary>
        /// A public property of duration which must be positive and double
        /// </summary>
        public double Duration
        {
            get { return duration; }
            set
            {
                Validator.AssertOnPositiveValue(value, "Duration");
                duration = value;
            }
        }

        /// <summary>
        /// A public property of lyrics
        /// </summary>
        public bool Lyrics { get; set; }
    }
}

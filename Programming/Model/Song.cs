using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Song
    {
        private string nameOfTheSong;
        private double duration;
        private bool lyrics;
        public string NameOfTheSong { get; set; }
        public double Duration
        {
            get { return duration; }
            set
            {
                Validator.AssertOnPositiveValue(value, "Duration");
                duration = value;
            }
        }
        public bool Lyrics
        {
            get { return lyrics; }
            set { }
        }
    }
}

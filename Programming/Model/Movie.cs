using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Movie
    {
        public string Name { get; set; }
        private int movieTime;
        public int MovieTime 
        { 
            get { return movieTime; } 
            set
            { Validator.AssertOnPositiveValue(value, "MovieTime"); 
                movieTime = value;
            }
        }
        private int releaseYear;
        public int ReleaseYear
        {
            get { return releaseYear; }
            set
            {
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, "ReleaseYear");
                releaseYear = value;
            }
        }
        public string Genre { get; set; }
        private double rating;
        public double Rating
        {
            get { return rating; }
            set
            {
                Validator.AssertValueInRange(value, 0, 10, "Rating");
                rating = value;
            }
        }
    }
}

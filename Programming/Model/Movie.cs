using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Movie
    {
        private string nameOfTheMovie;
        private int movieTime;
        private int releaseYear;
        private string genre;
        private double rating;
        public string NameOfTheMovie{ get; set; }
        public int MovieTime
        {
            get { return movieTime; }
            set 
            {
                Validator.AssertOnPositiveValue(value, "MovieTime");
                movieTime = value;
            }
        }
        public int ReleaseYear
        {
            get { return releaseYear; }
            set 
            {
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, "ReleaseYear");
                releaseYear = value;
            }
        }
        public string Genre{ get; set; }
        public double Rating
        {
            get { return rating; }
            set 
            {
                Validator.AssertValueInRange(value, 0, 10, "Rating");
                rating = value;
            }
        }
        public Movie(string nameOfTheMovie, int movieTime, int releaseYear, string genre, double rating)
        {
            NameOfTheMovie = nameOfTheMovie;
            MovieTime = movieTime;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
        }
    }
}

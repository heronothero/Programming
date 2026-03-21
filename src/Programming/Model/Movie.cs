using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Movie
    {
        /// <summary>
        /// A private property of movie time.
        /// </summary>
        private int movieTime;

        /// <summary>
        /// A private property of release year.
        /// </summary>
        private int releaseYear;

        /// <summary>
        /// A private property of rating.
        /// </summary>
        private double rating;

        /// <summary>
        /// A public property of the name of the movie.
        /// </summary>
        public string NameOfTheMovie{ get; set; }

        /// <summary>
        /// A public property of movie time, which must be positive and int.
        /// </summary>
        public int MovieTime
        {
            get { return movieTime; }
            set 
            {
                Validator.AssertOnPositiveValue(value, "MovieTime");
                movieTime = value;
            }
        }

        /// <summary>
        /// A public property of release year which must be int in range of 1900 and current year.
        /// </summary>
        public int ReleaseYear
        {
            get { return releaseYear; }
            set 
            {
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, "ReleaseYear");
                releaseYear = value;
            }
        }

        /// <summary>
        /// A public property of genre.
        /// </summary>
        public string Genre{ get; set; }

        /// <summary>
        /// A public property of rating which must be in range of 0 and 10 and double.
        /// </summary>
        public double Rating
        {
            get { return rating; }
            set 
            {
                Validator.AssertValueInRange(value, 0, 10, "Rating");
                rating = value;
            }
        }

        /// <summary>
        /// A movie's constructor.
        /// </summary>
        /// <param name="nameOfTheMovie"> The field can contain letters and numbers. </param>
        /// <param name="movieTime"> The field must be positive and int. </param>
        /// <param name="releaseYear"> The field must be a date in range. </param>
        /// <param name="genre"> The field can contain letters and numbers. </param>
        /// <param name="rating"> The field must be positive and double. </param>
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

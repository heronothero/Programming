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
        public int MovieTime { get; set; }
        private int releaseYear;
        public int ReleaseYear
        {
            get { return releaseYear; }
            set
            {
                int CurrentTime = DateTime.Now.Year;
                if (value > CurrentTime || value < 1900)
                {
                    throw new ArgumentException("Год выпуска должен быть от 1900 до текущего года");
                }
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
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Рейтинг должен быть от 0 до 10");
                }
                rating = value;
            }
        }
    }
}

using Programming.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class MoviesControl : UserControl
    {
        /// <summary>
        /// A private property of array of movies.
        /// </summary>
        private Movie[] _movies;

        /// <summary>
        /// A private property of a current movie.
        /// </summary>
        private Movie _currentMovie;

        /// <summary>
        /// Initialazing components.
        /// </summary>
        public MoviesControl()
        {
            InitializeComponent();
            InitializeMovies();
        }

        /// <summary>
        /// A list of movies which must be >= 0 and less it's array's length.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void moviesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (moviesBox.SelectedIndex >= 0 && moviesBox.SelectedIndex < _movies.Length)
            {
                _currentMovie = _movies[moviesBox.SelectedIndex];
                UpdateMovieFields();
            }
        }

        /// <summary>
        /// The field of the name of the movie.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void movieNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// The field of the duration of the movie.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void movieTimeBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// The field of the release year of the movie.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void releaseYearBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// The field of genre of the movie.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void genreBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// The field of the rating of the movie.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ratingBox_TextChanged(object sender, EventArgs e)
        {

        }
        
        /// <summary>
        /// A function of finding a movie with max rating.
        /// </summary>
        /// <param name="movies"> An array of movies. </param>
        /// <returns> Returns max index of the movie with high rating. </returns>
        private int FindMovieWithMaxRating(Movie[] movies)
        {
            if (movies == null || movies.Length == 0)
            {
                throw new ArgumentException("The list of movies is null or equal null");
            }
            int maxIndex = 0;
            double maxRating = movies[0].Rating;
            for (int i = 1; i < movies.Length; i++)
            {
                if (movies[i].Rating > maxRating)
                {
                    maxRating = movies[i].Rating;
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        /// <summary>
        /// A button of finding a movie with high rating (function).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void movieRatingButton_Click(object sender, EventArgs e)
        {
            try
            {
                int maxIndex = FindMovieWithMaxRating(_movies);
                moviesBox.SelectedIndex = maxIndex;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// An array of movies filled manually.
        /// </summary>
        private void InitializeMovies()
        {
            _movies = new Movie[]
            {
                new Movie("Inception", 148, 2010, "Sci-Fi", 8.8),
                new Movie("The Dark Knight", 152, 2008, "Action", 9.0),
                new Movie("Interstellar", 169, 2014, "Sci-Fi", 8.6),
                new Movie("The Shawshank Redemption", 142, 1994, "Drama", 9.3),
                new Movie("Fight Club", 139, 1999, "Drama", 8.8)
            };
            foreach (var movie in _movies)
            {
                moviesBox.Items.Add(movie.NameOfTheMovie);
            }
        }

        /// <summary>
        /// A function of updating fields of a current movie.
        /// </summary>
        private void UpdateMovieFields()
        {
            if (_currentMovie != null)
            {
                movieNameBox.Text = _currentMovie.NameOfTheMovie;
                movieTimeBox.Text = _currentMovie.MovieTime.ToString();
                releaseYearBox.Text = _currentMovie.ReleaseYear.ToString();
                genreBox.Text = _currentMovie.Genre;
                ratingBox.Text = _currentMovie.Rating.ToString();
            }
        }
    }
}

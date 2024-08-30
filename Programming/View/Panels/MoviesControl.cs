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
        private Movie[] _movies;
        private Movie _currentMovie;
        public MoviesControl()
        {
            InitializeComponent();
            InitializeMovies();
        }

        private void moviesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (moviesBox.SelectedIndex >= 0 && moviesBox.SelectedIndex < _movies.Length)
            {
                _currentMovie = _movies[moviesBox.SelectedIndex];
                UpdateMovieFields();
            }
        }

        private void movieNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void movieTimeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void releaseYearBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void genreBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ratingBox_TextChanged(object sender, EventArgs e)
        {

        }

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

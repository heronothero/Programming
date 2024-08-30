using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model;
using Programming.Model.Geometry;

namespace Programming
{
    public partial class MainForm : Form
    {
        private Model.Rectangle[] _rectangles;
        private Model.Rectangle _currentRectangle;
        private Ring[] _rings;
        private Ring _currentRing;
        private Random random = new Random();
        private Movie[] _movies;
        private Movie _currentMovie;
        public MainForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            centerXBox.KeyPress += centerBox_KeyPress;
            centerYBox.KeyPress += centerBox_KeyPress; 
            idBox.ReadOnly = true;
            collisionRectanglesBox.ReadOnly = true;
            collisionRingsBox.ReadOnly = true;
            InitializeRectangles();
            UpdateFields();
            InitializeMovies();
            InitializeRings();
            UpdateRingFields();

        }

        private void MainForm_Load(object sender, EventArgs e)
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

        private void moviesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (moviesBox.SelectedIndex >= 0 && moviesBox.SelectedIndex < _movies.Length)
            {
                _currentMovie = _movies[moviesBox.SelectedIndex];
                UpdateMovieFields();
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

        private void InitializeRectangles()
        {
            _rectangles = new Model.Rectangle[5];
            for (int i = 0; i < 5; i++)
            {
                double length = random.NextDouble() * 100;
                double width = random.NextDouble() * 100;
                string color = GetRandomColor();
                Point2D center = new Point2D(random.NextDouble() * 100, random.NextDouble() * 100);
                _rectangles[i] = new Model.Rectangle(length, width, color, center);
                RectanglesBox.Items.Add($"Прямоугольник {i + 1}");
            }
            if (_rectangles.Length > 0)
            {
                _currentRectangle = _rectangles[0];
            }
        }

        private string GetRandomColor()
        {
            string[] availableColors = { "blue", "red", "green", "yellow", "black", "white" };
            return availableColors[random.Next(availableColors.Length)];
        }

        private void UpdateFields()
        {
            widthBox.Text = _currentRectangle.Width.ToString();
            lengthBox.Text = _currentRectangle.Length.ToString();
            centerXBox.Text = _currentRectangle.Center.X.ToString();
            centerYBox.Text = _currentRectangle.Center.Y.ToString();
            colorBox.Text = _currentRectangle.Color;
            idBox.Text = _currentRectangle.ID.ToString();
        }

        private void RectanglesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = RectanglesBox.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex <= _rectangles.Length)
            {
                _currentRectangle = _rectangles[selectedIndex];
                UpdateFields();
            }
            StringBuilder collisionResults = new StringBuilder();
            for (int i = 0; i < _rectangles.Length; i++)
            {
                if (i != selectedIndex)
                {
                    bool isCollision = CollisionManager.IsCollisionRectangles(_currentRectangle, _rectangles[i]);
                    collisionResults.AppendLine($"Rectangle {selectedIndex + 1} vs Rectangle {i + 1}: {isCollision}");
                }
            }
            collisionRectanglesBox.Text = collisionResults.ToString();
        }

        private void lengthBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                TextBox textBox = (TextBox)sender;
                string text = textBox.Text.Trim();
                try
                {
                    if (double.TryParse(text, out double length))
                    {
                        _currentRectangle.Length = length;
                        textBox.BackColor = SystemColors.Window;
                    }
                    else
                    {
                        textBox.BackColor = Color.LightPink;
                    }
                }
                catch (FormatException)
                {
                    textBox.BackColor = Color.LightPink;
                }
                catch (ArgumentOutOfRangeException)
                {
                    textBox.BackColor = Color.LightPink;
                }
            }
        }

        private void widthBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                TextBox textBox = (TextBox)sender;
                string text = textBox.Text.Trim();
                try
                {
                    if (double.TryParse(text, out double width))
                    {
                        _currentRectangle.Width = width;
                        textBox.BackColor = SystemColors.Window;
                    }
                    else
                    {
                        textBox.BackColor = Color.LightPink;
                    }
                }
                catch (FormatException)
                {
                    textBox.BackColor = Color.LightPink;
                }
                catch (ArgumentOutOfRangeException)
                {
                    textBox.BackColor = Color.LightPink;
                }
            }
        }

        private void centerBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void centerXBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                TextBox textBox = (TextBox)sender;
                string text = textBox.Text.Trim();
                try
                {
                    if (double.TryParse(text, out double centerX))
                    {
                        _currentRectangle.SetCenter(centerX, _currentRectangle.Center.Y);
                        textBox.BackColor = SystemColors.Window;
                    }
                    else
                    {
                        textBox.BackColor = Color.LightPink;
                    }
                }
                catch (FormatException)
                {
                    textBox.BackColor = Color.LightPink;
                }
                catch (ArgumentOutOfRangeException)
                {
                    textBox.BackColor = Color.LightPink;
                }
            }
        }

        private void centerYBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                TextBox textBox = (TextBox)sender;
                string text = textBox.Text.Trim();
                try
                {
                    if (double.TryParse(text, out double centerY))
                    {
                        _currentRectangle.SetCenter(_currentRectangle.Center.X, centerY);
                        textBox.BackColor = SystemColors.Window;
                    }
                    else
                    {
                        textBox.BackColor = Color.LightPink;
                    }
                }
                catch (FormatException)
                {
                    textBox.BackColor = Color.LightPink;
                }
                catch (ArgumentOutOfRangeException)
                {
                    textBox.BackColor = Color.LightPink;
                }
            }
        }

        private void colorBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                _currentRectangle.Color = colorBox.Text;
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            try
            {
                int maxIndex = FindRectangleWithMaxWidth(_rectangles);
                RectanglesBox.SelectedIndex = maxIndex;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int FindRectangleWithMaxWidth(Model.Rectangle[] rectangles)
        {
            if (rectangles == null || rectangles.Length == 0)
            {
                throw new ArgumentException("The array of rectangles is null or equal null");
            }
            int maxIndex = 0;
            double maxWidth = rectangles[0].Width;
            for (int i = 1; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        private void InitializeRings()
        {
            _rings = new Ring[5];
            for (int i = 0; i < _rings.Length; i++)
            {
                double innerRadius = random.NextDouble() * 50;
                double outerRadius = innerRadius + random.NextDouble() * 50;
                Point2D center = new Point2D(random.Next(0, 100), random.Next(0, 100));
                _rings[i] = new Ring(center, innerRadius, outerRadius);
                ringsBox.Items.Add($"Кольцо {i + 1}");
            }
            if (_rings.Length > 0)
            {
                _currentRing = _rings[0];
                UpdateRingFields();
            }
        }

        private void UpdateRingFields()
        {
            if (_currentRing != null)
            {
                innerRadiusBox.Text = _currentRing.InnerRadius.ToString();
                outerRadiusBox.Text = _currentRing.OuterRadius.ToString();
                areaBox.Text = _currentRing.Area.ToString("F2");
            }
        }

        private void ringsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ringsBox.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < _rings.Length)
            {
                _currentRing = _rings[selectedIndex];
                UpdateRingFields();
            }
            StringBuilder collisionResults = new StringBuilder();
            for (int i = 0; i < _rings.Length; i++)
            {
                if (i != selectedIndex)
                {
                    bool isCollision = CollisionManager.IsCollisionRings(_currentRing, _rings[i]);
                    collisionResults.AppendLine($"Ring {selectedIndex + 1} vs Ring {i + 1}: {isCollision}");
                }
            }
            collisionRingsBox.Text = collisionResults.ToString();
        }

        private void innerRadiusBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void outerRadiusBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void areaBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void collisionRectanglesBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesBox.SelectedIndex >= 0)
            {
                int selectedIndex = RectanglesBox.SelectedIndex;
                if (selectedIndex < _rectangles.Length - 1)
                {
                    Model.Rectangle rectangle1 = _rectangles[selectedIndex];
                    Model.Rectangle rectangle2 = _rectangles[selectedIndex + 1];
                    bool isCollision = CollisionManager.IsCollisionRectangles(rectangle1, rectangle2);
                    collisionRectanglesBox.Text = isCollision ? "Collision Detected" : "No Collision";
                }
            }
        }

        private void collisionRingsBox_TextChanged(object sender, EventArgs e)
        {
            if (ringsBox.SelectedIndex >= 0)
            {
                int selectedIndex = ringsBox.SelectedIndex;
                if (selectedIndex < _rings.Length - 1)
                {
                    Ring ring1 = _rings[selectedIndex];
                    Ring ring2 = _rings[selectedIndex + 1];
                    bool isCollision = CollisionManager.IsCollisionRings(ring1, ring2);
                    collisionRingsBox.Text = isCollision ? "Collision Detected" : "No Collision";
                }
            }
        }
    }
}

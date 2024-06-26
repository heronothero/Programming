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

namespace Programming
{
    public partial class MainForm : Form
    {
        private Dictionary<string, Type> enumTypes;
        private Programming.Model.Rectangle[] _rectangles;
        private Programming.Model.Rectangle _currentRectangle;
        private Random random = new Random();
        private Movie[] _movies;
        private Movie _currentMovie;

        public MainForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            enumTypes = new Dictionary<string, Type>();
            SeasonComboBox.Items.Add(Programming.Model.Enums.Season.Winter);
            SeasonComboBox.Items.Add(Programming.Model.Enums.Season.Spring);
            SeasonComboBox.Items.Add(Programming.Model.Enums.Season.Summer);
            SeasonComboBox.Items.Add(Programming.Model.Enums.Season.Autumn);
            SeasonComboBox.SelectedIndex = 0;
            _rectangles = new Programming.Model.Rectangle[5];
            for (int i = 0; i < 5; i++)
            {
                double width = random.NextDouble() * 100;
                double length = random.NextDouble() * 100;
                string color = GetRandomColor();
                _rectangles[i] = new Programming.Model.Rectangle(width, length, color);
                RectanglesListBox.Items.Add($"Прямоугольник {i + 1}");
            }
            if (_rectangles.Length > 0)
            {
                _currentRectangle = _rectangles[0];
                UpdateFields();
            }
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            InitializeMovies();
            foreach (var movie in _movies)
            {
                MoviesListBox.Items.Add(movie.Name);
            }
        }
        private string GetRandomColor()
        {
            string[] availableColors = { "blue", "red", "green", "yellow", "black", "white" };
            return availableColors[random.Next(availableColors.Length)];
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            enumTypes.Add("Colours", typeof(Model.Enums.Colours));
            enumTypes.Add("Form Of Education", typeof(Model.Enums.FormOfEducation));
            enumTypes.Add("Genre", typeof(Model.Enums.Genre));
            enumTypes.Add("Season", typeof(Model.Enums.Season));
            enumTypes.Add("Smartphone Manufacturers", typeof(Model.Enums.SmartphoneManufacturers));
            enumTypes.Add("Weekday", typeof(Model.Enums.Weekday));
            EnumListBox.DataSource = new List<string>(enumTypes.Keys);
        }

        private void EnumPage1_Click(object sender, EventArgs e)
        {

        }

        private void EnumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnumListValues.Items.Clear();
            if (EnumListBox.SelectedItem != null && enumTypes.TryGetValue(EnumListBox.SelectedItem.ToString(), out Type selectedEnum))
            {
                var enumValues = Enum.GetValues(selectedEnum);
                foreach (var value in enumValues)
                {
                    EnumListValues.Items.Add(value);
                }
            }
        }

        private void EnumListValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EnumListValues != null)
            {
                int ValueAsInt = EnumListValues.SelectedIndex;
                InputValue.Text = ValueAsInt.ToString();
            }
        }

        private void InputValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void WeekdayInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResultLabel_Click(object sender, EventArgs e)
        {
            ResultLabel.Text = "";
        }

        private void SeasonComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSeason = SeasonComboBox.SelectedItem.ToString();
        }

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            if (SeasonComboBox.SelectedItem != null && SeasonComboBox.SelectedItem is Programming.Model.Enums.Season selectedSeason)
            {
                switch (selectedSeason)
                {
                    case Programming.Model.Enums.Season.Winter:
                        MessageBox.Show("Бррр! Холодно!");
                        break;
                    case Programming.Model.Enums.Season.Spring:
                        this.BackColor = System.Drawing.Color.LightGreen;
                        break;
                    case Programming.Model.Enums.Season.Summer:
                        MessageBox.Show("Ура! Солнце!");
                        break;
                    case Programming.Model.Enums.Season.Autumn:
                        this.BackColor = System.Drawing.Color.Orange;
                        break;
                    default:
                        this.BackColor = System.Drawing.SystemColors.Control;
                        break;
                }
            }
            else
            {
                MessageBox.Show("Выберите сезон из списка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
    }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            string inputText = WeekdayInput.Text.Trim();
            if (!string.IsNullOrEmpty(inputText))
            {
                if (Enum.TryParse(inputText, true, out DayOfWeek parsedDay))
                {
                    int dayIndex = ((int)parsedDay + 6) % 7 + 1;
                    ResultLabel.Text = $"Это день недели ({parsedDay.ToString()} = {dayIndex})";
                }
                else
                {
                    ResultLabel.Text = "Такого дня недели не существует";
                }
            }
            else
            {
                ResultLabel.Text = "Ошибка: введите день недели";
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = RectanglesListBox.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < _rectangles.Length)
            {
                _currentRectangle = _rectangles[selectedIndex];
                UpdateFields();
            }
        }

        private void UpdateFields()
        {
            WidthInput.Text = _currentRectangle.Width.ToString();
            LengthInput.Text = _currentRectangle.Length.ToString();
            ColorInput.Text = _currentRectangle.Color;
        }

        private void LengthInput_TextChanged(object sender, EventArgs e)
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
                        textBox.BackColor = System.Drawing.SystemColors.Window;
                    }
                    else
                    {
                        textBox.BackColor = System.Drawing.Color.LightPink;
                    }
                }
                catch (FormatException)
                {
                    textBox.BackColor = System.Drawing.Color.LightPink;
                }
                catch (ArgumentOutOfRangeException)
                {
                    textBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
        }

        private void WidthInput_TextChanged(object sender, EventArgs e)
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
                        textBox.BackColor = System.Drawing.SystemColors.Window;
                    }
                    else
                    {
                        textBox.BackColor = System.Drawing.Color.LightPink;
                    }
                }
                catch (FormatException)
                {
                    textBox.BackColor = System.Drawing.Color.LightPink;
                }
                catch (ArgumentOutOfRangeException)
                {
                    textBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
        }

        private void ColorInput_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                _currentRectangle.Color = ColorInput.Text;
            }
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            try
            {
                int maxIndex = FindRectangleWithMaxWidth(_rectangles);
                RectanglesListBox.SelectedIndex = maxIndex;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int FindRectangleWithMaxWidth(Model.Rectangle[] rectangles)
        {
            if (rectangles == null || rectangles.Length == 0)
            {
                throw new ArgumentException("Массив прямоугольников пуст или равен null.");
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

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedIndex >= 0 && MoviesListBox.SelectedIndex < _movies.Length)
            {
                _currentMovie = _movies[MoviesListBox.SelectedIndex];
                UpdateMovieFields();
            }
        }

        private void NameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void MovieTimeInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReleaseYearInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenreInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void RatingInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void FindFilmButton_Click(object sender, EventArgs e)
        {
            try
            {
                int maxRatingIndex = FindMovieWithMaxRating();
                MoviesListBox.SelectedIndex = maxRatingIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InitializeMovies()
        {
            _movies = new Movie[]
            {
                new Movie { Name = "Inception", MovieTime = 148, ReleaseYear = 2010, Genre = "Sci-Fi", Rating = 8.8 },
                new Movie { Name = "The Dark Knight", MovieTime = 152, ReleaseYear = 2008, Genre = "Action", Rating = 9.0 },
                new Movie { Name = "Interstellar", MovieTime = 169, ReleaseYear = 2014, Genre = "Sci-Fi", Rating = 8.6 },
                new Movie { Name = "The Shawshank Redemption", MovieTime = 142, ReleaseYear = 1994, Genre = "Drama", Rating = 9.3 },
                new Movie { Name = "Fight Club", MovieTime = 139, ReleaseYear = 1999, Genre = "Drama", Rating = 8.8 }
            };
        }
        private int FindMovieWithMaxRating()
        {
            if (_movies == null || _movies.Length == 0)
            {
                throw new ArgumentException("Список фильмов пуст или равен null.");
            }
            int maxIndex = 0;
            double maxRating = _movies[0].Rating;

            for (int i = 1; i < _movies.Length; i++)
            {
                if (_movies[i].Rating > maxRating)
                {
                    maxRating = _movies[i].Rating;
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
        private void UpdateMovieFields()
        {
            if (_currentMovie != null)
            {
                NameInput.Text = _currentMovie.Name;
                MovieTimeInput.Text = _currentMovie.MovieTime.ToString();
                ReleaseYearInput.Text = _currentMovie.ReleaseYear.ToString();
                GenreInput.Text = _currentMovie.Genre;
                RatingInput.Text = _currentMovie.Rating.ToString();
            }
        }
    }
}

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
        private Dictionary<string, Type> enumTypes;
        private Model.Rectangle[] _rectangles;
        private List<Model.Rectangle> _rectanglesList;
        private Model.Rectangle _currentRectangle;
        private Ring[] _rings;
        private Ring _currentRing;
        private Random random = new Random();
        private Movie[] _movies;
        private Movie _currentMovie;
        private Panel _rectanglesPanel;
        private List<Panel> _rectanglePanels = new List<Panel>();
        public MainForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            enumTypes = new Dictionary<string, Type>();
            centerXBox.KeyPress += centerBox_KeyPress;
            centerYBox.KeyPress += centerBox_KeyPress; 
            _rectanglesList = new List<Model.Rectangle>();
            _rectanglesPanel = new Panel();
            _rectanglePanels = new List<Panel>();
            _rectanglesPanel.Paint += rectanglesPanel_Paint;
            idBox.ReadOnly = true;
            IDRectangleBox.ReadOnly = true;
            collisionRectanglesBox.ReadOnly = true;
            collisionRingsBox.ReadOnly = true;
            InitializeRectangles();
            UpdateFields();
            InitializeMovies();
            InitializeRings();
            UpdateRingFields();
            Controls.Add(_rectanglesPanel);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            enumTypes.Add("Colour", typeof(Colour));
            enumTypes.Add("Genre", typeof(Genre));
            enumTypes.Add("Form of study", typeof(FormOfStudy));
            enumTypes.Add("Season", typeof(Season));
            enumTypes.Add("Smartphone manufacturers", typeof(SmartphoneManufacturers));
            enumTypes.Add("Weekday", typeof(Weekday));
            EnumsListBox.DataSource = new List<string>(enumTypes.Keys);
            seasonComboBox.Items.Add(Season.Winter);
            seasonComboBox.Items.Add(Season.Spring);
            seasonComboBox.Items.Add(Season.Summer);
            seasonComboBox.Items.Add(Season.Autumn);
        }

    private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueListBox.Items.Clear();
            if (EnumsListBox != null && enumTypes.TryGetValue(EnumsListBox.SelectedItem.ToString(), out Type SelectedItem))
            {
                var enumValues = Enum.GetValues(SelectedItem);
                foreach (var value in enumValues)
                {
                    ValueListBox.Items.Add(value);
                }
            }
        }

        private void ValueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValueListBox != null)
            {
                int ValueAsInt = ValueListBox.SelectedIndex;
                ValueTextBox.Text = ValueAsInt.ToString();
            }
        }

        private void ValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultLabel_Click(object sender, EventArgs e)
        {
            resultLabel.Text = " ";
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            string inputText = dayInput.Text.Trim();
            if (!string.IsNullOrEmpty(inputText))
            {
                if (Enum.TryParse(inputText, true, out DayOfWeek parsedDay))
                {
                    int dayIndex = ((int)parsedDay + 6) % 7 + 1;
                    resultLabel.Text = $"This day is ({parsedDay} = {dayIndex})";
                }
                else
                {
                    resultLabel.Text = "There is no day with this name";
                }
            }
            else
            {
                resultLabel.Text = "Please enter the name of the day";
            }
        }

        private void dayInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void seasonButton_Click(object sender, EventArgs e)
        {
            if (seasonComboBox.SelectedItem != null && seasonComboBox.SelectedItem is Season selectedSeason)
            {
                switch (selectedSeason)
                {
                    case Season.Winter:
                        MessageBox.Show("Brrr! Its cold!");
                        break;
                    case Season.Spring:
                        this.BackColor = Color.LightGreen;
                        break;
                    case Season.Summer:
                        MessageBox.Show("Hooray! The sun!");
                        break;
                    case Season.Autumn:
                        this.BackColor = Color.Orange;
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please choose a season", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void seasonComboBox_SelectedIndexChanged(object sender, EventArgs e)
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

        private void rectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = rectanglesListBox.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < _rectanglesList.Count)
            {
                _currentRectangle = _rectanglesList[selectedIndex];
                RectangleUtils.UpdateRectangleInfo(_currentRectangle, IDRectangleBox, widthRectangleBox, lengthRectangleBox, XCenterBox, YCenterBox);
            }
            else
            {
                RectangleUtils.ClearRectangleInfo(IDRectangleBox, widthRectangleBox, lengthRectangleBox, XCenterBox, YCenterBox);
            }
        }

        private void addPictureBox_Click(object sender, EventArgs e)
        {
            int canvasWidth = rectanglesPanel.Width;
            int canvasHeight = rectanglesPanel.Height;
            var newRectangle = RectangleFactory.Randomize(canvasWidth, canvasHeight, 30);
            _rectanglesList.Add(newRectangle);
            Panel newPanel = new Panel
            {
                BackColor = Color.FromArgb(127, 127, 255, 127),
                Size = new Size((int)newRectangle.Width, (int)newRectangle.Length),
                Location = new Point((int)(newRectangle.Center.X - newRectangle.Width / 2), (int)(newRectangle.Center.Y - newRectangle.Length / 2))
            };
            _rectanglesPanel.Controls.Add(newPanel);
            _rectanglePanels.Add(newPanel);
            UpdateRectanglesList();
            _currentRectangle = newRectangle;
            RectangleUtils.UpdateRectangleInfo(newRectangle, IDRectangleBox, widthRectangleBox, lengthRectangleBox, XCenterBox, YCenterBox);
            DrawRectangles();
            FindCollissions();
        }

        private void deletePictureBox_Click(object sender, EventArgs e)
        {
            int selectedIndex = rectanglesListBox.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < _rectanglesList.Count)
            {
                if (selectedIndex < _rectanglePanels.Count)
                {
                    Panel panelToRemove = _rectanglePanels[selectedIndex];
                    _rectanglesPanel.Controls.Remove(panelToRemove);
                    panelToRemove.Dispose();
                    _rectanglePanels.RemoveAt(selectedIndex);
                }
                _rectanglesList.RemoveAt(selectedIndex);
                UpdateRectanglesList();
                if (_rectanglesList.Count > 0)
                {
                    rectanglesListBox.SelectedIndex = Math.Min(selectedIndex, _rectanglesList.Count - 1);
                }
                else
                {
                    RectangleUtils.ClearRectangleInfo(IDRectangleBox, widthRectangleBox, lengthRectangleBox, XCenterBox, YCenterBox);
                }
                DrawRectangles();
                FindCollissions();
            }
        }

        private void UpdateRectanglesList()
        {
            rectanglesListBox.Items.Clear();
            foreach (var rectangle in _rectanglesList)
            {
                string displayText = $"ID: {rectangle.ID}," + $"L: {rectangle.Length:F2}," + $"W: {rectangle.Width:F2}," + $"X: {rectangle.Center.X:F2}," + $"Y: {rectangle.Center.Y:F2}";
                rectanglesListBox.Items.Add(displayText);
            }
        }

        private void rectanglesPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (var rectangle in _rectanglesList)
            {
                Color fillColor = Color.FromArgb(127, 127, 255, 127);
                if (rectangle.Color == "Red")
                {
                    fillColor = Color.FromArgb(127, 255, 127, 127);
                }
                using (Brush brush = new SolidBrush(fillColor))
                {
                    g.FillRectangle(brush,
                        (float)(rectangle.Center.X - (rectangle.Width / 2)),
                        (float)(rectangle.Center.Y - (rectangle.Length / 2)),
                        (float)rectangle.Width,
                        (float)rectangle.Length);
                }
            }
        }

        private void DrawRectangles()
        {
            rectanglesPanel.Invalidate();
        }

        private void IDRectangleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void XCenterBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                try
                {
                    if (double.TryParse(XCenterBox.Text, out double x))
                    {
                        _currentRectangle.SetCenter(Validator.ValidateCoordinate(x, nameof(Point2D.X)), _currentRectangle.Center.Y);
                        RectangleUtils.UpdateRectangleInfo(_currentRectangle, IDRectangleBox, widthRectangleBox, lengthRectangleBox, XCenterBox, YCenterBox);
                        FindCollissions();
                        DrawRectangles();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    XCenterBox.Text = _currentRectangle.Center.X.ToString();
                }
            }
        }

        private void YCenterBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                try
                {
                    if (double.TryParse(YCenterBox.Text, out double y))
                    {
                        _currentRectangle.SetCenter(_currentRectangle.Center.X, Validator.ValidateCoordinate(y, nameof(Point2D.Y)));
                        RectangleUtils.UpdateRectangleInfo(_currentRectangle, IDRectangleBox, widthRectangleBox, lengthRectangleBox, XCenterBox, YCenterBox);
                        FindCollissions();
                        DrawRectangles();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    YCenterBox.Text = _currentRectangle.Center.Y.ToString();
                }
            }
        }

        private void widthRectangleBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                try
                {
                    if (double.TryParse(widthRectangleBox.Text, out double width))
                    {
                        _currentRectangle.Width = Validator.AssertOnPositiveValue(width, "Width");
                        RectangleUtils.UpdateRectangleInfo(_currentRectangle, IDRectangleBox, widthRectangleBox, lengthRectangleBox, XCenterBox, YCenterBox);
                        FindCollissions();
                        DrawRectangles();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    widthRectangleBox.Text = _currentRectangle.Width.ToString();
                }
            }
        }

        private void lengthRectangleBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                try
                {
                    if (double.TryParse(lengthRectangleBox.Text, out double length))
                    {
                        _currentRectangle.Length = Validator.AssertOnPositiveValue(length, "Length");
                        RectangleUtils.UpdateRectangleInfo(_currentRectangle, IDRectangleBox, widthRectangleBox, lengthRectangleBox, XCenterBox, YCenterBox);
                        FindCollissions();
                        DrawRectangles();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    lengthRectangleBox.Text = _currentRectangle.Length.ToString();
                }
            }
        }
        private void FindCollissions()
        {
            var collisionGrid = new CollisionGrid(400);

            foreach (var rectangle in _rectanglesList)
            {
                collisionGrid.AddRectangle(rectangle);
            }

            foreach (var rectangle in _rectanglesList)
            {
                var possibleCollisions = collisionGrid.GetPossibleCollisions(rectangle);

                foreach (var potentialCollision in possibleCollisions)
                {
                    if (rectangle != potentialCollision && CollisionManager.IsCollisionRectangles(rectangle, potentialCollision))
                    {
                        rectangle.Color = "Red";
                        potentialCollision.Color = "Red";
                    }
                }
            }

            DrawRectangles();
        }
        public class CollisionGrid
        {
            private readonly int _cellSize;
            private readonly Dictionary<Point, List<Model.Rectangle>> _cells;

            public CollisionGrid(int cellSize)
            {
                _cellSize = cellSize;
                _cells = new Dictionary<Point, List<Model.Rectangle>>();
            }

            public void AddRectangle(Model.Rectangle rectangle)
            {
                var (cellX, cellY) = GetCellCoordinates(rectangle);
                var cellKey = new Point(cellX, cellY);

                if (!_cells.ContainsKey(cellKey))
                {
                    _cells[cellKey] = new List<Model.Rectangle>();
                }

                _cells[cellKey].Add(rectangle);
            }

            public IEnumerable<Model.Rectangle> GetPossibleCollisions(Model.Rectangle rectangle)
            {
                var (cellX, cellY) = GetCellCoordinates(rectangle);
                var cellsToCheck = new List<Point>
        {
            new Point(cellX, cellY),
            new Point(cellX + 1, cellY),
            new Point(cellX - 1, cellY),
            new Point(cellX, cellY + 1),
            new Point(cellX, cellY - 1),
            new Point(cellX + 1, cellY + 1),
            new Point(cellX - 1, cellY - 1),
            new Point(cellX + 1, cellY - 1),
            new Point(cellX - 1, cellY + 1)
        };

                var possibleCollisions = new HashSet<Model.Rectangle>();

                foreach (var cell in cellsToCheck)
                {
                    if (_cells.ContainsKey(cell))
                    {
                        foreach (var rect in _cells[cell])
                        {
                            possibleCollisions.Add(rect);
                        }
                    }
                }

                return possibleCollisions;
            }

            private (int, int) GetCellCoordinates(Model.Rectangle rectangle)
            {
                int x = (int)(rectangle.Center.X / _cellSize);
                int y = (int)(rectangle.Center.Y / _cellSize);
                return (x, y);
            }
        }
    }
}

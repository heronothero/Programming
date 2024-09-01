using Programming.Model;
using Programming.Model.Geometry;
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
    public partial class RectanglesControl : UserControl
    {
        /// <summary>
        /// A private property of rectangles' array.
        /// </summary>
        private Model.Rectangle[] _rectangles;

        /// <summary>
        /// A private property of a current rectangle.
        /// </summary>
        private Model.Rectangle _currentRectangle;

        /// <summary>
        /// A private property of random.
        /// </summary>
        private Random random = new Random();

        /// <summary>
        /// Initializing components.
        /// </summary>
        public RectanglesControl()
        {
            InitializeComponent();
            centerXBox.KeyPress += centerBox_KeyPress;
            centerYBox.KeyPress += centerBox_KeyPress;
            idBox.ReadOnly = true;
            InitializeRectangles();
            UpdateFields();
        }

        /// <summary>
        /// A function of initializing 5 rectangles in the array with random values in range.
        /// </summary>
        private void InitializeRectangles()
        {
            _rectangles = new Model.Rectangle[5];
            for (int i = 0; i < 5; i++)
            {
                double length = random.NextDouble() * 100;
                double width = random.NextDouble() * 100;
                string color = RectangleFactory.GetRandomColor();
                Point2D center = new Point2D(random.NextDouble() * 100, random.NextDouble() * 100);
                _rectangles[i] = new Model.Rectangle(length, width, color, center);
                RectanglesBox.Items.Add($"Прямоугольник {i + 1}");
            }
            if (_rectangles.Length > 0)
            {
                _currentRectangle = _rectangles[0];
            }
        }

        /// <summary>
        /// A function of updating rectangle's fields.
        /// </summary>
        private void UpdateFields()
        {
            widthBox.Text = _currentRectangle.Width.ToString();
            lengthBox.Text = _currentRectangle.Length.ToString();
            centerXBox.Text = _currentRectangle.Center.X.ToString();
            centerYBox.Text = _currentRectangle.Center.Y.ToString();
            colorBox.Text = _currentRectangle.Color;
            idBox.Text = _currentRectangle.ID.ToString();
        }

        /// <summary>
        /// Rectangles' list (array) in which user can choose an item and see info in textboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// The field of a rectangle's length which must be valid (positive and double).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        textBox.BackColor = AppColors.ValidationSuccess;
                    }
                    else
                    {
                        textBox.BackColor = AppColors.ValidationError;
                    }
                }
                catch (FormatException)
                {
                    textBox.BackColor = AppColors.ValidationError;
                }
                catch (ArgumentOutOfRangeException)
                {
                    textBox.BackColor = AppColors.ValidationError;
                }
            }
        }

        /// <summary>
        /// The field of a rectangle's width which must be valid (positive and double).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        textBox.BackColor = AppColors.ValidationSuccess;
                    }
                    else
                    {
                        textBox.BackColor = AppColors.ValidationError;
                    }
                }
                catch (FormatException)
                {
                    textBox.BackColor = AppColors.ValidationError;
                }
                catch (ArgumentOutOfRangeException)
                {
                    textBox.BackColor = AppColors.ValidationError;
                }
            }
        }

        /// <summary>
        /// Indicates that the event handler has already processed the event and dealt with it, so it doesn't need to be processed any further.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void centerBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// The field of a rectangle's x, checking if the value is valid or not (positive and less than 1000).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        textBox.BackColor = AppColors.ValidationSuccess;
                    }
                    else
                    {
                        textBox.BackColor = AppColors.ValidationError;
                    }
                }
                catch (FormatException)
                {
                    textBox.BackColor = AppColors.ValidationError;
                }
                catch (ArgumentOutOfRangeException)
                {
                    textBox.BackColor = AppColors.ValidationError;
                }
            }
        }

        /// <summary>
        /// The field of a rectangle's y, checking if the value is valid or not (positive and less than 1000).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        textBox.BackColor = AppColors.ValidationSuccess;
                    }
                    else
                    {
                        textBox.BackColor = AppColors.ValidationError;
                    }
                }
                catch (FormatException)
                {
                    textBox.BackColor = AppColors.ValidationError;
                }
                catch (ArgumentOutOfRangeException)
                {
                    textBox.BackColor = AppColors.ValidationError;
                }
            }
        }

        /// <summary>
        /// The field of a rectangle's color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colorBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                _currentRectangle.Color = colorBox.Text;
            }
        }

        /// <summary>
        /// A button's event which after a click shows a rectangle with max width.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// A function of finding a rectangle with max width if the array isn't null.
        /// </summary>
        /// <param name="rectangles"> An array of rectangles </param>
        /// <returns> Returns an index of the rectangle with max width </returns>
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
    }
}

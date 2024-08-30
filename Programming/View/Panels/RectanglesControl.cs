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
        private Model.Rectangle[] _rectangles;
        private Model.Rectangle _currentRectangle;
        private Random random = new Random();
        public RectanglesControl()
        {
            InitializeComponent();
            centerXBox.KeyPress += centerBox_KeyPress;
            centerYBox.KeyPress += centerBox_KeyPress;
            idBox.ReadOnly = true;
            //collisionRectanglesBox.ReadOnly = true;
            InitializeRectangles();
            UpdateFields();
        }

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
            //collisionRectanglesBox.Text = collisionResults.ToString();
        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {

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
    }
}

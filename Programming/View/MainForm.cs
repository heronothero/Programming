using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model;

namespace Programming
{
    public partial class MainForm : Form
    {
        private Dictionary<string, Type> enumTypes;
        private Model.Rectangle[] _rectangles;
        private Model.Rectangle _currentRectangle;
        private Random random = new Random();
        public MainForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            enumTypes = new Dictionary<string, Type>();
            _rectangles = new Model.Rectangle[5];
            for (int i = 0; i < 5; i++)
            {
                double length = random.NextDouble() * 100;
                double width = random.NextDouble() * 100;
                string color = GetRandomColor();
                _rectangles[i] = new Model.Rectangle(length, width, color);
                RectanglesBox.Items.Add($"Прямоугольник {i + 1}");
            }
            if (_rectangles.Length > 0)
            {
                _currentRectangle = _rectangles[0];
                UpdateFields();
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
            colorBox.Text = _currentRectangle.Color;
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
                } else
                {
                    resultLabel.Text = "There is no day with this name";
                }
            } else
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
            } else
            {
                MessageBox.Show("Please choose a season", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void seasonComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RectanglesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = RectanglesBox.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex <= _rectangles.Length)
            {
                _currentRectangle = _rectangles[selectedIndex];
                UpdateFields();
            }
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

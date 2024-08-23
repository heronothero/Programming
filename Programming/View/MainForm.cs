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
        public MainForm()
        {
            InitializeComponent();
            enumTypes = new Dictionary<string, Type>();
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
    }
}

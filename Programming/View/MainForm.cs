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
    }
}

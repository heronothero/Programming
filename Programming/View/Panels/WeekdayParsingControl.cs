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
    public partial class WeekdayParsingControl : UserControl
    {
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }

        private void dayInput_TextChanged(object sender, EventArgs e)
        {

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

        private void resultLabel_Click(object sender, EventArgs e)
        {
            resultLabel.Text = " ";
        }
    }
}

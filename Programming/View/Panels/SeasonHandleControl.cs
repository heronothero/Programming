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
    public partial class SeasonHandleControl : UserControl
    {
        public SeasonHandleControl()
        {
            InitializeComponent();
            InitializeSeasons();
        }

        private void InitializeSeasons()
        {
            seasonComboBox.Items.Add(Season.Winter);
            seasonComboBox.Items.Add(Season.Spring);
            seasonComboBox.Items.Add(Season.Summer);
            seasonComboBox.Items.Add(Season.Autumn);
        }

        private void seasonComboBox_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}

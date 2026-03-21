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
        /// <summary>
        /// Initializing components.
        /// </summary>
        public SeasonHandleControl()
        {
            InitializeComponent();
            InitializeSeasons();
        }

        /// <summary>
        /// Initializing seasons' list.
        /// </summary>
        private void InitializeSeasons()
        {
            seasonComboBox.Items.Add(Season.Winter);
            seasonComboBox.Items.Add(Season.Spring);
            seasonComboBox.Items.Add(Season.Summer);
            seasonComboBox.Items.Add(Season.Autumn);
        }

        /// <summary>
        /// The combo box of seasons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void seasonComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// A button's event which handles different scenarios depending on what option user chooses.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void seasonButton_Click(object sender, EventArgs e)
        {
            if (seasonComboBox.SelectedItem != null && seasonComboBox.SelectedItem is Season selectedSeason)
            {
                switch (selectedSeason)
                {
                    case Season.Winter:
                        MessageBox.Show("Brrr! Its cold!");
                        this.BackColor = AppColors.Winter;
                        break;
                    case Season.Spring:
                        this.BackColor = AppColors.Spring;
                        break;
                    case Season.Summer:
                        MessageBox.Show("Hooray! The sun!");
                        this.BackColor = AppColors.Summer;
                        break;
                    case Season.Autumn:
                        this.BackColor = AppColors.Autumn;
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

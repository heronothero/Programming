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

        }

        private void ValueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

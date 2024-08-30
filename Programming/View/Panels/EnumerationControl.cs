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
    public partial class EnumerationControl : UserControl
    {
        private Dictionary<string, Type> enumTypes;
        public EnumerationControl()
        {
            InitializeComponent();
            enumTypes = new Dictionary<string, Type>();
            InitializeEnumTypes();
            EnumsListBox.DataSource = new List<string>(enumTypes.Keys);
        }

        private void InitializeEnumTypes()
        {
            enumTypes.Add("Colour", typeof(Colour));
            enumTypes.Add("Genre", typeof(Genre));
            enumTypes.Add("Form of study", typeof(FormOfStudy));
            enumTypes.Add("Season", typeof(Season));
            enumTypes.Add("Smartphone manufacturers", typeof(SmartphoneManufacturers));
            enumTypes.Add("Weekday", typeof(Weekday));
        }

        private void ValueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValueListBox != null)
            {
                int ValueAsInt = ValueListBox.SelectedIndex;
                ValueTextBox.Text = ValueAsInt.ToString();
            }
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

        private void ValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

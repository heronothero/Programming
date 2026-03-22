using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {

        private List<Customer> _customers = new List<Customer>();

        public CustomersTab()
        {
            InitializeComponent();

            RemoveButton.Click += RemoveButton_Click;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;

            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            AddressTextBox.TextChanged += AddressTextBox_TextChanged;
        }

        private void IdCustomerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;
            if (index < 0) return;

            try
            {
                _customers[index].FullName = FullNameTextBox.Text;
                CustomersListBox.Items[index] = _customers[index];
                FullNameTextBox.BackColor = Color.White;
            }
            catch
            {
                FullNameTextBox.BackColor = Color.LightPink;
            }
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;
            if (index < 0) return;

            try
            {
                _customers[index].Address = AddressTextBox.Text;
                AddressTextBox.BackColor = Color.White;
            }
            catch
            {
                AddressTextBox.BackColor = Color.LightPink;
            }
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;

            if (index < 0) return;

            Customer customer = _customers[index];

            IdCustomerTextBox.Text = customer.Id.ToString();
            FullNameTextBox.Text = customer.FullName;
            AddressTextBox.Text = customer.Address;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.FullName = "Andrew Stone";
            customer.Address = "St Pt";

            _customers.Add(customer);
            CustomersListBox.Items.Add(customer);

            CustomersListBox.SelectedIndex = _customers.Count - 1;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;
            if (index < 0) return;

            _customers.RemoveAt(index);
            CustomersListBox.Items.RemoveAt(index);

            ClearFields();
        }

        private void ClearFields()
        {
            IdCustomerTextBox.Text = "";
            FullNameTextBox.Text = "";
            AddressTextBox.Text = "";
        }

        private void IdCustomerLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
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
        /// <summary>
        /// Создание списка покупателей
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Инициализация компонентов и событий в CustomersTab
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();

            RemoveButton.Click += RemoveButton_Click;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;

            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            AddressTextBox.TextChanged += AddressTextBox_TextChanged;
        }

        /// <summary>
        /// Обрабатывает изменения идентификатора покупателя
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void IdCustomerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Обрабатывает изменения ФИО покупателя
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
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

        /// <summary>
        /// Обрабатывает изменения адреса покупателя
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
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

        /// <summary>
        /// Обрабатывает изменения выбранного покупателя и отображает данные в текстовых полях
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;

            if (index < 0) return;

            Customer customer = _customers[index];

            IdCustomerTextBox.Text = customer.Id.ToString();
            FullNameTextBox.Text = customer.FullName;
            AddressTextBox.Text = customer.Address;
        }

        /// <summary>
        /// Обрабатывает кнопку создания нового покупателя
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.FullName = "Andrew Stone";
            customer.Address = "St Pt";

            _customers.Add(customer);
            CustomersListBox.Items.Add(customer);

            CustomersListBox.SelectedIndex = _customers.Count - 1;
        }

        /// <summary>
        /// Обрабатывает кнопку удаления покупателя
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;
            if (index < 0) return;

            _customers.RemoveAt(index);
            CustomersListBox.Items.RemoveAt(index);

            ClearFields();
        }

        /// <summary>
        /// Очищение полей
        /// </summary>
        private void ClearFields()
        {
            IdCustomerTextBox.Text = "";
            FullNameTextBox.Text = "";
            AddressTextBox.Text = "";
        }

        /// <summary>
        /// Обрабатывает изменения идентификатора лейбла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IdCustomerLabel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Обрабатывает генерацию случайного покупателя из сервисного класса и отображает в списке
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            Customer customer = CustomerFactory.CreateRandom();

            _customers.Add(customer);
            CustomersListBox.Items.Add(customer);

            CustomersListBox.SelectedIndex = _customers.Count - 1;
        }
    }
}

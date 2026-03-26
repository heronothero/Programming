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
using ObjectOrientedPractics.View.Controls;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Вкладка управления покупателями
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Список всех покупателей
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        private Customer selectedCustomer;

        /// <summary>
        /// Инициализация компонентов и событий в CustomersTab
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();

            RemoveButton.Click += RemoveButton_Click;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;

            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            AddressControl.AddressChanged += AddressControl_AddressChanged;
        }

        /// <summary>
        /// Коллекция покупателей для работы с UI и внешних компонентов
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value ?? new List<Customer>();

                CustomersListBox.Items.Clear();

                foreach (var customer in _customers)
                {
                    CustomersListBox.Items.Add(customer);
                }
            }
        }

        /// <summary>
        /// Очистка всех полей ввода
        /// </summary>
        private void ClearFields()
        {
            IdCustomerTextBox.Text = "";
            FullNameTextBox.Text = "";
            AddressControl.Address = new Address();
        }

        private void IdCustomerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IdCustomerLabel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Обработка изменения ФИО текущего покупателя
        /// </summary>
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
        /// Обработка выбора покупателя из списка
        /// </summary>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;
            if (index < 0) return;

            selectedCustomer = _customers[index];

            IdCustomerTextBox.Text = selectedCustomer.Id.ToString();
            FullNameTextBox.Text = selectedCustomer.FullName;
            AddressControl.Address = selectedCustomer.Address;
            IsPriorityCheckBox.Checked = selectedCustomer.IsPriority;
        }

        /// <summary>
        /// Создание нового покупателя
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.FullName = "Andrew Stone";
            customer.Address = new Address();

            _customers.Add(customer);
            CustomersListBox.Items.Add(customer);

            CustomersListBox.SelectedIndex = _customers.Count - 1;
        }

        /// <summary>
        /// Удаление выбранного покупателя
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;
            if (index < 0) return;

            _customers.RemoveAt(index);
            CustomersListBox.Items.RemoveAt(index);

            ClearFields();
        }

        /// <summary>
        /// Генерация случайного покупателя и добавление в список
        /// </summary>
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            Customer customer = CustomerFactory.CreateRandom();

            _customers.Add(customer);
            CustomersListBox.Items.Add(customer);

            CustomersListBox.SelectedIndex = _customers.Count - 1;
        }

        /// <summary>
        /// Обновление адреса текущего покупателя при изменениях в AddressControl
        /// </summary>
        private void AddressControl_AddressChanged(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;
            if (index < 0) return;

            _customers[index].Address = AddressControl.Address;
        }

        private void AddressControl_Load(object sender, EventArgs e)
        {

        }

        private void IsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedCustomer != null)
                selectedCustomer.IsPriority = IsPriorityCheckBox.Checked;
        }
    }
}

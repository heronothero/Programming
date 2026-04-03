using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Вкладка заказов
    /// </summary>
    public partial class OrdersTab : UserControl
    {
        private List<Customer> _customers = new List<Customer>();
        private List<Order> _orders = new List<Order>();
        private Order _currentOrder;
        private PriorityOrder _selectedPriorityOrder;

        /// <summary>
        /// Инициализация компонентов вкладки OrdersTab
        /// </summary>
        public OrdersTab()
        {
            InitializeComponent();

            OrdersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OrdersDataGridView.MultiSelect = false;
            OrdersDataGridView.AllowUserToAddRows = false;
            OrdersDataGridView.AllowUserToResizeRows = false;
            OrdersDataGridView.AllowUserToOrderColumns = false;
            OrdersDataGridView.ReadOnly = true;
            OrdersDataGridView.SelectionChanged += OrdersDataGridView_SelectionChanged;

            StatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));

            DeliveryTimeComboBox.DataSource = Enum.GetValues(typeof(DeliveryTimeRange));
            DeliveryTimeComboBox.SelectedIndexChanged += DeliveryTimeComboBox_SelectedIndexChanged;
        }

        /// <summary>
        /// Коллекция покупателей
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value ?? new List<Customer>();
                UpdateOrders();
            }
        }

        /// <summary>
        /// Полное обновление данных на вкладке
        /// </summary>
        public void RefreshData()
        {
            UpdateOrders();

            _currentOrder = null;

            IdTextBox.Text = "";
            CreatedTextBox.Text = "";
            OrderItemsListBox.Items.Clear();
            SumLabel.Text = "0 ₽";
        }

        /// <summary>
        /// Обновление списка заказов на основе текущих покупателей
        /// </summary>
        private void UpdateOrders()
        {
            _orders.Clear();

            foreach (var customer in _customers)
            {
                foreach (var order in customer.Orders)
                {
                    _orders.Add(order);
                }
            }

            OrdersDataGridView.Rows.Clear();

            foreach (var order in _orders)
            {
                OrdersDataGridView.Rows.Add(
                    order.Id,
                    order.CreatedAt,
                    GetCustomerName(order),
                    order.DeliveryAddress.ToString(),
                    order.Amount,
                    order.OrderStatus
                );
            }
        }

        /// <summary>
        /// Отображает информацию о текущем заказе
        /// </summary>
        private void ShowOrder()
        {
            if (_currentOrder == null) return;

            IdTextBox.Text = _currentOrder.Id.ToString();
            CreatedTextBox.Text = _currentOrder.CreatedAt.ToString();
            addressControl1.Address = _currentOrder.DeliveryAddress;

            OrderItemsListBox.Items.Clear();
            foreach (var item in _currentOrder.Items)
                OrderItemsListBox.Items.Add(item);

            SumLabel.Text = $"{_currentOrder.Amount} ₽";

            StatusComboBox.SelectedIndexChanged -= StatusComboBox_SelectedIndexChanged;
            StatusComboBox.SelectedItem = _currentOrder.OrderStatus;
            StatusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;

            if (_currentOrder is PriorityOrder priorityOrder)
            {
                _selectedPriorityOrder = priorityOrder;
                DeliveryTimeLabel.Visible = true;
                DeliveryTimeComboBox.Visible = true;

                DeliveryTimeComboBox.SelectedIndexChanged -= DeliveryTimeComboBox_SelectedIndexChanged;
                DeliveryTimeComboBox.SelectedItem = _selectedPriorityOrder.DeliveryTimeRange;
                DeliveryTimeComboBox.SelectedIndexChanged += DeliveryTimeComboBox_SelectedIndexChanged;
            }
            else
            {
                _selectedPriorityOrder = null;
                DeliveryTimeLabel.Visible = false;
                DeliveryTimeComboBox.Visible = false;
            }
        }

        /// <summary>
        /// Возвращает ФИО покупателя для заказа
        /// </summary>
        private string GetCustomerName(Order order)
        {
            foreach (var customer in _customers)
            {
                if (customer.Orders.Contains(order))
                    return customer.FullName;
            }

            return "";
        }

        /// <summary>
        /// Обработчик выбора заказа в таблице
        /// </summary>
        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.SelectedRows.Count == 0)
                return;

            int index = OrdersDataGridView.SelectedRows[0].Index;
            if (index < 0 || index >= _orders.Count)
                return;

            _currentOrder = _orders[index];
            ShowOrder();
        }

        /// <summary>
        /// Обновление статуса заказа через комбобокс
        /// </summary>
        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentOrder == null) return;

            if (StatusComboBox.SelectedItem is OrderStatus status)
            {
                _currentOrder.OrderStatus = status;
                UpdateOrders();
            }
        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreatedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressControl1_Load(object sender, EventArgs e)
        {

        }

        private void OrderItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SumLabel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Обрабатывает изменение выбранного диапазона времени доставки только для приоритетного заказа
        /// </summary>
        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_selectedPriorityOrder != null && DeliveryTimeComboBox.SelectedItem is DeliveryTimeRange time)
            {
                _selectedPriorityOrder.DeliveryTimeRange = time;
            }
        }
    }
}

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

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Вкладка корзины покупателя
    /// </summary>
    public partial class CartsTab : UserControl
    {
        private List<Item> _items = new List<Item>();
        private List<Customer> _customers = new List<Customer>();
        private Customer _currentCustomer;
        private OrdersTab _ordersTab;

        /// <summary>
        /// Инициализация компонентов вкладки CartsTab
        /// </summary>
        public CartsTab(OrdersTab ordersTab)
        {
            InitializeComponent();
            _ordersTab = ordersTab;
        }

        /// <summary>
        /// Инициализация компонентов вкладки CartsTab
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Коллекция товаров для работы с UI
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Item> Items
        {
            get => _items;
            set
            {
                _items = value ?? new List<Item>();
                RefreshData();
            }
        }

        /// <summary>
        /// Коллекция покупателей для работы с UI
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value ?? new List<Customer>();
                RefreshData();
            }
        }

        ///<summary>
        /// Обновление данных UI (список всех товаров, покупателей и корзины)
        ///</summary>
        public void RefreshData()
        {
            var selectedCustomer = _currentCustomer;

            AllItemsListBox.Items.Clear();
            foreach (var item in _items)
            {
                AllItemsListBox.Items.Add(item);
            }

            CustomersComboBox.Items.Clear();
            foreach (var customer in _customers)
            {
                CustomersComboBox.Items.Add(customer);
            }

            CartListBox.Items.Clear();
            SumLabel.Text = "0 ₽";

            _currentCustomer = null;

            if (selectedCustomer != null)
            {
                int index = _customers.IndexOf(selectedCustomer);
                if (index >= 0)
                {
                    CustomersComboBox.SelectedIndex = index;
                    _currentCustomer = _customers[index];
                    UpdateCart();
                }
            }
        }

        /// <summary>
        /// Обновление содержимого корзины текущего покупателя
        /// </summary>
        private void UpdateCart()
        {
            CartListBox.Items.Clear();

            if (_currentCustomer == null)
            {
                SumLabel.Text = "0 ₽";
                return;
            }

            foreach (var item in _currentCustomer.Cart.Items)
            {
                CartListBox.Items.Add(item);
            }

            SumLabel.Text = $"{_currentCustomer.Cart.Amount} ₽";
        }

        /// <summary>
        /// Изменение выбранного покупателя
        /// </summary>
        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = CustomersComboBox.SelectedIndex;
            if (index < 0)
            {
                _currentCustomer = null;
                CartListBox.Items.Clear();
                SumLabel.Text = "0 ₽";
                return;
            }

            _currentCustomer = _customers[index];
            UpdateCart();
        }

        /// <summary>
        /// Добавление выбранного товара в корзину
        /// </summary>
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null) return;

            int index = AllItemsListBox.SelectedIndex;
            if (index < 0) return;

            var item = _items[index];

            _currentCustomer.Cart.Items.Add(item);

            UpdateCart();
        }

        /// <summary>
        /// Создание заказа из текущей корзины покупателя
        /// </summary>
        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null) return;

            List<Item> items = new List<Item>(_currentCustomer.Cart.Items);
            Address deliveryAddress = _currentCustomer.Address;

            Order newOrder;

            if (_currentCustomer.IsPriority)
            {
                var priorityOrder = new PriorityOrder();
                priorityOrder.Items = new List<Item>(items);
                priorityOrder.DeliveryAddress = deliveryAddress;
                priorityOrder.DeliveryDate = DateTime.Now.AddDays(1);
                priorityOrder.DeliveryTimeRange = DeliveryTimeRange.NineToEleven;

                newOrder = priorityOrder;
            }
            else
            {
                newOrder = new Order(items, deliveryAddress);
            }

            _currentCustomer.Orders.Add(newOrder);

            _currentCustomer.Cart.Items.Clear();
            UpdateCart();

            _ordersTab?.RefreshData();
        }

        /// <summary>
        /// Удаление выбранного товара из корзины
        /// </summary>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null) 
                return; 
            
            int index = CartListBox.SelectedIndex; 
            
            if (index < 0) 
                return; 
            
            _currentCustomer.Cart.Items.RemoveAt(index); 
            UpdateCart();
        }

        /// <summary>
        /// Очистка всей корзины покупателя
        /// </summary>
        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null) 
                return; 
            
            _currentCustomer.Cart.Items.Clear(); 
            UpdateCart();
        }

        private void SumLabel_Click(object sender, EventArgs e)
        {

        }

        private void CartListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AllItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

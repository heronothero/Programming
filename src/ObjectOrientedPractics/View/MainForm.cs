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

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Главная форма приложения
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Основной магазин с товарами и покупателями
        /// </summary>
        private Store _store;

        /// <summary>
        /// Инициализация компонентов и связывание вкладок с данными
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            _store = new Store();

            itemsTab.Items = _store.Items;
            customersTab.Customers = _store.Customers;
            cartsTab.Items = _store.Items;
            cartsTab.Customers = _store.Customers;
            ordersTab.Customers = _store.Customers;

            itemsTab.ItemsChanged += ItemsTab_ItemsChanged;
        }

        /// <summary>
        /// Обрабатка загрузку главной формы
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Обработка переключения вкладок
        /// </summary>
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == CartsTabPage)
            {
                cartsTab.RefreshData();
            }
            else if (tabControl.SelectedTab == OrderTabPage)
            {
                ordersTab.RefreshData();
            }
        }

        /// <summary>
        /// Обработчик изменения списка товаров — обновляет связанные вкладки
        /// </summary>
        private void ItemsTab_ItemsChanged(object sender, EventArgs e)
        {
            cartsTab.RefreshData();
            ordersTab.RefreshData();
        }
    }
}

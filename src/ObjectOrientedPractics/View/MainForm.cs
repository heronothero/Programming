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
    public partial class MainForm : Form
    {
        /// <summary>
        /// Связка
        /// </summary>
        private Store _store;

        /// <summary>
        /// Инициализация компонентов в главной форме
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            _store = new Store();

            // Передача данных во вкладки
            itemsTab.Items = _store.Items;
            customersTab.Customers = _store.Customers;
        }

        /// <summary>
        /// Обрабатывает загрузку главной формы
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

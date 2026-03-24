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

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Создание списка
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Инициализация компонентов внутри класса ItemsTab
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();

            RemoveButton.Click += RemoveButton_Click;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;

            NameTextBox.TextChanged += NameTextBox_TextChanged;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            InfoTextBox.TextChanged += InfoTextBox_TextChanged;
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
        }

        /// <summary>
        /// Обрабатывает загрузку элементов
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void ItemsTab_Load(object sender, EventArgs e)
        {
            _items = ProjectSerializer.Load("items.json");

            ItemsListBox.Items.Clear();

            foreach (var item in _items)
            {
                ItemsListBox.Items.Add(item);
            }
        }

        /// <summary>
        /// Обрабатывает добавление товара
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            Category category = Category.Аксессуары; //чтобы избежать ошибки с null в категории

            if (CategoryComboBox.SelectedItem != null)
            {
                category = (Category)CategoryComboBox.SelectedItem;
            }

            Item item = new Item("New Item", "", 1, category);

            _items.Add(item);
            ItemsListBox.Items.Add(item);

            ItemsListBox.SelectedIndex = _items.Count - 1;

            ProjectSerializer.Save("items.json", _items);
        }

        /// <summary>
        /// Обрабатывает удаление товара
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;
            if (index < 0) return;

            _items.RemoveAt(index);
            ItemsListBox.Items.RemoveAt(index);

            ClearFields();

            ProjectSerializer.Save("items.json", _items);
        }

        /// <summary>
        /// Очищение полей для метода удаления товара
        /// </summary>
        private void ClearFields()
        {
            IdTextBox.Text = "";
            NameTextBox.Text = "";
            CostTextBox.Text = "";
            InfoTextBox.Text = "";
            CategoryComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Обрабатывает изменения выбранного товара и отображает данные в текстовых полях
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;

            if (index < 0) return;

            Item item = _items[index];

            IdTextBox.Text = item.Id.ToString();
            NameTextBox.Text = item.Name;
            CostTextBox.Text = item.Cost.ToString();
            InfoTextBox.Text = item.Info;
            CategoryComboBox.SelectedItem = item.Category;
        }

        /// <summary>
        /// Обрабатывает изменеие поля идентификатора товара
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Обрабатывает изменения поля цены с условием
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;
            if (index < 0) return;

            try
            {
                decimal cost = decimal.Parse(CostTextBox.Text);
                _items[index].Cost = cost;
                CostTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                CostTextBox.BackColor = System.Drawing.Color.LightPink;
            }

            ProjectSerializer.Save("items.json", _items);
        }

        /// <summary>
        /// Обрабатывает изменение поля имени с условием
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;
            if (index < 0) return;

            try
            {
                _items[index].Name = NameTextBox.Text;
                ItemsListBox.Items[index] = _items[index];
                NameTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                NameTextBox.BackColor = System.Drawing.Color.LightPink;
            }

            ProjectSerializer.Save("items.json", _items);
        }

        /// <summary>
        /// Обрабатывает измененеи поля описания с условием
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void InfoTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;
            if (index < 0) return;

            try
            {
                _items[index].Info = InfoTextBox.Text;
                InfoTextBox.BackColor = Color.White;
            }
            catch
            {
                InfoTextBox.BackColor = Color.LightPink;
            }

            ProjectSerializer.Save("items.json", _items);
        }

        /// <summary>
        /// Обрабатывет генерацию случайного товара и отображения в списке через сервисный класс товаров
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            Item item = ItemFactory.CreateRandom();

            _items.Add(item);
            ItemsListBox.Items.Add(item);

            ItemsListBox.SelectedIndex = _items.Count - 1;
            ProjectSerializer.Save("items.json", _items);
        }

        /// <summary>
        /// Обрабатывает выпадающий список категорий
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;
            if (index < 0) return;

            _items[index].Category = (Category)CategoryComboBox.SelectedItem;

            ProjectSerializer.Save("items.json", _items);
        }
    }
}

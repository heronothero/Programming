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
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Вкладка управления товарами
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список всех товаров
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Инициализация компонентов и событий вкладки ItemsTab
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

        private void ItemsTab_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Коллекция всех товаров для UI
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Item> Items
        {
            get => _items;
            set
            {
                _items = value ?? new List<Item>();

                ItemsListBox.Items.Clear();

                foreach (var item in _items)
                {
                    ItemsListBox.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// Очистка полей ввода
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
        /// Обработка добавления нового товара
        /// </summary>
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
        }

        /// <summary>
        /// Удаление выбранного товара
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;
            if (index < 0) return;

            _items.RemoveAt(index);
            ItemsListBox.Items.RemoveAt(index);

            ClearFields();
        }

        /// <summary>
        /// Генерация случайного товара через ItemFactory
        /// </summary>
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            Item item = ItemFactory.CreateRandom();

            _items.Add(item);
            ItemsListBox.Items.Add(item);

            ItemsListBox.SelectedIndex = _items.Count - 1;
        }

        /// <summary>
        /// Обработка изменения выбора товара в списке
        /// </summary>
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

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Обновление имени выбранного товара
        /// </summary>
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
        }

        /// <summary>
        /// Обновление описания выбранного товара
        /// </summary>
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
        }

        /// <summary>
        /// Обновление цены выбранного товара
        /// </summary>
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
        }

        /// <summary>
        /// Изменение категории выбранного товара
        /// </summary>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;
            if (index < 0) return;

            _items[index].Category = (Category)CategoryComboBox.SelectedItem;
        }
    }
}

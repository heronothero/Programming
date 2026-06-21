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
        private List<Item> _items = new List<Item>();
        private List<Item> _displayedItems = new List<Item>();
        private Func<List<Item>, List<Item>> _currentSorter = DataTools.SortByName;

        public event EventHandler ItemsChanged;

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

            OrderByComboBox.Items.Add("По имени");
            OrderByComboBox.Items.Add("Цена ↑");
            OrderByComboBox.Items.Add("Цена ↓");

            OrderByComboBox.SelectedIndex = 0;

            UpdateDisplayedItems();
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
                UpdateDisplayedItems();
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
        /// Вызывает событие изменения списка товаров
        /// </summary>
        private void OnItemsChanged()
        {
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Обработка добавления нового товара
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            Category category = Category.Аксессуары;

            if (CategoryComboBox.SelectedItem != null)
            {
                category = (Category)CategoryComboBox.SelectedItem;
            }

            Item item = new Item("New Item", "", 1, category);

            _items.Add(item);
            UpdateDisplayedItems();

            ItemsListBox.SelectedIndex = _displayedItems.IndexOf(item);
            OnItemsChanged();
        }

        /// <summary>
        /// Удаление выбранного товара
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;
            if (index < 0) return;

            var item = _displayedItems[index];

            _items.Remove(item);
            UpdateDisplayedItems();
            ClearFields();

            OnItemsChanged();
        }

        /// <summary>
        /// Генерация случайного товара через ItemFactory
        /// </summary>
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            Item item = ItemFactory.CreateRandom();

            _items.Add(item);
            UpdateDisplayedItems();

            ItemsListBox.SelectedIndex = _displayedItems.IndexOf(item);
            OnItemsChanged();
        }

        /// <summary>
        /// Обработка изменения выбора товара в списке
        /// </summary>
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;
            if (index < 0 || index >= _displayedItems.Count) return;

            Item item = _displayedItems[index];

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
            if (index < 0 || index >= _displayedItems.Count) return;

            try
            {
                var item = _displayedItems[index];
                item.Name = NameTextBox.Text;

                UpdateDisplayedItems();
                ItemsListBox.SelectedIndex = _displayedItems.IndexOf(item);

                NameTextBox.BackColor = Color.White;
                OnItemsChanged();
            }
            catch
            {
                NameTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обновление описания выбранного товара
        /// </summary>
        private void InfoTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;
            if (index < 0 || index >= _displayedItems.Count) return;

            try
            {
                var item = _displayedItems[index];
                item.Info = InfoTextBox.Text;

                UpdateDisplayedItems();
                ItemsListBox.SelectedIndex = _displayedItems.IndexOf(item);

                InfoTextBox.BackColor = Color.White;
                OnItemsChanged();
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
            if (index < 0 || index >= _displayedItems.Count) return;

            try
            {
                decimal cost = decimal.Parse(CostTextBox.Text);

                var item = _displayedItems[index];
                item.Cost = cost;

                UpdateDisplayedItems();
                ItemsListBox.SelectedIndex = _displayedItems.IndexOf(item);

                CostTextBox.BackColor = Color.White;
                OnItemsChanged();
            }
            catch
            {
                CostTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Изменение категории выбранного товара
        /// </summary>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;
            if (index < 0 || index >= _displayedItems.Count) return;

            if (CategoryComboBox.SelectedItem == null) return;

            var item = _displayedItems[index];
            item.Category = (Category)CategoryComboBox.SelectedItem;

            UpdateDisplayedItems();
            ItemsListBox.SelectedIndex = _displayedItems.IndexOf(item);

            OnItemsChanged();
        }

        /// <summary>
        /// Обработчик изменения текста для поиска товаров
        /// </summary>
        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateDisplayedItems();
        }

        /// <summary>
        /// Обновляет элементы списка товаров в ListBox
        /// </summary>
        private void UpdateItemsListBox()
        {
            ItemsListBox.Items.Clear();

            foreach (var item in _displayedItems)
            {
                ItemsListBox.Items.Add(item);
            }
        }

        /// <summary>
        /// Обновляет отображаемый список товаров с учетом фильтрации и сортировки
        /// </summary>
        private void UpdateDisplayedItems()
        {
            Item selectedItem = null;

            if (ItemsListBox.SelectedIndex >= 0 && ItemsListBox.SelectedIndex < _displayedItems.Count)
            {
                selectedItem = _displayedItems[ItemsListBox.SelectedIndex];
            }

            IEnumerable<Item> result = _items;

            string text = FindTextBox.Text?.ToLower() ?? "";

            if (!string.IsNullOrWhiteSpace(text))
            {
                result = DataTools.Filter(_items,
                    item => item.Name.ToLower().Contains(text));
            }

            _displayedItems = DataTools.Sort(result.ToList(), _currentSorter);

            UpdateItemsListBox();

            if (selectedItem != null && _displayedItems.Contains(selectedItem))
            {
                ItemsListBox.SelectedIndex = _displayedItems.IndexOf(selectedItem);
            }
        }

        /// <summary>
        /// Обновляет отображаемый список товаров с учетом сортировки (по названию и цене)
        /// </summary>
        private void OrderByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (OrderByComboBox.SelectedIndex)
            {
                case 0:
                    _currentSorter = DataTools.SortByName;
                    break;

                case 1:
                    _currentSorter = DataTools.SortByCostAsc;
                    break;

                case 2:
                    _currentSorter = DataTools.SortByCostDesc;
                    break;
            }

            UpdateDisplayedItems();
        }
    }
}

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

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Элемент управления для отображения и редактирования адреса
    /// </summary>
    public partial class AddressControl : UserControl
    {
        private Address _address = new Address();
        private ToolTip _toolTip = new ToolTip();

        /// <summary>
        /// Событие вызывается при изменении данных в адресе покупателя
        /// </summary>
        public event EventHandler AddressChanged;

        /// <summary>
        /// Текущий адрес
        /// При получении свойства выполняется валидация всех полей
        /// </summary>
        public Address Address
        {
            get => _address;
            set
            {
                _address = value ?? new Address();
                UpdateUI();
            }
        }

        /// <summary>
        /// Конструктор. Инициализирует компоненты и подписывает обработчики событий на текстовые поля
        /// </summary>
        public AddressControl()
        {
            InitializeComponent();

            PostIndexTextBox.TextChanged += PostIndexTextBox_TextChanged;
            CountryTextBox.TextChanged += CountryTextBox_TextChanged;
            CityTextBox.TextChanged += CityTextBox_TextChanged;
            StreetTextBox.TextChanged += StreetTextBox_TextChanged;
            BuildingTextBox.TextChanged += BuildingTextBox_TextChanged;
            ApartmentTextBox.TextChanged += ApartmentTextBox_TextChanged;
        }

        /// <summary>
        /// Обновляет значения текстовых полей на форме согласно текущему адресу
        /// </summary>
        private void UpdateUI()
        {
            if (_address == null) return;

            PostIndexTextBox.Text = _address.Index.ToString();
            CountryTextBox.Text = _address.Country;
            CityTextBox.Text = _address.City;
            StreetTextBox.Text = _address.Street;
            BuildingTextBox.Text = _address.Building;
            ApartmentTextBox.Text = _address.Apartment;
        }

        private void OnAddressChanged()
        {
            AddressChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Обрабатывает изменение почтового индекса. Подсвечивает поле при некорректном вводе и выводит подсказку
        /// </summary>
        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Index = int.Parse(PostIndexTextBox.Text);

                PostIndexTextBox.BackColor = Color.White;
                _toolTip.SetToolTip(PostIndexTextBox, "");

                OnAddressChanged();
            }
            catch (Exception ex)
            {
                PostIndexTextBox.BackColor = Color.LightPink;
                _toolTip.SetToolTip(PostIndexTextBox, ex.Message);
            }
        }

        /// <summary>
        /// Обрабатывает изменение страны. Подсвечивает поле при ошибке
        /// </summary>
        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Country = CountryTextBox.Text;

                CountryTextBox.BackColor = Color.White;
                OnAddressChanged();
            }
            catch
            {
                CountryTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обрабатывает изменения в городе. Подсвечивает поле при ошибке
        /// </summary>
        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.City = CityTextBox.Text;

                CityTextBox.BackColor = Color.White;
                OnAddressChanged();
            }
            catch
            {
                CityTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обрабатывает изменение улицы. Подсвечивает поле при ошибке
        /// </summary>
        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Street = StreetTextBox.Text;

                StreetTextBox.BackColor = Color.White;
                OnAddressChanged();
            }
            catch
            {
                StreetTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обрабатывает изменения здания. Подсвечивает поле при ошибке
        /// </summary>
        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Building = BuildingTextBox.Text;

                BuildingTextBox.BackColor = Color.White;
                OnAddressChanged();
            }
            catch
            {
                BuildingTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обрабатывает изменения квартиры. Подсвечивает поле при ошибке
        /// </summary>
        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Apartment = ApartmentTextBox.Text;

                ApartmentTextBox.BackColor = Color.White;
                OnAddressChanged();
            }
            catch
            {
                ApartmentTextBox.BackColor = Color.LightPink;
            }
        }

        private void AddressControl_Load(object sender, EventArgs e)
        {

        }

        private void AdressTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
